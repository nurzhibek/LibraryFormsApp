using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7_68977_
{
    static class Library
    {
        static private List<Book> books = new List<Book>();
        static private string fileName = "books.txt";


        static public void AddToList(string title, string author, string category, string type,
            string feat1, int feat2)
        { AddToListFromObjectPriv(title, author, category, type, feat1, feat2); }


        static private void AddToListFromObjectPriv(string title, string author, string category, 
            string type, string feat1, int feat2)
        {
            if (type == "Paper Book")
            {
                PaperBook pbook = new PaperBook(title, author, category, feat1, feat2);
                books.Add(pbook);
            }
            else if (type == "E-Book")
            {
                EBook ebook = new EBook(title, author, category, feat1, feat2);
                books.Add(ebook);
            }
            else if (type == "Audio Book")
            {
                AudioBook audbook = new AudioBook(title, author, category, feat1, feat2);
                books.Add(audbook);
            }

        }

        static private void AddToTheListFromFilePriv()
        {
            books.Clear();

            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] splitted = line.Split('$');

                string title = splitted[0];
                string author = splitted[1];
                string category = splitted[2];
                string type = splitted[3];
                string feat1 = splitted[4];
                int feat2 = Convert.ToInt32(splitted[5]);

                AddToListFromObjectPriv(title, author, category, type, feat1, feat2);
            }

            sr.Close();
            fs.Close();
        }

        static public void WriteToFile()
        {
            WriteToFilePriv();
            books.Clear();
        }

        static private void WriteToFilePriv()
        {
            FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            foreach (Book book in books)
            {
                if (book.Type == "Paper Book")
                {
                    PaperBook pbook = (PaperBook)book;
                    pbook.WriteToFile(sw);
                    sw.WriteLine();
                }
                else if (book.Type == "E-Book")
                {
                    EBook ebook = (EBook)book;
                    ebook.WriteToFile(sw);
                    sw.WriteLine();
                }
                else if (book.Type == "Audio Book")
                {
                    AudioBook audbook = (AudioBook)book;
                    audbook.WriteToFile(sw);
                    sw.WriteLine();
                }
            }

            sw.Close();
            fs.Close();

            books.Clear();
        }

        static public Book GetBook(int page)
        {
            return GetBookPriv(page);
        }

        static private Book GetBookPriv(int page)
        {
            AddToTheListFromFilePriv();
            return books[page - 1];
        }

        static public int GetBookCount()
        {
            return books.Count;
        }

        static private void EditListOrDeletePriv(string goal,int page, string title, string author, 
            string category, string type, string feat1, int feat2)
        {
            books.RemoveAt(page - 1);
            if (goal == "Edit")
            {
                if (type == "Paper Book")
                {
                    PaperBook pbook = new PaperBook(title, author, category, feat1, feat2);
                    books.Insert(page - 1, pbook);
                }
                else if (type == "E-Book")
                {
                    EBook ebook = new EBook(title, author, category, feat1, feat2);
                    books.Insert(page - 1, ebook);
                }
                else if (type == "Audio Book")
                {
                    AudioBook audbook = new AudioBook(title, author, category, feat1, feat2);
                    books.Insert(page - 1, audbook);
                }
            }

            RewriteFilePriv();
        }

        static public void EditListOrDelete(string goal,int page, string title, string author, string category, 
            string type, string feat1, int feat2)
        {
            EditListOrDeletePriv(goal,page, title, author, category, type, feat1, feat2);
        }

        static private void RewriteFilePriv()
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            foreach (Book book in books)
            {
                if (book.Type == "Paper Book")
                {
                    PaperBook pbook = (PaperBook)book;
                    pbook.WriteToFile(sw);
                    sw.WriteLine();
                }
                else if (book.Type == "E-Book")
                {
                    EBook ebook = (EBook)book;
                    ebook.WriteToFile(sw);
                    sw.WriteLine();
                }
                else if (book.Type == "Audio Book")
                {
                    AudioBook audbook = (AudioBook)book;
                    audbook.WriteToFile(sw);
                    sw.WriteLine();
                }
            }

            sw.Close();
            fs.Close();
        }

    }
}
