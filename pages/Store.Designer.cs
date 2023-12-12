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
            storeList = new FlowLayoutPanel();
            reviewList = new FlowLayoutPanel();
            label2 = new Label();
            reviewOrderButton = new Button();
            label3 = new Label();
            label4 = new Label();
            priceOrderButton = new Button();
            label5 = new Label();
            mostPopularGameButton = new Button();
            button2 = new Button();
            button3 = new Button();
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
            titleSearchTextBox.KeyPress += titleSearchTextBox_KeyPress;
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
            priceTrackBar.Location = new Point(410, 86);
            priceTrackBar.Margin = new Padding(3, 3, 3, 9);
            priceTrackBar.Maximum = 20;
            priceTrackBar.Name = "priceTrackBar";
            priceTrackBar.Size = new Size(173, 45);
            priceTrackBar.SmallChange = 5;
            priceTrackBar.TabIndex = 4;
            priceTrackBar.TickFrequency = 5;
            priceTrackBar.Value = 20;
            priceTrackBar.Scroll += trackBar1_Scroll;
            priceTrackBar.MouseCaptureChanged += priceTrackBar_MouseCaptureChanged;
            // 
            // priceLabel
            // 
            priceLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            priceLabel.Location = new Point(410, 118);
            priceLabel.Margin = new Padding(3, 3, 3, 9);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(173, 20);
            priceLabel.TabIndex = 5;
            priceLabel.Text = "Under $20";
            priceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // storeList
            // 
            storeList.BackColor = SystemColors.ControlLight;
            storeList.Location = new Point(161, 45);
            storeList.Name = "storeList";
            storeList.Size = new Size(243, 332);
            storeList.TabIndex = 0;
            // 
            // reviewList
            // 
            reviewList.AutoScroll = true;
            reviewList.BackColor = SystemColors.ControlLight;
            reviewList.FlowDirection = FlowDirection.TopDown;
            reviewList.Location = new Point(410, 195);
            reviewList.Name = "reviewList";
            reviewList.Padding = new Padding(0, 3, 0, 0);
            reviewList.Size = new Size(173, 182);
            reviewList.TabIndex = 1;
            reviewList.WrapContents = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(410, 168);
            label2.Name = "label2";
            label2.Size = new Size(57, 17);
            label2.TabIndex = 6;
            label2.Text = "Reviews";
            // 
            // reviewOrderButton
            // 
            reviewOrderButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            reviewOrderButton.Location = new Point(560, 166);
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
            label3.Location = new Point(496, 170);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 8;
            label3.Text = "Positivity:";
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(161, 19);
            label5.Name = "label5";
            label5.Size = new Size(49, 17);
            label5.TabIndex = 11;
            label5.Text = "Games";
            // 
            // mostPopularGameButton
            // 
            mostPopularGameButton.Location = new Point(14, 45);
            mostPopularGameButton.Name = "mostPopularGameButton";
            mostPopularGameButton.Size = new Size(132, 23);
            mostPopularGameButton.TabIndex = 12;
            mostPopularGameButton.Text = "Most Discussed Game";
            mostPopularGameButton.UseVisualStyleBackColor = true;
            mostPopularGameButton.Click += mostPopularGameButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(14, 74);
            button2.Name = "button2";
            button2.Size = new Size(132, 23);
            button2.TabIndex = 13;
            button2.Text = "Oldest User";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(14, 103);
            button3.Name = "button3";
            button3.Size = new Size(132, 23);
            button3.TabIndex = 14;
            button3.Text = "Newest Game";
            button3.UseVisualStyleBackColor = true;
            // 
            // Store
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(mostPopularGameButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(priceOrderButton);
            Controls.Add(label3);
            Controls.Add(reviewOrderButton);
            Controls.Add(label2);
            Controls.Add(reviewList);
            Controls.Add(priceLabel);
            Controls.Add(priceTrackBar);
            Controls.Add(label1);
            Controls.Add(tagComboBox);
            Controls.Add(titleSearchTextBox);
            Controls.Add(storeList);
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
        private FlowLayoutPanel storeList;
        private FlowLayoutPanel reviewList;
        private Label label2;
        private Button reviewOrderButton;
        private Label label3;
        private Label label4;
        private Button priceOrderButton;
        private Label label5;
        private Button mostPopularGameButton;
        private Button button2;
        private Button button3;
    }
}
