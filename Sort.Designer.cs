using System;
using System.Threading;

namespace SortingVisualiser
{
    partial class SortPage
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
            this.SortDataBtn = new System.Windows.Forms.Button();
            this.GameBtn = new System.Windows.Forms.Button();
            this.DataBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.SortPanel = new System.Windows.Forms.Panel();
            this.SortBtn = new System.Windows.Forms.Button();
            this.SelectionSortBtn = new System.Windows.Forms.Button();
            this.QuickSortBtn = new System.Windows.Forms.Button();
            this.RadixSortBtn = new System.Windows.Forms.Button();
            this.BubbleSortBtn = new System.Windows.Forms.Button();
            this.MergeSortBtn = new System.Windows.Forms.Button();
            this.InsertionSortBtn = new System.Windows.Forms.Button();
            this.SortTitle = new System.Windows.Forms.Label();
            this.GraphBox = new System.Windows.Forms.PictureBox();
            this.SizeBar = new System.Windows.Forms.TrackBar();
            this.DelayBar = new System.Windows.Forms.TrackBar();
            this.DelayLbl = new System.Windows.Forms.Label();
            this.SizeLbl = new System.Windows.Forms.Label();
            this.UseData = new System.Windows.Forms.CheckBox();
            ReadsLbl = new System.Windows.Forms.Label();
            WritesLbl = new System.Windows.Forms.Label();
            ComparisonsLbl = new System.Windows.Forms.Label();
            this.InfoBtn = new System.Windows.Forms.Button();
            this.SortPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayBar)).BeginInit();
            this.SuspendLayout();
            // 
            // SortDataBtn
            // 
            this.SortDataBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SortDataBtn.BackColor = System.Drawing.Color.Black;
            this.SortDataBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SortDataBtn.FlatAppearance.BorderSize = 3;
            this.SortDataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortDataBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortDataBtn.ForeColor = System.Drawing.Color.White;
            this.SortDataBtn.Location = new System.Drawing.Point(1119, 625);
            this.SortDataBtn.Name = "SortDataBtn";
            this.SortDataBtn.Size = new System.Drawing.Size(111, 38);
            this.SortDataBtn.TabIndex = 22;
            this.SortDataBtn.Text = "Sort";
            this.SortDataBtn.UseVisualStyleBackColor = false;
            this.SortDataBtn.Click += new System.EventHandler(this.SortDataBtn_Click);
            // 
            // GameBtn
            // 
            this.GameBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GameBtn.BackColor = System.Drawing.Color.Black;
            this.GameBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.GameBtn.FlatAppearance.BorderSize = 3;
            this.GameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.GameBtn.ForeColor = System.Drawing.Color.White;
            this.GameBtn.Location = new System.Drawing.Point(864, 31);
            this.GameBtn.Name = "GameBtn";
            this.GameBtn.Size = new System.Drawing.Size(137, 61);
            this.GameBtn.TabIndex = 2;
            this.GameBtn.Text = "Game";
            this.GameBtn.UseVisualStyleBackColor = false;
            this.GameBtn.Click += new System.EventHandler(this.GameBtn_Click);
            // 
            // DataBtn
            // 
            this.DataBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DataBtn.BackColor = System.Drawing.Color.Black;
            this.DataBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DataBtn.FlatAppearance.BorderSize = 3;
            this.DataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DataBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.DataBtn.ForeColor = System.Drawing.Color.White;
            this.DataBtn.Location = new System.Drawing.Point(256, 31);
            this.DataBtn.Name = "DataBtn";
            this.DataBtn.Size = new System.Drawing.Size(137, 61);
            this.DataBtn.TabIndex = 1;
            this.DataBtn.Text = "Data";
            this.DataBtn.UseVisualStyleBackColor = false;
            this.DataBtn.Click += new System.EventHandler(this.DataBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HomeBtn.BackColor = System.Drawing.Color.Black;
            this.HomeBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.HomeBtn.FlatAppearance.BorderSize = 3;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.HomeBtn.ForeColor = System.Drawing.Color.White;
            this.HomeBtn.Location = new System.Drawing.Point(51, 31);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(137, 61);
            this.HomeBtn.TabIndex = 0;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // SortPanel
            // 
            this.SortPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SortPanel.BackColor = System.Drawing.Color.Transparent;
            this.SortPanel.Controls.Add(this.SortBtn);
            this.SortPanel.Controls.Add(this.SelectionSortBtn);
            this.SortPanel.Controls.Add(this.QuickSortBtn);
            this.SortPanel.Controls.Add(this.RadixSortBtn);
            this.SortPanel.Controls.Add(this.BubbleSortBtn);
            this.SortPanel.Controls.Add(this.MergeSortBtn);
            this.SortPanel.Controls.Add(this.InsertionSortBtn);
            this.SortPanel.Location = new System.Drawing.Point(1066, 31);
            this.SortPanel.MaximumSize = new System.Drawing.Size(137, 277);
            this.SortPanel.MinimumSize = new System.Drawing.Size(137, 61);
            this.SortPanel.Name = "SortPanel";
            this.SortPanel.Size = new System.Drawing.Size(137, 61);
            this.SortPanel.TabIndex = 19;
            // 
            // SortBtn
            // 
            this.SortBtn.BackColor = System.Drawing.Color.DimGray;
            this.SortBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SortBtn.FlatAppearance.BorderSize = 3;
            this.SortBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.SortBtn.ForeColor = System.Drawing.Color.White;
            this.SortBtn.Location = new System.Drawing.Point(0, 0);
            this.SortBtn.Name = "SortBtn";
            this.SortBtn.Size = new System.Drawing.Size(137, 61);
            this.SortBtn.TabIndex = 3;
            this.SortBtn.Text = "Sorts";
            this.SortBtn.UseVisualStyleBackColor = false;
            this.SortBtn.Click += new System.EventHandler(this.SortBtn_Click);
            // 
            // SelectionSortBtn
            // 
            this.SelectionSortBtn.BackColor = System.Drawing.Color.Black;
            this.SelectionSortBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SelectionSortBtn.FlatAppearance.BorderSize = 3;
            this.SelectionSortBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectionSortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SelectionSortBtn.ForeColor = System.Drawing.Color.White;
            this.SelectionSortBtn.Location = new System.Drawing.Point(0, 239);
            this.SelectionSortBtn.Name = "SelectionSortBtn";
            this.SelectionSortBtn.Size = new System.Drawing.Size(137, 38);
            this.SelectionSortBtn.TabIndex = 9;
            this.SelectionSortBtn.Text = "Selection Sort";
            this.SelectionSortBtn.UseVisualStyleBackColor = false;
            this.SelectionSortBtn.Click += new System.EventHandler(this.SelectionSortBtn_Click);
            // 
            // QuickSortBtn
            // 
            this.QuickSortBtn.BackColor = System.Drawing.Color.Black;
            this.QuickSortBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.QuickSortBtn.FlatAppearance.BorderSize = 3;
            this.QuickSortBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuickSortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.QuickSortBtn.ForeColor = System.Drawing.Color.White;
            this.QuickSortBtn.Location = new System.Drawing.Point(0, 131);
            this.QuickSortBtn.Name = "QuickSortBtn";
            this.QuickSortBtn.Size = new System.Drawing.Size(137, 38);
            this.QuickSortBtn.TabIndex = 6;
            this.QuickSortBtn.Text = "Quick Sort";
            this.QuickSortBtn.UseVisualStyleBackColor = false;
            this.QuickSortBtn.Click += new System.EventHandler(this.QuickSortBtn_Click);
            // 
            // RadixSortBtn
            // 
            this.RadixSortBtn.BackColor = System.Drawing.Color.Black;
            this.RadixSortBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RadixSortBtn.FlatAppearance.BorderSize = 3;
            this.RadixSortBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RadixSortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RadixSortBtn.ForeColor = System.Drawing.Color.White;
            this.RadixSortBtn.Location = new System.Drawing.Point(0, 167);
            this.RadixSortBtn.Name = "RadixSortBtn";
            this.RadixSortBtn.Size = new System.Drawing.Size(137, 38);
            this.RadixSortBtn.TabIndex = 7;
            this.RadixSortBtn.Text = "Radix Sort";
            this.RadixSortBtn.UseVisualStyleBackColor = false;
            this.RadixSortBtn.Click += new System.EventHandler(this.RadixSortBtn_Click);
            // 
            // BubbleSortBtn
            // 
            this.BubbleSortBtn.BackColor = System.Drawing.Color.Black;
            this.BubbleSortBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BubbleSortBtn.FlatAppearance.BorderSize = 3;
            this.BubbleSortBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BubbleSortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BubbleSortBtn.ForeColor = System.Drawing.Color.White;
            this.BubbleSortBtn.Location = new System.Drawing.Point(0, 59);
            this.BubbleSortBtn.Name = "BubbleSortBtn";
            this.BubbleSortBtn.Size = new System.Drawing.Size(137, 38);
            this.BubbleSortBtn.TabIndex = 4;
            this.BubbleSortBtn.Text = "Bubble Sort";
            this.BubbleSortBtn.UseVisualStyleBackColor = false;
            this.BubbleSortBtn.Click += new System.EventHandler(this.BubbleSortBtn_Click);
            // 
            // MergeSortBtn
            // 
            this.MergeSortBtn.BackColor = System.Drawing.Color.Black;
            this.MergeSortBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.MergeSortBtn.FlatAppearance.BorderSize = 3;
            this.MergeSortBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MergeSortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MergeSortBtn.ForeColor = System.Drawing.Color.White;
            this.MergeSortBtn.Location = new System.Drawing.Point(0, 95);
            this.MergeSortBtn.Name = "MergeSortBtn";
            this.MergeSortBtn.Size = new System.Drawing.Size(137, 38);
            this.MergeSortBtn.TabIndex = 5;
            this.MergeSortBtn.Text = "Merge Sort";
            this.MergeSortBtn.UseVisualStyleBackColor = false;
            this.MergeSortBtn.Click += new System.EventHandler(this.MergeSortBtn_Click);
            // 
            // InsertionSortBtn
            // 
            this.InsertionSortBtn.BackColor = System.Drawing.Color.Black;
            this.InsertionSortBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.InsertionSortBtn.FlatAppearance.BorderSize = 3;
            this.InsertionSortBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertionSortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.InsertionSortBtn.ForeColor = System.Drawing.Color.White;
            this.InsertionSortBtn.Location = new System.Drawing.Point(0, 203);
            this.InsertionSortBtn.Name = "InsertionSortBtn";
            this.InsertionSortBtn.Size = new System.Drawing.Size(137, 38);
            this.InsertionSortBtn.TabIndex = 8;
            this.InsertionSortBtn.Text = "Insertion Sort";
            this.InsertionSortBtn.UseVisualStyleBackColor = false;
            this.InsertionSortBtn.Click += new System.EventHandler(this.InsertionSortBtn_Click);
            // 
            // SortTitle
            // 
            this.SortTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SortTitle.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortTitle.ForeColor = System.Drawing.Color.White;
            this.SortTitle.Location = new System.Drawing.Point(423, 31);
            this.SortTitle.Name = "SortTitle";
            this.SortTitle.Size = new System.Drawing.Size(410, 61);
            this.SortTitle.TabIndex = 20;
            this.SortTitle.Text = "Title";
            this.SortTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GraphBox
            // 
            this.GraphBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GraphBox.BackColor = System.Drawing.Color.Transparent;
            this.GraphBox.Location = new System.Drawing.Point(30, 116);
            this.GraphBox.Name = "GraphBox";
            this.GraphBox.Size = new System.Drawing.Size(1200, 500);
            this.GraphBox.TabIndex = 21;
            this.GraphBox.TabStop = false;
            this.GraphBox.Paint += new System.Windows.Forms.PaintEventHandler(this.GraphBox_Paint);
            // 
            // SizeBar
            // 
            this.SizeBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SizeBar.Location = new System.Drawing.Point(267, 630);
            this.SizeBar.Maximum = 500;
            this.SizeBar.Minimum = 5;
            this.SizeBar.Name = "SizeBar";
            this.SizeBar.Size = new System.Drawing.Size(272, 45);
            this.SizeBar.TabIndex = 23;
            this.SizeBar.TickFrequency = 20;
            this.SizeBar.Value = 50;
            this.SizeBar.Scroll += new System.EventHandler(this.SizeBar_Scroll);
            this.SizeBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SizeBar_MouseUp);
            // 
            // DelayBar
            // 
            this.DelayBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DelayBar.LargeChange = 50;
            this.DelayBar.Location = new System.Drawing.Point(730, 630);
            this.DelayBar.Maximum = 200;
            this.DelayBar.Name = "DelayBar";
            this.DelayBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DelayBar.Size = new System.Drawing.Size(272, 45);
            this.DelayBar.SmallChange = 10;
            this.DelayBar.TabIndex = 24;
            this.DelayBar.TickFrequency = 10;
            this.DelayBar.Value = 30;
            this.DelayBar.Scroll += new System.EventHandler(this.DelayBar_Scroll);
            // 
            // DelayLbl
            // 
            this.DelayLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DelayLbl.AutoSize = true;
            this.DelayLbl.ForeColor = System.Drawing.Color.White;
            this.DelayLbl.Location = new System.Drawing.Point(859, 619);
            this.DelayLbl.Name = "DelayLbl";
            this.DelayLbl.Size = new System.Drawing.Size(52, 13);
            this.DelayLbl.TabIndex = 26;
            this.DelayLbl.Text = "Delay: 30";
            // 
            // SizeLbl
            // 
            this.SizeLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SizeLbl.AutoSize = true;
            this.SizeLbl.ForeColor = System.Drawing.Color.White;
            this.SizeLbl.Location = new System.Drawing.Point(395, 619);
            this.SizeLbl.Name = "SizeLbl";
            this.SizeLbl.Size = new System.Drawing.Size(27, 13);
            this.SizeLbl.TabIndex = 27;
            this.SizeLbl.Text = "Size";
            // 
            // UseData
            // 
            this.UseData.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UseData.AutoSize = true;
            this.UseData.ForeColor = System.Drawing.Color.White;
            this.UseData.Location = new System.Drawing.Point(119, 640);
            this.UseData.Name = "UseData";
            this.UseData.Size = new System.Drawing.Size(109, 17);
            this.UseData.TabIndex = 28;
            this.UseData.Text = "Use Custom Data";
            this.UseData.UseVisualStyleBackColor = true;
            this.UseData.Click += new System.EventHandler(this.UseData_Click);
            // 
            // ReadsLbl
            // 
            ReadsLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            ReadsLbl.AutoSize = true;
            ReadsLbl.ForeColor = System.Drawing.Color.White;
            ReadsLbl.Location = new System.Drawing.Point(48, 100);
            ReadsLbl.Name = "ReadsLbl";
            ReadsLbl.Size = new System.Drawing.Size(56, 13);
            ReadsLbl.TabIndex = 29;
            ReadsLbl.Text = "Reads = 0";
            // 
            // WritesLbl
            // 
            WritesLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            WritesLbl.AutoSize = true;
            WritesLbl.ForeColor = System.Drawing.Color.White;
            WritesLbl.Location = new System.Drawing.Point(187, 100);
            WritesLbl.Name = "WritesLbl";
            WritesLbl.Size = new System.Drawing.Size(55, 13);
            WritesLbl.TabIndex = 30;
            WritesLbl.Text = "Writes = 0";
            // 
            // ComparisonsLbl
            // 
            ComparisonsLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            ComparisonsLbl.AutoSize = true;
            ComparisonsLbl.ForeColor = System.Drawing.Color.White;
            ComparisonsLbl.Location = new System.Drawing.Point(311, 100);
            ComparisonsLbl.Name = "ComparisonsLbl";
            ComparisonsLbl.Size = new System.Drawing.Size(82, 13);
            ComparisonsLbl.TabIndex = 31;
            ComparisonsLbl.Text = "Comparisons= 0";
            // 
            // InfoBtn
            // 
            this.InfoBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.InfoBtn.BackColor = System.Drawing.Color.Black;
            this.InfoBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.InfoBtn.FlatAppearance.BorderSize = 3;
            this.InfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.InfoBtn.ForeColor = System.Drawing.Color.White;
            this.InfoBtn.Location = new System.Drawing.Point(30, 627);
            this.InfoBtn.Name = "InfoBtn";
            this.InfoBtn.Size = new System.Drawing.Size(25, 30);
            this.InfoBtn.TabIndex = 32;
            this.InfoBtn.Text = "i";
            this.InfoBtn.UseVisualStyleBackColor = false;
            this.InfoBtn.Click += new System.EventHandler(this.InfoBtn_Click);
            // 
            // SortPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.InfoBtn);
            this.Controls.Add(ComparisonsLbl);
            this.Controls.Add(WritesLbl);
            this.Controls.Add(ReadsLbl);
            this.Controls.Add(this.UseData);
            this.Controls.Add(this.SizeLbl);
            this.Controls.Add(this.DelayLbl);
            this.Controls.Add(this.DelayBar);
            this.Controls.Add(this.SizeBar);
            this.Controls.Add(this.SortDataBtn);
            this.Controls.Add(this.SortTitle);
            this.Controls.Add(this.SortPanel);
            this.Controls.Add(this.GameBtn);
            this.Controls.Add(this.DataBtn);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.GraphBox);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "SortPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SortingVisualiser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SortPage_FormClosing);
            this.SortPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GraphBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button GameBtn;
        private System.Windows.Forms.Button DataBtn;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Panel SortPanel;
        private System.Windows.Forms.Button SortBtn;
        private System.Windows.Forms.Button SelectionSortBtn;
        private System.Windows.Forms.Button QuickSortBtn;
        private System.Windows.Forms.Button RadixSortBtn;
        private System.Windows.Forms.Button BubbleSortBtn;
        private System.Windows.Forms.Button MergeSortBtn;
        private System.Windows.Forms.Button InsertionSortBtn;
        private System.Windows.Forms.Label SortTitle;
        private System.Windows.Forms.Button SortDataBtn;
        private System.Windows.Forms.TrackBar SizeBar;
        private System.Windows.Forms.TrackBar DelayBar;
        private System.Windows.Forms.Label DelayLbl;
        private System.Windows.Forms.Label SizeLbl;
        private System.Windows.Forms.CheckBox UseData;
        public System.Windows.Forms.PictureBox GraphBox;
        private System.Windows.Forms.Button InfoBtn;
        public static System.Windows.Forms.Label ReadsLbl;
        public static System.Windows.Forms.Label WritesLbl;
        public static System.Windows.Forms.Label ComparisonsLbl;
    }

    /*        partial class SortPage
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
            this.SortDataBtn = new System.Windows.Forms.Button();
            this.GameBtn = new System.Windows.Forms.Button();
            this.DataBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.SortPanel = new System.Windows.Forms.Panel();
            this.SortBtn = new System.Windows.Forms.Button();
            this.SelectionSortBtn = new System.Windows.Forms.Button();
            this.QuickSortBtn = new System.Windows.Forms.Button();
            this.RadixSortBtn = new System.Windows.Forms.Button();
            this.BubbleSortBtn = new System.Windows.Forms.Button();
            this.MergeSortBtn = new System.Windows.Forms.Button();
            this.InsertionSortBtn = new System.Windows.Forms.Button();
            this.SortTitle = new System.Windows.Forms.Label();
            this.GraphBox = new System.Windows.Forms.PictureBox();
            this.SizeBar = new System.Windows.Forms.TrackBar();
            this.DelayBar = new System.Windows.Forms.TrackBar();
            this.DelayLbl = new System.Windows.Forms.Label();
            this.SizeLbl = new System.Windows.Forms.Label();
            this.UseData = new System.Windows.Forms.CheckBox();
            ReadsLbl = new System.Windows.Forms.Label();
            WritesLbl = new System.Windows.Forms.Label();
            ComparisonsLbl = new System.Windows.Forms.Label();
            this.InfoBtn = new System.Windows.Forms.Button();
            this.SortPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayBar)).BeginInit();
            this.SuspendLayout();
            // 
            // SortDataBtn
            // 
            this.SortDataBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SortDataBtn.BackColor = System.Drawing.Color.Black;
            this.SortDataBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SortDataBtn.FlatAppearance.BorderSize = 3;
            this.SortDataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortDataBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortDataBtn.ForeColor = System.Drawing.Color.White;
            this.SortDataBtn.Location = new System.Drawing.Point(1119, 625);
            this.SortDataBtn.Name = "SortDataBtn";
            this.SortDataBtn.Size = new System.Drawing.Size(111, 38);
            this.SortDataBtn.TabIndex = 22;
            this.SortDataBtn.Text = "Sort";
            this.SortDataBtn.UseVisualStyleBackColor = false;
            this.SortDataBtn.Click += new System.EventHandler(this.SortDataBtn_Click);
            // 
            // GameBtn
            // 
            this.GameBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GameBtn.BackColor = System.Drawing.Color.Black;
            this.GameBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.GameBtn.FlatAppearance.BorderSize = 3;
            this.GameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.GameBtn.ForeColor = System.Drawing.Color.White;
            this.GameBtn.Location = new System.Drawing.Point(864, 31);
            this.GameBtn.Name = "GameBtn";
            this.GameBtn.Size = new System.Drawing.Size(137, 61);
            this.GameBtn.TabIndex = 2;
            this.GameBtn.Text = "Game";
            this.GameBtn.UseVisualStyleBackColor = false;
            this.GameBtn.Click += new System.EventHandler(this.GameBtn_Click);
            // 
            // DataBtn
            // 
            this.DataBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DataBtn.BackColor = System.Drawing.Color.Black;
            this.DataBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DataBtn.FlatAppearance.BorderSize = 3;
            this.DataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DataBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.DataBtn.ForeColor = System.Drawing.Color.White;
            this.DataBtn.Location = new System.Drawing.Point(256, 31);
            this.DataBtn.Name = "DataBtn";
            this.DataBtn.Size = new System.Drawing.Size(137, 61);
            this.DataBtn.TabIndex = 1;
            this.DataBtn.Text = "Data";
            this.DataBtn.UseVisualStyleBackColor = false;
            this.DataBtn.Click += new System.EventHandler(this.DataBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HomeBtn.BackColor = System.Drawing.Color.Black;
            this.HomeBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.HomeBtn.FlatAppearance.BorderSize = 3;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.HomeBtn.ForeColor = System.Drawing.Color.White;
            this.HomeBtn.Location = new System.Drawing.Point(51, 31);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(137, 61);
            this.HomeBtn.TabIndex = 0;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // SortPanel
            // 
            this.SortPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SortPanel.BackColor = System.Drawing.Color.Transparent;
            this.SortPanel.Controls.Add(this.SortBtn);
            this.SortPanel.Controls.Add(this.SelectionSortBtn);
            this.SortPanel.Controls.Add(this.QuickSortBtn);
            this.SortPanel.Controls.Add(this.RadixSortBtn);
            this.SortPanel.Controls.Add(this.BubbleSortBtn);
            this.SortPanel.Controls.Add(this.MergeSortBtn);
            this.SortPanel.Controls.Add(this.InsertionSortBtn);
            this.SortPanel.Location = new System.Drawing.Point(1066, 31);
            this.SortPanel.MaximumSize = new System.Drawing.Size(137, 277);
            this.SortPanel.MinimumSize = new System.Drawing.Size(137, 61);
            this.SortPanel.Name = "SortPanel";
            this.SortPanel.Size = new System.Drawing.Size(137, 61);
            this.SortPanel.TabIndex = 19;
            // 
            // SortBtn
            // 
            this.SortBtn.BackColor = System.Drawing.Color.DimGray;
            this.SortBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SortBtn.FlatAppearance.BorderSize = 3;
            this.SortBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.SortBtn.ForeColor = System.Drawing.Color.White;
            this.SortBtn.Location = new System.Drawing.Point(0, 0);
            this.SortBtn.Name = "SortBtn";
            this.SortBtn.Size = new System.Drawing.Size(137, 61);
            this.SortBtn.TabIndex = 3;
            this.SortBtn.Text = "Sorts";
            this.SortBtn.UseVisualStyleBackColor = false;
            this.SortBtn.Click += new System.EventHandler(this.SortBtn_Click);
            // 
            // SelectionSortBtn
            // 
            this.SelectionSortBtn.BackColor = System.Drawing.Color.Black;
            this.SelectionSortBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SelectionSortBtn.FlatAppearance.BorderSize = 3;
            this.SelectionSortBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectionSortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SelectionSortBtn.ForeColor = System.Drawing.Color.White;
            this.SelectionSortBtn.Location = new System.Drawing.Point(0, 239);
            this.SelectionSortBtn.Name = "SelectionSortBtn";
            this.SelectionSortBtn.Size = new System.Drawing.Size(137, 38);
            this.SelectionSortBtn.TabIndex = 9;
            this.SelectionSortBtn.Text = "Selection Sort";
            this.SelectionSortBtn.UseVisualStyleBackColor = false;
            this.SelectionSortBtn.Click += new System.EventHandler(this.SelectionSortBtn_Click);
            // 
            // QuickSortBtn
            // 
            this.QuickSortBtn.BackColor = System.Drawing.Color.Black;
            this.QuickSortBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.QuickSortBtn.FlatAppearance.BorderSize = 3;
            this.QuickSortBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuickSortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.QuickSortBtn.ForeColor = System.Drawing.Color.White;
            this.QuickSortBtn.Location = new System.Drawing.Point(0, 131);
            this.QuickSortBtn.Name = "QuickSortBtn";
            this.QuickSortBtn.Size = new System.Drawing.Size(137, 38);
            this.QuickSortBtn.TabIndex = 6;
            this.QuickSortBtn.Text = "Quick Sort";
            this.QuickSortBtn.UseVisualStyleBackColor = false;
            this.QuickSortBtn.Click += new System.EventHandler(this.QuickSortBtn_Click);
            // 
            // RadixSortBtn
            // 
            this.RadixSortBtn.BackColor = System.Drawing.Color.Black;
            this.RadixSortBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RadixSortBtn.FlatAppearance.BorderSize = 3;
            this.RadixSortBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RadixSortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RadixSortBtn.ForeColor = System.Drawing.Color.White;
            this.RadixSortBtn.Location = new System.Drawing.Point(0, 167);
            this.RadixSortBtn.Name = "RadixSortBtn";
            this.RadixSortBtn.Size = new System.Drawing.Size(137, 38);
            this.RadixSortBtn.TabIndex = 7;
            this.RadixSortBtn.Text = "Radix Sort";
            this.RadixSortBtn.UseVisualStyleBackColor = false;
            this.RadixSortBtn.Click += new System.EventHandler(this.RadixSortBtn_Click);
            // 
            // BubbleSortBtn
            // 
            this.BubbleSortBtn.BackColor = System.Drawing.Color.Black;
            this.BubbleSortBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BubbleSortBtn.FlatAppearance.BorderSize = 3;
            this.BubbleSortBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BubbleSortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BubbleSortBtn.ForeColor = System.Drawing.Color.White;
            this.BubbleSortBtn.Location = new System.Drawing.Point(0, 59);
            this.BubbleSortBtn.Name = "BubbleSortBtn";
            this.BubbleSortBtn.Size = new System.Drawing.Size(137, 38);
            this.BubbleSortBtn.TabIndex = 4;
            this.BubbleSortBtn.Text = "Bubble Sort";
            this.BubbleSortBtn.UseVisualStyleBackColor = false;
            this.BubbleSortBtn.Click += new System.EventHandler(this.BubbleSortBtn_Click);
            // 
            // MergeSortBtn
            // 
            this.MergeSortBtn.BackColor = System.Drawing.Color.Black;
            this.MergeSortBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.MergeSortBtn.FlatAppearance.BorderSize = 3;
            this.MergeSortBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MergeSortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MergeSortBtn.ForeColor = System.Drawing.Color.White;
            this.MergeSortBtn.Location = new System.Drawing.Point(0, 95);
            this.MergeSortBtn.Name = "MergeSortBtn";
            this.MergeSortBtn.Size = new System.Drawing.Size(137, 38);
            this.MergeSortBtn.TabIndex = 5;
            this.MergeSortBtn.Text = "Merge Sort";
            this.MergeSortBtn.UseVisualStyleBackColor = false;
            this.MergeSortBtn.Click += new System.EventHandler(this.MergeSortBtn_Click);
            // 
            // InsertionSortBtn
            // 
            this.InsertionSortBtn.BackColor = System.Drawing.Color.Black;
            this.InsertionSortBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.InsertionSortBtn.FlatAppearance.BorderSize = 3;
            this.InsertionSortBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertionSortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.InsertionSortBtn.ForeColor = System.Drawing.Color.White;
            this.InsertionSortBtn.Location = new System.Drawing.Point(0, 203);
            this.InsertionSortBtn.Name = "InsertionSortBtn";
            this.InsertionSortBtn.Size = new System.Drawing.Size(137, 38);
            this.InsertionSortBtn.TabIndex = 8;
            this.InsertionSortBtn.Text = "Insertion Sort";
            this.InsertionSortBtn.UseVisualStyleBackColor = false;
            this.InsertionSortBtn.Click += new System.EventHandler(this.InsertionSortBtn_Click);
            // 
            // SortTitle
            // 
            this.SortTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SortTitle.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortTitle.ForeColor = System.Drawing.Color.White;
            this.SortTitle.Location = new System.Drawing.Point(423, 31);
            this.SortTitle.Name = "SortTitle";
            this.SortTitle.Size = new System.Drawing.Size(410, 61);
            this.SortTitle.TabIndex = 20;
            this.SortTitle.Text = "Title";
            this.SortTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GraphBox
            // 
            this.GraphBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GraphBox.BackColor = System.Drawing.Color.Transparent;
            this.GraphBox.Location = new System.Drawing.Point(30, 116);
            this.GraphBox.Name = "GraphBox";
            this.GraphBox.Size = new System.Drawing.Size(1200, 500);
            this.GraphBox.TabIndex = 21;
            this.GraphBox.TabStop = false;
            this.GraphBox.Paint += new System.Windows.Forms.PaintEventHandler(this.GraphBox_Paint);
            // 
            // SizeBar
            // 
            this.SizeBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SizeBar.Location = new System.Drawing.Point(267, 630);
            this.SizeBar.Maximum = 500;
            this.SizeBar.Minimum = 5;
            this.SizeBar.Name = "SizeBar";
            this.SizeBar.Size = new System.Drawing.Size(272, 45);
            this.SizeBar.TabIndex = 23;
            this.SizeBar.TickFrequency = 20;
            this.SizeBar.Value = 50;
            this.SizeBar.Scroll += new System.EventHandler(this.SizeBar_Scroll);
            this.SizeBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SizeBar_MouseUp);
            // 
            // DelayBar
            // 
            this.DelayBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DelayBar.LargeChange = 50;
            this.DelayBar.Location = new System.Drawing.Point(730, 630);
            this.DelayBar.Maximum = 200;
            this.DelayBar.Name = "DelayBar";
            this.DelayBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DelayBar.Size = new System.Drawing.Size(272, 45);
            this.DelayBar.SmallChange = 10;
            this.DelayBar.TabIndex = 24;
            this.DelayBar.TickFrequency = 10;
            this.DelayBar.Value = 30;
            this.DelayBar.Scroll += new System.EventHandler(this.DelayBar_Scroll);
            // 
            // DelayLbl
            // 
            this.DelayLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DelayLbl.AutoSize = true;
            this.DelayLbl.ForeColor = System.Drawing.Color.White;
            this.DelayLbl.Location = new System.Drawing.Point(859, 619);
            this.DelayLbl.Name = "DelayLbl";
            this.DelayLbl.Size = new System.Drawing.Size(52, 13);
            this.DelayLbl.TabIndex = 26;
            this.DelayLbl.Text = "Delay: 30";
            // 
            // SizeLbl
            // 
            this.SizeLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SizeLbl.AutoSize = true;
            this.SizeLbl.ForeColor = System.Drawing.Color.White;
            this.SizeLbl.Location = new System.Drawing.Point(395, 619);
            this.SizeLbl.Name = "SizeLbl";
            this.SizeLbl.Size = new System.Drawing.Size(27, 13);
            this.SizeLbl.TabIndex = 27;
            this.SizeLbl.Text = "Size";
            // 
            // UseData
            // 
            this.UseData.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UseData.AutoSize = true;
            this.UseData.ForeColor = System.Drawing.Color.White;
            this.UseData.Location = new System.Drawing.Point(119, 640);
            this.UseData.Name = "UseData";
            this.UseData.Size = new System.Drawing.Size(109, 17);
            this.UseData.TabIndex = 28;
            this.UseData.Text = "Use Custom Data";
            this.UseData.UseVisualStyleBackColor = true;
            this.UseData.Click += new System.EventHandler(this.UseData_Click);
            // 
            // ReadsLbl
            // 
            ReadsLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            ReadsLbl.AutoSize = true;
            ReadsLbl.ForeColor = System.Drawing.Color.White;
            ReadsLbl.Location = new System.Drawing.Point(48, 100);
            ReadsLbl.Name = "ReadsLbl";
            ReadsLbl.Size = new System.Drawing.Size(56, 13);
            ReadsLbl.TabIndex = 29;
            ReadsLbl.Text = "Reads = 0";
            // 
            // WritesLbl
            // 
            WritesLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            WritesLbl.AutoSize = true;
            WritesLbl.ForeColor = System.Drawing.Color.White;
            WritesLbl.Location = new System.Drawing.Point(187, 100);
            WritesLbl.Name = "WritesLbl";
            WritesLbl.Size = new System.Drawing.Size(55, 13);
            WritesLbl.TabIndex = 30;
            WritesLbl.Text = "Writes = 0";
            // 
            // ComparisonsLbl
            // 
            ComparisonsLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            ComparisonsLbl.AutoSize = true;
            ComparisonsLbl.ForeColor = System.Drawing.Color.White;
            ComparisonsLbl.Location = new System.Drawing.Point(311, 100);
            ComparisonsLbl.Name = "ComparisonsLbl";
            ComparisonsLbl.Size = new System.Drawing.Size(82, 13);
            ComparisonsLbl.TabIndex = 31;
            ComparisonsLbl.Text = "Comparisons= 0";
            // 
            // InfoBtn
            // 
            this.InfoBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.InfoBtn.BackColor = System.Drawing.Color.Black;
            this.InfoBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.InfoBtn.FlatAppearance.BorderSize = 3;
            this.InfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.InfoBtn.ForeColor = System.Drawing.Color.White;
            this.InfoBtn.Location = new System.Drawing.Point(30, 627);
            this.InfoBtn.Name = "InfoBtn";
            this.InfoBtn.Size = new System.Drawing.Size(25, 30);
            this.InfoBtn.TabIndex = 32;
            this.InfoBtn.Text = "i";
            this.InfoBtn.UseVisualStyleBackColor = false;
            this.InfoBtn.Click += new System.EventHandler(this.InfoBtn_Click);
            // 
            // SortPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.InfoBtn);
            this.Controls.Add(ComparisonsLbl);
            this.Controls.Add(WritesLbl);
            this.Controls.Add(ReadsLbl);
            this.Controls.Add(this.UseData);
            this.Controls.Add(this.SizeLbl);
            this.Controls.Add(this.DelayLbl);
            this.Controls.Add(this.DelayBar);
            this.Controls.Add(this.SizeBar);
            this.Controls.Add(this.SortDataBtn);
            this.Controls.Add(this.SortTitle);
            this.Controls.Add(this.SortPanel);
            this.Controls.Add(this.GameBtn);
            this.Controls.Add(this.DataBtn);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.GraphBox);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "SortPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SortingVisualiser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SortPage_FormClosing);
            this.SortPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GraphBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button GameBtn;
        private System.Windows.Forms.Button DataBtn;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Panel SortPanel;
        private System.Windows.Forms.Button SortBtn;
        private System.Windows.Forms.Button SelectionSortBtn;
        private System.Windows.Forms.Button QuickSortBtn;
        private System.Windows.Forms.Button RadixSortBtn;
        private System.Windows.Forms.Button BubbleSortBtn;
        private System.Windows.Forms.Button MergeSortBtn;
        private System.Windows.Forms.Button InsertionSortBtn;
        private System.Windows.Forms.Label SortTitle;
        private System.Windows.Forms.Button SortDataBtn;
        private System.Windows.Forms.TrackBar SizeBar;
        private System.Windows.Forms.TrackBar DelayBar;
        private System.Windows.Forms.Label DelayLbl;
        private System.Windows.Forms.Label SizeLbl;
        private System.Windows.Forms.CheckBox UseData;
        public System.Windows.Forms.PictureBox GraphBox;
        private System.Windows.Forms.Button InfoBtn;
        public static System.Windows.Forms.Label ReadsLbl;
        public static System.Windows.Forms.Label WritesLbl;
        public static System.Windows.Forms.Label ComparisonsLbl;
    }*/
}
