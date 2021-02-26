using AVMSDT;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 年假管理系统.Utils
{
    internal class Files
    {
        public static void OpenFiles(string filepath)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(filepath);
            string fullname = filepath + "\\" + directoryInfo.Name + StaticData.MainFileExtension;
            if (File.Exists(fullname))
            {
                Stream stream = new FileStream(fullname, FileMode.Open, FileAccess.Read, FileShare.Read);
                byte[] source = new byte[stream.Length];
                stream.Read(source, 0, source.Length);
                stream.Close();
                if (!Serialize.UnSerializeInforMainPackage(source, AVMSBT.Encryption.NoEncryption.Increase()))
                    System.Windows.Forms.MessageBox.Show("文件异常 打开失败");
                else
                {
                    OperationData.DirectoryName = directoryInfo.Name;
                    OperationData.FileDictionary = filepath;
                    OperationData.FileIsOpen = true;
                    OperationData.FileInitOperation();
                }
                return;
            }
            System.Windows.Forms.MessageBox.Show(filepath + "中不存在指定文件（" + fullname + "）");
        }
        public static void SaveFiles()
        {
            // 保存主文件
            string mainpath = OperationData.FileDictionary + "\\" + OperationData.DirectoryName + StaticData.MainFileExtension;
            byte[] mainbytes;
            if (!Serialize.SerializeInforMainPackage(out mainbytes, AVMSBT.Encryption.NoEncryption.Increase())) 
            {
                System.Windows.Forms.MessageBox.Show("保存失败 请重试");
                return;
            }
            Stream stream = new FileStream(mainpath, FileMode.Create, FileAccess.Write, FileShare.Read);
            stream.Write(mainbytes, 0, mainbytes.Length);
            stream.Flush();
            stream.Close();

            // 循环保存子文件
            foreach (KeyValuePair<string, DepartmentOperationData> i in OperationData.EmpolyeeData)
            {
                if (i.Value.IsOpen)
                {
                    byte[] vs;
                    string departmentpath = OperationData.FileDictionary + "\\" + i.Value.FileID + StaticData.DepartmentFileExtension;
                    if (!Serialize.SerializeEmployeeInfor(i.Value.Empolyees, out vs, AVMSBT.Encryption.NoEncryption.Increase()))
                    {
                        System.Windows.Forms.MessageBox.Show("保存失败 请重试");
                        return;
                    }
                    stream = new FileStream(departmentpath, FileMode.Create, FileAccess.Write, FileShare.Read);
                    stream.Write(vs, 0, vs.Length);
                    stream.Flush();
                    stream.Close();
                }
            }
        }

        public static bool LoadFile(string department_name)
        {
            string path = OperationData.FileDictionary + "\\" + OperationData.EmpolyeeData[department_name].FileID + AVMSDT.StaticData.DepartmentFileExtension;
            if (File.Exists(path))
            {
                Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
                byte[] source = new byte[stream.Length];
                stream.Read(source, 0, source.Length);
                stream.Close();
                if (Serialize.UnSerializeEmployeeInfor(department_name, source, AVMSBT.Encryption.NoEncryption.Increase()))
                    return true;
            }
            OperationData.EmpolyeeData[department_name].IsOpen = true;
            return false;
        }
    }
}
