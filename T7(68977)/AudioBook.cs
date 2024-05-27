using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7_68977_
{
    class AudioBook : Book
    {
        private string _narrator;
        private int _duration;

        public AudioBook(string title, string author, string category,
            string narrator, int duration) : base(title, author, category, "Audio Book")
        {
            Narrator = narrator;
            Duration = duration;
        }

        public override void WriteToFile(StreamWriter sw)
        {
            base.WriteToFile(sw);
            sw.Write($"${Narrator}${Duration}");
        }

        public string Narrator
        {
            get { return _narrator; }
            set
            {
                if ((value.Length > 0) && (!String.IsNullOrEmpty(value)))
                {
                    _narrator = value.Trim();
                }
                else
                {
                    throw new Exception("The Narrator cannot be empty!");
                }
            }
        }

        public int Duration
        {
            get { return _duration; }
            set
            {
                if ((value > 0) && (!String.IsNullOrEmpty(value.ToString())))
                {
                    _duration = value;
                }
                else
                {
                    throw new Exception("The Duration cannot be empty or less than one!");
                }
            }
        }
    }
}
