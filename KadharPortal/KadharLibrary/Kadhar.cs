using System;
using System.IO;
using System.Text;

namespace KadharLibrary
{
    public class Kadhar
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Age { get; set; }

        // For learning purpose only.
        public string ReadFile()
        {
            try
            {
                var sr = new StreamReader(@"C:\Users\angiri\source\repos\C-Course\KadharPortal\test.txt");
                string contents = sr.ReadToEnd();
                return contents;
            }
            catch(Exception ex)
            {
                return ex.Message.ToString();
            }
            
        }
        public override string ToString()
        {
            StringBuilder ret = new StringBuilder();
            ret.AppendLine(Name);
            ret.AppendLine(FatherName);
            ret.AppendLine(Age);
            return ret.ToString();
        }
    }
}
