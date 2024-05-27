using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7_68977_
{
    class PaperBook : Book
    {
        private string _isbn;
        private int _numOfPages;


        public PaperBook(string title, string author, string category,
            string isbn, int numOfPages) : base(title, author, category, "Paper Book")
        {
            Isbn = isbn;
            NumOfPages = numOfPages;
        }

        public override void WriteToFile(StreamWriter sw) 
        {
            base.WriteToFile(sw);
            sw.Write($"${Isbn}${NumOfPages}");
        }

        public string Isbn
        {
            get { return _isbn; }
            set
            {
                if ((value.Length > 0) && (!String.IsNullOrEmpty(value)))
                {
                    _isbn = value.Trim();
                }
                else
                {
                    throw new Exception("The Isbn cannot be empty!");
                }
            }
        }

        public int NumOfPages
        {
            get { return _numOfPages; }
            set
            {
                if ((value > 0) && (!String.IsNullOrEmpty(value.ToString())))
                {
                    _numOfPages = value;
                }
                else
                {
                    throw new Exception("The NumOfPages cannot be empty or less than one!");
                }
            }
        }
    }
}
