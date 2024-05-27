namespace T7_68977_
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu_btn = new System.Windows.Forms.Button();
            this.audio_grpbox = new System.Windows.Forms.GroupBox();
            this.dur_txt = new System.Windows.Forms.TextBox();
            this.narrat_txt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.audio_add_btn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.e_grpbox = new System.Windows.Forms.GroupBox();
            this.size_txt = new System.Windows.Forms.TextBox();
            this.format_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.e_add_btn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.paper_grpbox = new System.Windows.Forms.GroupBox();
            this.pages_txt = new System.Windows.Forms.TextBox();
            this.isbn_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.paper_add_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.type_cmbox = new System.Windows.Forms.ComboBox();
            this.category_txt = new System.Windows.Forms.TextBox();
            this.author_txt = new System.Windows.Forms.TextBox();
            this.title_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.audio_grpbox.SuspendLayout();
            this.e_grpbox.SuspendLayout();
            this.paper_grpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_btn
            // 
            this.menu_btn.BackColor = System.Drawing.Color.Tan;
            this.menu_btn.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menu_btn.Location = new System.Drawing.Point(182, 701);
            this.menu_btn.Name = "menu_btn";
            this.menu_btn.Size = new System.Drawing.Size(400, 50);
            this.menu_btn.TabIndex = 29;
            this.menu_btn.Text = "Back To Menu";
            this.menu_btn.UseVisualStyleBackColor = false;
            this.menu_btn.Click += new System.EventHandler(this.menu_btn_Click);
            // 
            // audio_grpbox
            // 
            this.audio_grpbox.BackColor = System.Drawing.Color.LightPink;
            this.audio_grpbox.Controls.Add(this.dur_txt);
            this.audio_grpbox.Controls.Add(this.narrat_txt);
            this.audio_grpbox.Controls.Add(this.label10);
            this.audio_grpbox.Controls.Add(this.audio_add_btn);
            this.audio_grpbox.Controls.Add(this.label11);
            this.audio_grpbox.Enabled = false;
            this.audio_grpbox.Location = new System.Drawing.Point(46, 548);
            this.audio_grpbox.Name = "audio_grpbox";
            this.audio_grpbox.Size = new System.Drawing.Size(673, 105);
            this.audio_grpbox.TabIndex = 27;
            this.audio_grpbox.TabStop = false;
            this.audio_grpbox.Text = "Audio Book";
            // 
            // dur_txt
            // 
            this.dur_txt.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dur_txt.Location = new System.Drawing.Point(282, 57);
            this.dur_txt.Name = "dur_txt";
            this.dur_txt.Size = new System.Drawing.Size(222, 31);
            this.dur_txt.TabIndex = 14;
            // 
            // narrat_txt
            // 
            this.narrat_txt.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.narrat_txt.Location = new System.Drawing.Point(21, 57);
            this.narrat_txt.Name = "narrat_txt";
            this.narrat_txt.Size = new System.Drawing.Size(222, 31);
            this.narrat_txt.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(278, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 22);
            this.label10.TabIndex = 5;
            this.label10.Text = "Duration:";
            // 
            // audio_add_btn
            // 
            this.audio_add_btn.BackColor = System.Drawing.Color.Tan;
            this.audio_add_btn.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.audio_add_btn.Location = new System.Drawing.Point(549, 40);
            this.audio_add_btn.Name = "audio_add_btn";
            this.audio_add_btn.Size = new System.Drawing.Size(101, 35);
            this.audio_add_btn.TabIndex = 4;
            this.audio_add_btn.Text = "Add";
            this.audio_add_btn.UseVisualStyleBackColor = false;
            this.audio_add_btn.Click += new System.EventHandler(this.audio_add_btn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(17, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 22);
            this.label11.TabIndex = 0;
            this.label11.Text = "Narrator:";
            // 
            // e_grpbox
            // 
            this.e_grpbox.BackColor = System.Drawing.Color.Thistle;
            this.e_grpbox.Controls.Add(this.size_txt);
            this.e_grpbox.Controls.Add(this.format_txt);
            this.e_grpbox.Controls.Add(this.label7);
            this.e_grpbox.Controls.Add(this.e_add_btn);
            this.e_grpbox.Controls.Add(this.label9);
            this.e_grpbox.Enabled = false;
            this.e_grpbox.Location = new System.Drawing.Point(46, 399);
            this.e_grpbox.Name = "e_grpbox";
            this.e_grpbox.Size = new System.Drawing.Size(673, 105);
            this.e_grpbox.TabIndex = 28;
            this.e_grpbox.TabStop = false;
            this.e_grpbox.Text = "E-Book";
            // 
            // size_txt
            // 
            this.size_txt.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.size_txt.Location = new System.Drawing.Point(282, 57);
            this.size_txt.Name = "size_txt";
            this.size_txt.Size = new System.Drawing.Size(222, 31);
            this.size_txt.TabIndex = 14;
            // 
            // format_txt
            // 
            this.format_txt.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.format_txt.Location = new System.Drawing.Point(21, 57);
            this.format_txt.Name = "format_txt";
            this.format_txt.Size = new System.Drawing.Size(222, 31);
            this.format_txt.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(278, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 22);
            this.label7.TabIndex = 5;
            this.label7.Text = "File Size:";
            // 
            // e_add_btn
            // 
            this.e_add_btn.BackColor = System.Drawing.Color.Tan;
            this.e_add_btn.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.e_add_btn.Location = new System.Drawing.Point(549, 42);
            this.e_add_btn.Name = "e_add_btn";
            this.e_add_btn.Size = new System.Drawing.Size(101, 35);
            this.e_add_btn.TabIndex = 4;
            this.e_add_btn.Text = "Add";
            this.e_add_btn.UseVisualStyleBackColor = false;
            this.e_add_btn.Click += new System.EventHandler(this.e_add_btn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(17, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "Format:";
            // 
            // paper_grpbox
            // 
            this.paper_grpbox.BackColor = System.Drawing.Color.NavajoWhite;
            this.paper_grpbox.Controls.Add(this.pages_txt);
            this.paper_grpbox.Controls.Add(this.isbn_txt);
            this.paper_grpbox.Controls.Add(this.label8);
            this.paper_grpbox.Controls.Add(this.paper_add_btn);
            this.paper_grpbox.Controls.Add(this.label5);
            this.paper_grpbox.Enabled = false;
            this.paper_grpbox.Location = new System.Drawing.Point(46, 253);
            this.paper_grpbox.Name = "paper_grpbox";
            this.paper_grpbox.Size = new System.Drawing.Size(673, 105);
            this.paper_grpbox.TabIndex = 26;
            this.paper_grpbox.TabStop = false;
            this.paper_grpbox.Text = "Paper Book";
            // 
            // pages_txt
            // 
            this.pages_txt.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pages_txt.Location = new System.Drawing.Point(282, 57);
            this.pages_txt.Name = "pages_txt";
            this.pages_txt.Size = new System.Drawing.Size(222, 31);
            this.pages_txt.TabIndex = 14;
            // 
            // isbn_txt
            // 
            this.isbn_txt.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isbn_txt.Location = new System.Drawing.Point(21, 57);
            this.isbn_txt.Name = "isbn_txt";
            this.isbn_txt.Size = new System.Drawing.Size(222, 31);
            this.isbn_txt.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(278, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 22);
            this.label8.TabIndex = 5;
            this.label8.Text = "Pages:";
            // 
            // paper_add_btn
            // 
            this.paper_add_btn.BackColor = System.Drawing.Color.Tan;
            this.paper_add_btn.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paper_add_btn.Location = new System.Drawing.Point(549, 37);
            this.paper_add_btn.Name = "paper_add_btn";
            this.paper_add_btn.Size = new System.Drawing.Size(101, 35);
            this.paper_add_btn.TabIndex = 4;
            this.paper_add_btn.Text = "Add";
            this.paper_add_btn.UseVisualStyleBackColor = false;
            this.paper_add_btn.Click += new System.EventHandler(this.paper_add_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(17, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "ISBN:";
            // 
            // type_cmbox
            // 
            this.type_cmbox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type_cmbox.FormattingEnabled = true;
            this.type_cmbox.Items.AddRange(new object[] {
            "Paper Book",
            "E-Book",
            "Audio Book"});
            this.type_cmbox.Location = new System.Drawing.Point(497, 172);
            this.type_cmbox.Name = "type_cmbox";
            this.type_cmbox.Size = new System.Drawing.Size(222, 31);
            this.type_cmbox.TabIndex = 25;
            this.type_cmbox.SelectedIndexChanged += new System.EventHandler(this.type_cmbox_SelectedIndexChanged);
            // 
            // category_txt
            // 
            this.category_txt.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.category_txt.Location = new System.Drawing.Point(513, 82);
            this.category_txt.Name = "category_txt";
            this.category_txt.Size = new System.Drawing.Size(222, 31);
            this.category_txt.TabIndex = 24;
            // 
            // author_txt
            // 
            this.author_txt.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.author_txt.Location = new System.Drawing.Point(139, 172);
            this.author_txt.Name = "author_txt";
            this.author_txt.Size = new System.Drawing.Size(222, 31);
            this.author_txt.TabIndex = 23;
            // 
            // title_txt
            // 
            this.title_txt.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title_txt.Location = new System.Drawing.Point(139, 82);
            this.title_txt.Name = "title_txt";
            this.title_txt.Size = new System.Drawing.Size(222, 31);
            this.title_txt.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(393, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(393, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Category:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(53, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 22);
            this.label6.TabIndex = 19;
            this.label6.Text = "Author:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(53, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(311, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 27);
            this.label1.TabIndex = 17;
            this.label1.Text = "Add a Book";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(760, 781);
            this.Controls.Add(this.menu_btn);
            this.Controls.Add(this.audio_grpbox);
            this.Controls.Add(this.e_grpbox);
            this.Controls.Add(this.paper_grpbox);
            this.Controls.Add(this.type_cmbox);
            this.Controls.Add(this.category_txt);
            this.Controls.Add(this.author_txt);
            this.Controls.Add(this.title_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.audio_grpbox.ResumeLayout(false);
            this.audio_grpbox.PerformLayout();
            this.e_grpbox.ResumeLayout(false);
            this.e_grpbox.PerformLayout();
            this.paper_grpbox.ResumeLayout(false);
            this.paper_grpbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button menu_btn;
        private System.Windows.Forms.GroupBox audio_grpbox;
        private System.Windows.Forms.TextBox dur_txt;
        private System.Windows.Forms.TextBox narrat_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button audio_add_btn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox e_grpbox;
        private System.Windows.Forms.TextBox size_txt;
        private System.Windows.Forms.TextBox format_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button e_add_btn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox paper_grpbox;
        private System.Windows.Forms.TextBox pages_txt;
        private System.Windows.Forms.TextBox isbn_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button paper_add_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox type_cmbox;
        private System.Windows.Forms.TextBox category_txt;
        private System.Windows.Forms.TextBox author_txt;
        private System.Windows.Forms.TextBox title_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}