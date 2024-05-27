using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T7_68977_
{
    public partial class Form2 : Form
    {
        public Form2()
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

        private void type_cmbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type_cmbox.SelectedItem.ToString() == "Paper Book")
            {
                paper_grpbox.Enabled = true;
                e_grpbox.Enabled = false;
                audio_grpbox.Enabled = false;
            }
            else if (type_cmbox.SelectedItem.ToString() == "E-Book")
            {
                paper_grpbox.Enabled = false;
                e_grpbox.Enabled = true;
                audio_grpbox.Enabled = false;
            }
            else if (type_cmbox.SelectedItem.ToString() == "Audio Book")
            {
                paper_grpbox.Enabled = false;
                e_grpbox.Enabled = false;
                audio_grpbox.Enabled = true;
            }
        }

        private void paper_add_btn_Click(object sender, EventArgs e)
        {
            string title = title_txt.Text;
            string author = author_txt.Text;
            string category = category_txt.Text;
            string type = type_cmbox.SelectedItem.ToString();
            string isbn = isbn_txt.Text;
            int pages = Convert.ToInt32(pages_txt.Text);

            Library.AddToList(title, author, category, type, isbn, pages);
            Library.WriteToFile();

            title_txt.Clear();
            author_txt.Clear();
            category_txt.Clear();
            isbn_txt.Clear();
            pages_txt.Clear();
            type_cmbox.Text = "";
        }

        private void e_add_btn_Click(object sender, EventArgs e)
        {
            string title = title_txt.Text;
            string author = author_txt.Text;
            string category = category_txt.Text;
            string type = type_cmbox.SelectedItem.ToString();
            string format = format_txt.Text;
            int fileSize = Convert.ToInt32(size_txt.Text);

            Library.AddToList(title, author, category, type, format, fileSize);
            Library.WriteToFile();

            title_txt.Clear();
            author_txt.Clear();
            category_txt.Clear();
            isbn_txt.Clear();
            format_txt.Clear();
            size_txt.Clear();
            type_cmbox.Text = "";
        }

        private void audio_add_btn_Click(object sender, EventArgs e)
        {
            string title = title_txt.Text;
            string author = author_txt.Text;
            string category = category_txt.Text;
            string type = type_cmbox.SelectedItem.ToString();
            string narrator = narrat_txt.Text;
            int duration = Convert.ToInt32(dur_txt.Text);

            Library.AddToList(title, author, category, type, narrator, duration);
            Library.WriteToFile();

            title_txt.Clear();
            author_txt.Clear();
            category_txt.Clear();
            isbn_txt.Clear();
            narrat_txt.Clear();
            dur_txt.Clear();
            type_cmbox.Text = "";
        }

        
    }
}
