namespace ClassLibrary1
{
    public class StringBase
    {
        protected string _value;

        public StringBase(string value)
        {
            _value = value;
        }

        public int GetLength()
        {
            return _value.Length;
        }

        public string GetValue()
        {
            return _value;
        }
    }
 }
