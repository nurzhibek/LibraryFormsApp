using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7_68977_
{
    class EBook : Book
    {
        private string _format;
        private int _fileSize;

        public EBook(string title, string author, string category,
            string format, int fileSize) : base(title, author, category, "E-Book")
        {
            Format = format;
            FileSize = fileSize;
        }

        public override void WriteToFile(StreamWriter sw)
        {
            base.WriteToFile(sw);
            sw.Write($"${Format}${FileSize}");
        }

        public string Format
        {
            get { return _format; }
            set
            {
                if ((value.Length > 0) && (!String.IsNullOrEmpty(value)))
                {
                    _format = value.Trim();
                }
                else
                {
                    throw new Exception("The Format cannot be empty!");
                }
            }
        }

        public int FileSize
        {
            get { return _fileSize; }
            set
            {
                if ((value > 0) && (!String.IsNullOrEmpty(value.ToString())))
                {
                    _fileSize = value;
                }
                else
                {
                    throw new Exception("The FileSize cannot be empty or less than one!");
                }
            }
        }
    }
}
