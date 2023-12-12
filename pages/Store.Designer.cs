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
            oldestUserButton = new Button();
            newestGameButton = new Button();
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
            // priceTrackBar
            // 
            priceTrackBar.Location = new Point(410, 45);
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
            priceLabel.Location = new Point(410, 77);
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
            reviewList.Location = new Point(410, 136);
            reviewList.Name = "reviewList";
            reviewList.Padding = new Padding(0, 3, 0, 0);
            reviewList.Size = new Size(173, 241);
            reviewList.TabIndex = 1;
            reviewList.WrapContents = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(410, 109);
            label2.Name = "label2";
            label2.Size = new Size(57, 17);
            label2.TabIndex = 6;
            label2.Text = "Reviews";
            // 
            // reviewOrderButton
            // 
            reviewOrderButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            reviewOrderButton.Location = new Point(560, 107);
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
            label3.Location = new Point(496, 111);
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
            // oldestUserButton
            // 
            oldestUserButton.Location = new Point(14, 74);
            oldestUserButton.Name = "oldestUserButton";
            oldestUserButton.Size = new Size(132, 23);
            oldestUserButton.TabIndex = 13;
            oldestUserButton.Text = "Oldest User";
            oldestUserButton.UseVisualStyleBackColor = true;
            oldestUserButton.Click += oldestUserButton_Click;
            // 
            // newestGameButton
            // 
            newestGameButton.Location = new Point(14, 103);
            newestGameButton.Name = "newestGameButton";
            newestGameButton.Size = new Size(132, 23);
            newestGameButton.TabIndex = 14;
            newestGameButton.Text = "Newest Game";
            newestGameButton.UseVisualStyleBackColor = true;
            newestGameButton.Click += newestGameButton_Click;
            // 
            // Store
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(newestGameButton);
            Controls.Add(oldestUserButton);
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
        private Button oldestUserButton;
        private Button newestGameButton;
    }
}
