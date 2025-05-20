using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class DigitalString : StringBase
    {
        public DigitalString(string value) : base(value)
        {
        }

        public string Reverse()
        {
            char[] chars = _value.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        public string GetString()
        {
            return _value;
        }

        public int GetLengthOfString()
        {
            return GetLength();
        }
    }
}
