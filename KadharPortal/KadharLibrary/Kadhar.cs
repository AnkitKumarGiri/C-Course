using System;
using System.Text;

namespace KadharLibrary
{
    public class Kadhar
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Age { get; set; }

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
