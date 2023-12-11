namespace DatabaseApp.pages
{
    partial class Store
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
            titleSearchTextBox = new TextBox();
            tagComboBox = new ComboBox();
            label1 = new Label();
            priceTrackBar = new TrackBar();
            priceLabel = new Label();
            storeListLayout = new FlowLayoutPanel();
            reviewListLayout = new FlowLayoutPanel();
            label2 = new Label();
            reviewOrderButton = new Button();
            label3 = new Label();
            label4 = new Label();
            priceOrderButton = new Button();
            ((System.ComponentModel.ISupportInitialize)priceTrackBar).BeginInit();
            SuspendLayout();
            // 
            // titleSearchTextBox
            // 
            titleSearchTextBox.Location = new Point(410, 16);
            titleSearchTextBox.Margin = new Padding(3, 3, 3, 9);
            titleSearchTextBox.Name = "titleSearchTextBox";
            titleSearchTextBox.PlaceholderText = "Search by title...";
            titleSearchTextBox.Size = new Size(173, 23);
            titleSearchTextBox.TabIndex = 1;
            // 
            // tagComboBox
            // 
            tagComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            tagComboBox.FormattingEnabled = true;
            tagComboBox.Location = new Point(444, 51);
            tagComboBox.Margin = new Padding(3, 3, 3, 9);
            tagComboBox.Name = "tagComboBox";
            tagComboBox.Size = new Size(139, 23);
            tagComboBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(410, 54);
            label1.Margin = new Padding(3, 3, 3, 9);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 3;
            label1.Text = "Tag:";
            // 
            // priceTrackBar
            // 
            priceTrackBar.Location = new Point(410, 81);
            priceTrackBar.Margin = new Padding(3, 3, 3, 9);
            priceTrackBar.Maximum = 120;
            priceTrackBar.Name = "priceTrackBar";
            priceTrackBar.Size = new Size(173, 45);
            priceTrackBar.SmallChange = 5;
            priceTrackBar.TabIndex = 4;
            priceTrackBar.TickFrequency = 5;
            priceTrackBar.Scroll += trackBar1_Scroll;
            priceTrackBar.MouseCaptureChanged += priceTrackBar_MouseCaptureChanged;
            // 
            // priceLabel
            // 
            priceLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            priceLabel.Location = new Point(410, 116);
            priceLabel.Margin = new Padding(3, 3, 3, 9);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(173, 20);
            priceLabel.TabIndex = 5;
            priceLabel.Text = "Free";
            priceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // storeListLayout
            // 
            storeListLayout.BackColor = SystemColors.ControlLight;
            storeListLayout.Location = new Point(161, 45);
            storeListLayout.Name = "storeListLayout";
            storeListLayout.Size = new Size(243, 332);
            storeListLayout.TabIndex = 0;
            // 
            // reviewListLayout
            // 
            reviewListLayout.AutoScroll = true;
            reviewListLayout.BackColor = SystemColors.ControlLight;
            reviewListLayout.Location = new Point(410, 171);
            reviewListLayout.Name = "reviewListLayout";
            reviewListLayout.Padding = new Padding(0, 3, 0, 0);
            reviewListLayout.Size = new Size(173, 206);
            reviewListLayout.TabIndex = 1;
            reviewListLayout.WrapContents = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(410, 153);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 6;
            label2.Text = "Reviews";
            // 
            // reviewOrderButton
            // 
            reviewOrderButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            reviewOrderButton.Location = new Point(310, 17);
            reviewOrderButton.Name = "reviewOrderButton";
            reviewOrderButton.Size = new Size(23, 23);
            reviewOrderButton.TabIndex = 7;
            reviewOrderButton.Text = "↑";
            reviewOrderButton.UseVisualStyleBackColor = true;
            reviewOrderButton.Click += reviewOrderButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(252, 21);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 8;
            label3.Text = "Reviews:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(339, 21);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 10;
            label4.Text = "Price:";
            // 
            // priceOrderButton
            // 
            priceOrderButton.Location = new Point(381, 17);
            priceOrderButton.Name = "priceOrderButton";
            priceOrderButton.Size = new Size(23, 23);
            priceOrderButton.TabIndex = 9;
            priceOrderButton.Text = "↑";
            priceOrderButton.UseVisualStyleBackColor = true;
            priceOrderButton.Click += priceOrderButton_Click;
            // 
            // Store
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(label4);
            Controls.Add(priceOrderButton);
            Controls.Add(label3);
            Controls.Add(reviewOrderButton);
            Controls.Add(label2);
            Controls.Add(reviewListLayout);
            Controls.Add(priceLabel);
            Controls.Add(priceTrackBar);
            Controls.Add(label1);
            Controls.Add(tagComboBox);
            Controls.Add(titleSearchTextBox);
            Controls.Add(storeListLayout);
            ForeColor = SystemColors.ControlText;
            Name = "Store";
            Size = new Size(778, 397);
            Load += Store_Load;
            ((System.ComponentModel.ISupportInitialize)priceTrackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox titleSearchTextBox;
        private ComboBox tagComboBox;
        private Label label1;
        private TrackBar priceTrackBar;
        private Label priceLabel;
        private FlowLayoutPanel storeListLayout;
        private FlowLayoutPanel reviewListLayout;
        private Label label2;
        private Button reviewOrderButton;
        private Label label3;
        private Label label4;
        private Button priceOrderButton;
    }
}
