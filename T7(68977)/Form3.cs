using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T7_68977_
{
    public partial class Form3 : Form
    {
        private int page = 1;

        public Form3()
        {
            InitializeComponent();
        }

        private void menu_btn_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            title_txt.Enabled = false;
            author_txt.Enabled = false;
            category_txt.Enabled = false;
            type_txt.Enabled = false;
            feat1_txt.Enabled = false;
            feat2_txt.Enabled = false;

            ShowBook();
            ResetPage();

        }

        private void ResetPage()
        {
            page_lbl.Text = $"{page} \\ {Library.GetBookCount()}";

            if (page == 1)
            {
                prev_btn.Enabled = false;
                next_btn.Enabled = true;
            }
            else if (page == Library.GetBookCount())
            {
                next_btn.Enabled = false;
                prev_btn.Enabled = true;
            }
            else
            {
                prev_btn.Enabled = true;
                next_btn.Enabled = true;
            }
        }

        private void ShowBook()
        {
            if (Library.GetBook(page).Type == "Paper Book")
            {
                PaperBook pbook = (PaperBook) Library.GetBook(page);
                title_txt.Text = pbook.Title;
                author_txt.Text = pbook.Author;
                category_txt.Text = pbook.Category;
                type_txt.Text= pbook.Type;
                feat1_txt.Text = pbook.Isbn;
                feat2_txt.Text = pbook.NumOfPages.ToString();

                feat1_lbl.Text = "Isbn:";
                feat2_lbl.Text = "Pages:";
            }
            else if(Library.GetBook(page).Type == "E-Book")
            {
                EBook ebook = (EBook) Library.GetBook(page);
                title_txt.Text = ebook.Title;
                author_txt.Text = ebook.Author;
                category_txt.Text = ebook.Category;
                type_txt.Text = ebook.Type;
                feat1_txt.Text = ebook.Format;
                feat2_txt.Text = ebook.FileSize.ToString();

                feat1_lbl.Text = "Format:";
                feat2_lbl.Text = "File Size:";
            }
            else if(Library.GetBook(page).Type == "Audio Book")
            {
                AudioBook audbook = (AudioBook) Library.GetBook(page);
                title_txt.Text = audbook.Title;
                author_txt.Text = audbook.Author;
                category_txt.Text = audbook.Category;
                type_txt.Text = audbook.Type;
                feat1_txt.Text = audbook.Narrator;
                feat2_txt.Text = audbook.Duration.ToString();

                feat1_lbl.Text = "Narrator:";
                feat2_lbl.Text = "Duration:";
            }
        }

        private void prev_btn_Click(object sender, EventArgs e)
        {
            page--;
            ResetPage();
            ShowBook();
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            page++;
            ResetPage();
            ShowBook();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if(edit_btn.Text == "Edit")
            {
                edit_btn.Text = "Apply";

                title_txt.Enabled = true;
                author_txt.Enabled = true;
                category_txt.Enabled = true;
                feat1_txt.Enabled = true;
                feat2_txt.Enabled = true;
            }
            else if (edit_btn.Text == "Apply")
            {
                edit_btn.Text = "Edit";

                string title = title_txt.Text;
                string author = author_txt.Text;
                string category = category_txt.Text;
                string type = type_txt.Text;
                string feat1 = feat1_txt.Text;
                int feat2 = Convert.ToInt32(feat2_txt.Text);

                Library.EditListOrDelete("Edit", page, title, author, category, type, feat1, feat2);

                title_txt.Enabled = false;
                author_txt.Enabled = false;
                category_txt.Enabled = false;
                feat1_txt.Enabled = false;
                feat2_txt.Enabled = false;

                ShowBook();
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Do you confirm removing the current book?", 
                "Confirmation", buttons);
            if (result == DialogResult.Yes)
            {
                string title = title_txt.Text;
                string author = author_txt.Text;
                string category = category_txt.Text;
                string type = type_txt.Text;
                string feat1 = feat1_txt.Text;
                int feat2 = Convert.ToInt32(feat2_txt.Text);

                Library.EditListOrDelete("Delete", page, title, author, category, type, feat1, feat2);

                page--;
                ResetPage();
                ShowBook();
            }
            else if(result == DialogResult.No)
            {
                //do nothing
            }
        }
    }
}
