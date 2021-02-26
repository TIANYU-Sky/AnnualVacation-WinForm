using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using AVMSDT;
using Microsoft.Office.Interop.Excel;

namespace 年假管理系统.Utils
{
    internal class Serialize
    {
        public static bool SerializeInforMainPackage(out byte[] serialdata, AVMSBT.Encryption.ICipher encryption)
        {
            serialdata = null;
            try
            {
                InformationMainPackage infor = new InformationMainPackage
                {
                    UsersLoginInfor = OperationData.LoginData
                };
                foreach (KeyValuePair<string, DepartmentOperationData> i in OperationData.EmpolyeeData)
                    infor.DepartmentInfor.Add(i.Key, new KeyValuePair<string, bool>(i.Value.FileID, i.Value.SubDepartment));
                MemoryStream stream = new MemoryStream();
                new BinaryFormatter().Serialize(stream, infor);
                serialdata = encryption.encryption(stream.ToArray());
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static bool UnSerializeInforMainPackage(byte[] serialdata, AVMSBT.Encryption.ICipher encryption)
        {
            try
            {
                serialdata = encryption.decryption(serialdata);
                MemoryStream stream = new MemoryStream();
                stream.Write(serialdata, 0, serialdata.Length);
                stream.Position = 0;
                InformationMainPackage infor = (InformationMainPackage)new BinaryFormatter().Deserialize(stream);
                stream.Close();
                OperationData.LoginData = infor.UsersLoginInfor;
                foreach(KeyValuePair<string, KeyValuePair<string, bool>> i in infor.DepartmentInfor)
                {
                    OperationData.EmpolyeeData.Add
                        (
                        i.Key,
                        new DepartmentOperationData
                        {
                            FileID = i.Value.Key,
                            SubDepartment = i.Value.Value,
                            Empolyees = new Dictionary<string, EmployeePersonalInformation>()
                        }
                        );
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public static bool SerializeEmployeeInfor(Dictionary<string, EmployeePersonalInformation> obj, out byte[] serialdata, AVMSBT.Encryption.ICipher encryption)
        {
            serialdata = null;
            try
            {
                MemoryStream stream = new MemoryStream();
                new BinaryFormatter().Serialize(stream, obj);
                serialdata = encryption.encryption(stream.ToArray());
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static bool UnSerializeEmployeeInfor(string department, byte[] serialdata, AVMSBT.Encryption.ICipher encryption)
        {
            try
            {
                serialdata = encryption.decryption(serialdata);
                MemoryStream stream = new MemoryStream();
                stream.Write(serialdata, 0, serialdata.Length);
                stream.Position = 0;
                Dictionary<string, EmployeePersonalInformation> infor = (Dictionary<string, EmployeePersonalInformation>)new BinaryFormatter().Deserialize(stream);
                stream.Close();
                foreach (KeyValuePair<string, DepartmentOperationData> i in OperationData.EmpolyeeData)
                {
                    if (i.Key == department)
                    {
                        i.Value.Empolyees = i.Value.Empolyees.Concat(infor).ToDictionary(k => k.Key, v => v.Value);
                        i.Value.IsOpen = true;
                        break;
                    }
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public static bool ImportFromExcel()
        {
            return true;
        }
        public static bool ExportToExcel()
        {
            return true;
        }
    }
}
