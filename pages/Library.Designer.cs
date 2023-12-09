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
            flowLayoutPanel1 = new FlowLayoutPanel();
            descriptionLabel = new Label();
            label2 = new Label();
            label1 = new Label();
            gameTitleLabel = new Label();
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
            splitContainer1.Panel1.Controls.Add(flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(descriptionLabel);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(gameTitleLabel);
            splitContainer1.Panel2.Padding = new Padding(10);
            splitContainer1.Size = new Size(778, 397);
            splitContainer1.SplitterDistance = 201;
            splitContainer1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.WindowFrame;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(201, 397);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionLabel.Location = new Point(25, 151);
            descriptionLabel.Margin = new Padding(6);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(52, 21);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 127);
            label2.Margin = new Padding(3);
            label2.Name = "label2";
            label2.Size = new Size(162, 15);
            label2.TabIndex = 2;
            label2.Text = "PUBLISHER: [publisher name]";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 106);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Size = new Size(166, 15);
            label1.TabIndex = 1;
            label1.Text = "RELEASE DATE: [mm/dd/yyyy]";
            // 
            // gameTitleLabel
            // 
            gameTitleLabel.AutoSize = true;
            gameTitleLabel.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            gameTitleLabel.Location = new Point(25, 50);
            gameTitleLabel.Margin = new Padding(3);
            gameTitleLabel.Name = "gameTitleLabel";
            gameTitleLabel.Size = new Size(335, 50);
            gameTitleLabel.TabIndex = 0;
            gameTitleLabel.Text = "[GAME TITLE HERE]";
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
        private FlowLayoutPanel flowLayoutPanel1;
        private Label gameTitleLabel;
        private Label label2;
        private Label label1;
        private Label descriptionLabel;
    }
}
