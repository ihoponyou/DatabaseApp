namespace DatabaseApp
{
    partial class ReviewForm
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
            postReviewBtn = new Button();
            cancelBtn = new Button();
            leaveLabel = new Label();
            titleLbl = new Label();
            reviewRichTextBox = new RichTextBox();
            likeCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // postReviewBtn
            // 
            postReviewBtn.Location = new Point(535, 390);
            postReviewBtn.Name = "postReviewBtn";
            postReviewBtn.Size = new Size(94, 29);
            postReviewBtn.TabIndex = 0;
            postReviewBtn.Text = "Post";
            postReviewBtn.UseVisualStyleBackColor = true;
            postReviewBtn.Click += postReviewBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(635, 390);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 29);
            cancelBtn.TabIndex = 1;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // leaveLabel
            // 
            leaveLabel.AutoSize = true;
            leaveLabel.Location = new Point(44, 35);
            leaveLabel.Name = "leaveLabel";
            leaveLabel.Size = new Size(150, 20);
            leaveLabel.TabIndex = 2;
            leaveLabel.Text = "Leave your review for";
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            titleLbl.Location = new Point(44, 85);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(72, 28);
            titleLbl.TabIndex = 3;
            titleLbl.Text = "          ";
            // 
            // reviewRichTextBox
            // 
            reviewRichTextBox.Location = new Point(44, 153);
            reviewRichTextBox.Name = "reviewRichTextBox";
            reviewRichTextBox.Size = new Size(685, 203);
            reviewRichTextBox.TabIndex = 4;
            reviewRichTextBox.Text = "";
            // 
            // likeCheckBox
            // 
            likeCheckBox.AutoSize = true;
            likeCheckBox.Location = new Point(532, 60);
            likeCheckBox.Name = "likeCheckBox";
            likeCheckBox.Size = new Size(135, 24);
            likeCheckBox.TabIndex = 5;
            likeCheckBox.Text = "I like this game!";
            likeCheckBox.UseVisualStyleBackColor = true;
            // 
            // ReviewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(likeCheckBox);
            Controls.Add(reviewRichTextBox);
            Controls.Add(titleLbl);
            Controls.Add(leaveLabel);
            Controls.Add(cancelBtn);
            Controls.Add(postReviewBtn);
            Name = "ReviewForm";
            Text = "Form1";
            Load += ReviewForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button postReviewBtn;
        private Button cancelBtn;
        private Label leaveLabel;
        private Label titleLbl;
        private RichTextBox reviewRichTextBox;
        private CheckBox likeCheckBox;
    }
}