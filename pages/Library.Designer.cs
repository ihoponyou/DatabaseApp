namespace DatabaseApp.pages
{
    partial class Library
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            tagCombo = new ComboBox();
            label1 = new Label();
            gameListLayout = new FlowLayoutPanel();
            reviewBtn = new Button();
            tagLabel = new Label();
            descriptionLabel = new Label();
            publisherLabel = new Label();
            releaseDateLabel = new Label();
            titleLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tagCombo);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(gameListLayout);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(reviewBtn);
            splitContainer1.Panel2.Controls.Add(tagLabel);
            splitContainer1.Panel2.Controls.Add(descriptionLabel);
            splitContainer1.Panel2.Controls.Add(publisherLabel);
            splitContainer1.Panel2.Controls.Add(releaseDateLabel);
            splitContainer1.Panel2.Controls.Add(titleLabel);
            splitContainer1.Panel2.Padding = new Padding(11, 13, 11, 13);
            splitContainer1.Size = new Size(889, 529);
            splitContainer1.SplitterDistance = 229;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // tagCombo
            // 
            tagCombo.DisplayMember = "Name";
            tagCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            tagCombo.FormattingEnabled = true;
            tagCombo.Location = new Point(46, 8);
            tagCombo.Margin = new Padding(3, 4, 3, 4);
            tagCombo.Name = "tagCombo";
            tagCombo.Size = new Size(180, 28);
            tagCombo.TabIndex = 2;
            tagCombo.ValueMember = "Name";
            tagCombo.SelectedIndexChanged += tagCombo_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Location = new Point(7, 12);
            label1.Margin = new Padding(7, 8, 7, 8);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 1;
            label1.Text = "Tag:";
            // 
            // gameListLayout
            // 
            gameListLayout.BackColor = SystemColors.ControlLight;
            gameListLayout.FlowDirection = FlowDirection.TopDown;
            gameListLayout.Location = new Point(0, 44);
            gameListLayout.Margin = new Padding(3, 4, 3, 4);
            gameListLayout.Name = "gameListLayout";
            gameListLayout.Size = new Size(230, 485);
            gameListLayout.TabIndex = 0;
            // 
            // reviewBtn
            // 
            reviewBtn.Location = new Point(29, 484);
            reviewBtn.Name = "reviewBtn";
            reviewBtn.Size = new Size(94, 29);
            reviewBtn.TabIndex = 5;
            reviewBtn.Text = "Review";
            reviewBtn.UseVisualStyleBackColor = true;
            reviewBtn.Click += reiviewBtn_Click;
            // 
            // tagLabel
            // 
            tagLabel.Location = new Point(29, 145);
            tagLabel.Margin = new Padding(3, 4, 3, 4);
            tagLabel.Name = "tagLabel";
            tagLabel.Size = new Size(206, 20);
            tagLabel.TabIndex = 4;
            tagLabel.Text = "[tags]";
            // 
            // descriptionLabel
            // 
            descriptionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionLabel.Location = new Point(29, 233);
            descriptionLabel.Margin = new Padding(7, 8, 7, 8);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(586, 223);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "label3";
            // 
            // publisherLabel
            // 
            publisherLabel.Location = new Point(29, 201);
            publisherLabel.Margin = new Padding(3, 4, 3, 4);
            publisherLabel.Name = "publisherLabel";
            publisherLabel.Size = new Size(185, 20);
            publisherLabel.TabIndex = 2;
            publisherLabel.Text = "PUBLISHER: [publisher name]";
            // 
            // releaseDateLabel
            // 
            releaseDateLabel.Location = new Point(29, 173);
            releaseDateLabel.Margin = new Padding(3, 4, 3, 4);
            releaseDateLabel.Name = "releaseDateLabel";
            releaseDateLabel.Size = new Size(190, 20);
            releaseDateLabel.TabIndex = 1;
            releaseDateLabel.Text = "RELEASE DATE: [mm/dd/yyyy]";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            titleLabel.Location = new Point(29, 67);
            titleLabel.Margin = new Padding(7, 8, 7, 8);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(427, 62);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "[GAME TITLE HERE]";
            // 
            // Library
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Library";
            Size = new Size(889, 529);
            Load += Library_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private FlowLayoutPanel gameListLayout;
        private Label titleLabel;
        private Label publisherLabel;
        private Label releaseDateLabel;
        private Label descriptionLabel;
        private Label tagLabel;
        private Label label1;
        private ComboBox tagCombo;
        private Button reviewBtn;
    }
}
