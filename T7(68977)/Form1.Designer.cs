namespace T7_68977_
{
    partial class Form1
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
            this.exit_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.read_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.Tan;
            this.exit_btn.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_btn.Location = new System.Drawing.Point(101, 398);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(300, 55);
            this.exit_btn.TabIndex = 5;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.Tan;
            this.add_btn.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_btn.Location = new System.Drawing.Point(101, 123);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(300, 55);
            this.add_btn.TabIndex = 4;
            this.add_btn.Text = "Add a Book";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(178, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "My Library";
            // 
            // read_btn
            // 
            this.read_btn.BackColor = System.Drawing.Color.Tan;
            this.read_btn.Font = new System.Drawing.Font("Consolas", 10.8F);
            this.read_btn.Location = new System.Drawing.Point(101, 226);
            this.read_btn.Name = "read_btn";
            this.read_btn.Size = new System.Drawing.Size(300, 55);
            this.read_btn.TabIndex = 6;
            this.read_btn.Text = "Read and Edit";
            this.read_btn.UseVisualStyleBackColor = false;
            this.read_btn.Click += new System.EventHandler(this.read_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(482, 503);
            this.Controls.Add(this.read_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button read_btn;
    }
}

