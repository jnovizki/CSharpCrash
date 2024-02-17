using System;
using System.IO;
using System.Configuration;
using System.Collections.Specialized;
using System.Data.Sql;
using System.Data.SqlClient;

public class FileIOApps
{
    public static void Main(string[] args)
    {
        string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
        //This will strip just the working path name:
        //C:\Program Files\MyApplication
        string strWorkPath = System.IO.Path.GetDirectoryName(strExeFilePath);
        
        int ilast = strWorkPath.LastIndexOf(@"\");
        strWorkPath = strWorkPath.Substring(0, ilast);
        Console.WriteLine("strWorkPath" + strWorkPath);

        StreamWriter sw = new StreamWriter(strWorkPath + "\\" + "test.txt",true);
        string buffer = "Hola";
        sw.Write(buffer);
        sw.Close();

        string fpath = strWorkPath + "\\" + "testFileStream.txt";
        FileStream fs = new FileStream(fpath, FileMode.CreateNew);
        sw = new StreamWriter(fs);
        sw.WriteLine("Grabo con FileStream y StreamWriter");
        sw.Write("Otra linea");
        sw.Flush();
        sw.Close();
        fs.Close();



    }
}
