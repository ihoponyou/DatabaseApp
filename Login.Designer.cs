namespace DatabaseApp
{
    partial class Login
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
            label1 = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            label2 = new Label();
            cancelButton = new Button();
            loginButton = new Button();
            errorLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(19, 15);
            label1.Name = "label1";
            label1.Size = new Size(56, 14);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTextBox.Location = new Point(80, 12);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(273, 20);
            usernameTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(80, 41);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(273, 20);
            passwordTextBox.TabIndex = 3;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(19, 44);
            label2.Name = "label2";
            label2.Size = new Size(57, 14);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // cancelButton
            // 
            cancelButton.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cancelButton.Location = new Point(235, 87);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(118, 23);
            cancelButton.TabIndex = 5;
            cancelButton.Text = "CANCEL";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += button2_Click;
            // 
            // loginButton
            // 
            loginButton.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            loginButton.Location = new Point(111, 87);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(118, 23);
            loginButton.TabIndex = 6;
            loginButton.Text = "LOGIN";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(80, 67);
            errorLabel.Margin = new Padding(3);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(42, 14);
            errorLabel.TabIndex = 7;
            errorLabel.Text = "ERROR";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 119);
            Controls.Add(errorLabel);
            Controls.Add(loginButton);
            Controls.Add(cancelButton);
            Controls.Add(passwordTextBox);
            Controls.Add(label2);
            Controls.Add(usernameTextBox);
            Controls.Add(label1);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Label label2;
        private Button cancelButton;
        private Button loginButton;
        private Label errorLabel;
    }
}