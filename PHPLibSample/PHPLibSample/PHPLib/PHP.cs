using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AlphaOneFilesSync.PHPLib
{
    class PHP
    {

        public static bool preg_match(string pattern, string text)
        {
            return (Regex.IsMatch(text, pattern, RegexOptions.IgnoreCase)) ? true : false;
        }

        public static string dirname(string filename)
        {
            string[] tmp = PHP.explode('\\', filename);
            tmp[(tmp.Length - 1)] = "";
            string txt = PHP.implode('\\', tmp);
            return txt;
        }

        public static string basename(string filename)
        {
            filename = Path.GetFileName(filename);
            return filename;
        }

        public static string[] explode(char delimeter, string text)
        {
            char[] delimiterChars = { delimeter };
            string[] words = text.Split(delimiterChars);
            return words;
        }

        public static string implode(char delimeter, string[] words)
        {
            string text = ""; ;
            foreach (var txt in words) {
                text += (text == "") ? txt : delimeter.ToString() + txt;
            }
            return text;
        }

        public static string md5(string text)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            byte[] dataMd5 = md5.ComputeHash(Encoding.Default.GetBytes(text));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < dataMd5.Length; i++)
            {
                sb.AppendFormat("{0:x2}", dataMd5[i]);
            }

            return sb.ToString();
        }

        public static string md5_file(string fileName)
        {
            if (File.Exists(fileName))
            {
                FileStream file = new FileStream(fileName, FileMode.Open);
                MD5 md5 = new MD5CryptoServiceProvider();
                int length = (int)file.Length;  // get file length
                byte[] buffer = new byte[length];      // create buffer
                int count;                      // actual number of bytes read
                int sum = 0;                    // total number of bytes read

                // read until Read method returns 0 (end of the stream has been reached)
                while ((count = file.Read(buffer, sum, length - sum)) > 0)
                    sum += count;  // sum is a buffer offset for next reading
                byte[] retVal = md5.ComputeHash(buffer);
                file.Close();

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < retVal.Length; i++)
                {
                    sb.Append(retVal[i].ToString("x2"));
                }
                return sb.ToString();
            }
            else
            {
                return "";
            }
        }
    }
}
