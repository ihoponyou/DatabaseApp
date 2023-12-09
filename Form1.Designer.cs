namespace MagcalasCullen_CSCI366_GroupProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            storeBtn = new Button();
            libraryBtn = new Button();
            button3 = new Button();
            button4 = new Button();
            library1 = new DatabaseApp.pages.Library();
            store1 = new DatabaseApp.pages.Store();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // storeBtn
            // 
            storeBtn.Location = new Point(70, 12);
            storeBtn.Name = "storeBtn";
            storeBtn.Size = new Size(75, 23);
            storeBtn.TabIndex = 0;
            storeBtn.Text = "Store";
            storeBtn.UseVisualStyleBackColor = true;
            storeBtn.Click += storeBtn_Click;
            // 
            // libraryBtn
            // 
            libraryBtn.Location = new Point(151, 12);
            libraryBtn.Name = "libraryBtn";
            libraryBtn.Size = new Size(75, 23);
            libraryBtn.TabIndex = 1;
            libraryBtn.Text = "Library";
            libraryBtn.UseVisualStyleBackColor = true;
            libraryBtn.Click += libraryBtn_Click;
            // 
            // button3
            // 
            button3.Location = new Point(10, 11);
            button3.Name = "button3";
            button3.Size = new Size(25, 23);
            button3.TabIndex = 2;
            button3.Text = "<";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(41, 12);
            button4.Name = "button4";
            button4.Size = new Size(23, 23);
            button4.TabIndex = 3;
            button4.Text = ">";
            button4.UseVisualStyleBackColor = true;
            // 
            // library1
            // 
            library1.BackColor = SystemColors.Window;
            library1.Location = new Point(10, 41);
            library1.Name = "library1";
            library1.Size = new Size(778, 397);
            library1.TabIndex = 4;
            // 
            // store1
            // 
            store1.BackColor = SystemColors.Window;
            store1.ForeColor = SystemColors.ControlText;
            store1.Location = new Point(10, 41);
            store1.Name = "store1";
            store1.Size = new Size(778, 397);
            store1.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(688, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(519, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(450, 15);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 8;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(625, 15);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 9;
            label2.Text = "Password:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(store1);
            Controls.Add(library1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(libraryBtn);
            Controls.Add(storeBtn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button storeBtn;
        private Button libraryBtn;
        private Button button3;
        private Button button4;
        private DatabaseApp.pages.Library library1;
        private DatabaseApp.pages.Store store1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
    }
}