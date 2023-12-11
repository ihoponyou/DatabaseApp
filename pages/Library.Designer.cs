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
            splitContainer1.Panel2.Controls.Add(tagLabel);
            splitContainer1.Panel2.Controls.Add(descriptionLabel);
            splitContainer1.Panel2.Controls.Add(publisherLabel);
            splitContainer1.Panel2.Controls.Add(releaseDateLabel);
            splitContainer1.Panel2.Controls.Add(titleLabel);
            splitContainer1.Panel2.Padding = new Padding(10);
            splitContainer1.Size = new Size(778, 397);
            splitContainer1.SplitterDistance = 201;
            splitContainer1.TabIndex = 0;
            // 
            // tagCombo
            // 
            tagCombo.DisplayMember = "Name";
            tagCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            tagCombo.FormattingEnabled = true;
            tagCombo.Location = new Point(40, 6);
            tagCombo.Name = "tagCombo";
            tagCombo.Size = new Size(158, 23);
            tagCombo.TabIndex = 2;
            tagCombo.ValueMember = "Name";
            tagCombo.SelectedIndexChanged += tagCombo_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Location = new Point(6, 9);
            label1.Margin = new Padding(6);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Tag:";
            // 
            // gameListLayout
            // 
            gameListLayout.BackColor = SystemColors.ControlLight;
            gameListLayout.FlowDirection = FlowDirection.TopDown;
            gameListLayout.Location = new Point(0, 33);
            gameListLayout.Name = "gameListLayout";
            gameListLayout.Size = new Size(201, 364);
            gameListLayout.TabIndex = 0;
            // 
            // tagLabel
            // 
            tagLabel.Location = new Point(25, 109);
            tagLabel.Margin = new Padding(3);
            tagLabel.Name = "tagLabel";
            tagLabel.Size = new Size(180, 15);
            tagLabel.TabIndex = 4;
            tagLabel.Text = "[tags]";
            // 
            // descriptionLabel
            // 
            descriptionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionLabel.Location = new Point(25, 175);
            descriptionLabel.Margin = new Padding(6);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(513, 206);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "label3";
            // 
            // publisherLabel
            // 
            publisherLabel.Location = new Point(25, 151);
            publisherLabel.Margin = new Padding(3);
            publisherLabel.Name = "publisherLabel";
            publisherLabel.Size = new Size(162, 15);
            publisherLabel.TabIndex = 2;
            publisherLabel.Text = "PUBLISHER: [publisher name]";
            // 
            // releaseDateLabel
            // 
            releaseDateLabel.Location = new Point(25, 130);
            releaseDateLabel.Margin = new Padding(3);
            releaseDateLabel.Name = "releaseDateLabel";
            releaseDateLabel.Size = new Size(166, 15);
            releaseDateLabel.TabIndex = 1;
            releaseDateLabel.Text = "RELEASE DATE: [mm/dd/yyyy]";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            titleLabel.Location = new Point(25, 50);
            titleLabel.Margin = new Padding(6);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(335, 50);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "[GAME TITLE HERE]";
            // 
            // Library
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(splitContainer1);
            Name = "Library";
            Size = new Size(778, 397);
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
    }
}
