namespace MagcalasCullen_CSCI366_GroupProject
{
    partial class Main
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
            loginButton = new Button();
            logoutButton = new Button();
            SuspendLayout();
            // 
            // storeBtn
            // 
            storeBtn.Location = new Point(70, 11);
            storeBtn.Name = "storeBtn";
            storeBtn.Size = new Size(75, 23);
            storeBtn.TabIndex = 0;
            storeBtn.Text = "Store";
            storeBtn.UseVisualStyleBackColor = true;
            storeBtn.Click += storeBtn_Click;
            // 
            // libraryBtn
            // 
            libraryBtn.Location = new Point(151, 11);
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
            button4.Location = new Point(41, 11);
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
            // loginButton
            // 
            loginButton.Location = new Point(713, 11);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 23);
            loginButton.TabIndex = 10;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginBtn_Click;
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(713, 11);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(75, 23);
            logoutButton.TabIndex = 11;
            logoutButton.Text = "Log out";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logoutButton);
            Controls.Add(loginButton);
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
        }

        #endregion

        private Button storeBtn;
        private Button libraryBtn;
        private Button button3;
        private Button button4;
        private DatabaseApp.pages.Library library1;
        private DatabaseApp.pages.Store store1;
        private Button loginButton;
        private Button logoutButton;
    }
}