using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WF_DiemDanh
{
    class DocGhiFile
    {
        public static string DocFile(string namePath)
        {
            StreamReader fi = new StreamReader(@namePath);
            string st = fi.ReadToEnd();
            fi.Close();
            return st;
        }
        public static void GhiFile(string namePath, string a)
        {
            StreamWriter fo = new StreamWriter(namePath);
            fo.Write(a);
            fo.Close();
        }
    }
}
