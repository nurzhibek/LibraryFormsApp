using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7_68977_
{
    class Book
    {
        private string _title;
        private string _author;
        private string _category;
        private string _type;

        public Book(string title, string author, string category, string type)
        {
            Title = title;
            Author = author;
            Category = category;
            _type = type;
        }

        public virtual void WriteToFile(StreamWriter sw)
        {
            sw.Write($"{Title}${Author}${Category}${Type}");
        }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if ((value.Length > 0) && (!String.IsNullOrEmpty(value)))
                {
                    _title = value.Trim();
                }
                else
                {
                    throw new Exception("The Title cannot be empty!");
                }
            }
        }

        public string Author
        {
            get
            {
                return _author;
            }
            set
            {
                if ((value.Length > 0) && (!String.IsNullOrEmpty(value)))
                {
                    _author = value.Trim();
                }
                else
                {
                    throw new Exception("The Author cannot be empty!");
                }
            }
        }

        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                if ((value.Length > 0) && (!String.IsNullOrEmpty(value)))
                {
                    _category = value.Trim();
                }
                else
                {
                    throw new Exception("The Category cannot be empty!");
                }
            }
        }

        public string Type
        {
            get { return _type; }
        }
    }
}
