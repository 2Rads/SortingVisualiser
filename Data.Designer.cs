namespace SortingVisualiser
{
    partial class DataPage
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
            this.DataTitle = new System.Windows.Forms.Label();
            this.DataBox = new System.Windows.Forms.RichTextBox();
            this.AddDataBtn = new System.Windows.Forms.Button();
            this.SaveDataBtn = new System.Windows.Forms.Button();
            this.InfoLbl = new System.Windows.Forms.Label();
            this.SortPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.DataBtn.BackColor = System.Drawing.Color.DimGray;
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
            this.SortBtn.BackColor = System.Drawing.Color.Black;
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
            // DataTitle
            // 
            this.DataTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DataTitle.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataTitle.ForeColor = System.Drawing.Color.White;
            this.DataTitle.Location = new System.Drawing.Point(425, 31);
            this.DataTitle.Name = "DataTitle";
            this.DataTitle.Size = new System.Drawing.Size(410, 61);
            this.DataTitle.TabIndex = 21;
            this.DataTitle.Text = "Data";
            this.DataTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataBox
            // 
            this.DataBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DataBox.BackColor = System.Drawing.Color.Black;
            this.DataBox.DetectUrls = false;
            this.DataBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataBox.ForeColor = System.Drawing.Color.White;
            this.DataBox.Location = new System.Drawing.Point(51, 113);
            this.DataBox.Name = "DataBox";
            this.DataBox.ReadOnly = true;
            this.DataBox.Size = new System.Drawing.Size(1152, 464);
            this.DataBox.TabIndex = 22;
            this.DataBox.Text = "";
            // 
            // AddDataBtn
            // 
            this.AddDataBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddDataBtn.BackColor = System.Drawing.Color.Black;
            this.AddDataBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddDataBtn.FlatAppearance.BorderSize = 3;
            this.AddDataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDataBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.AddDataBtn.ForeColor = System.Drawing.Color.White;
            this.AddDataBtn.Location = new System.Drawing.Point(51, 597);
            this.AddDataBtn.Name = "AddDataBtn";
            this.AddDataBtn.Size = new System.Drawing.Size(137, 61);
            this.AddDataBtn.TabIndex = 23;
            this.AddDataBtn.Text = "Add Data";
            this.AddDataBtn.UseVisualStyleBackColor = false;
            this.AddDataBtn.Click += new System.EventHandler(this.AddDataBtn_Click);
            // 
            // SaveDataBtn
            // 
            this.SaveDataBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SaveDataBtn.BackColor = System.Drawing.Color.Black;
            this.SaveDataBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SaveDataBtn.FlatAppearance.BorderSize = 3;
            this.SaveDataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveDataBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SaveDataBtn.ForeColor = System.Drawing.Color.White;
            this.SaveDataBtn.Location = new System.Drawing.Point(1066, 597);
            this.SaveDataBtn.Name = "SaveDataBtn";
            this.SaveDataBtn.Size = new System.Drawing.Size(137, 61);
            this.SaveDataBtn.TabIndex = 24;
            this.SaveDataBtn.Text = "Save Sorted Data";
            this.SaveDataBtn.UseVisualStyleBackColor = false;
            this.SaveDataBtn.Click += new System.EventHandler(this.SaveDataBtn_Click);
            // 
            // InfoLbl
            // 
            this.InfoLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.InfoLbl.AutoSize = true;
            this.InfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLbl.ForeColor = System.Drawing.Color.White;
            this.InfoLbl.Location = new System.Drawing.Point(441, 587);
            this.InfoLbl.Name = "InfoLbl";
            this.InfoLbl.Size = new System.Drawing.Size(359, 80);
            this.InfoLbl.TabIndex = 25;
            this.InfoLbl.Text = "Use a text file to enter data.\r\nValues must be seperated by a comma.\r\nAny digit a" +
    "fter the 8th digits will be ignored.\r\nAny other character will be ignored (no ne" +
    "gatives).";
            this.InfoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DataPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.InfoLbl);
            this.Controls.Add(this.SaveDataBtn);
            this.Controls.Add(this.AddDataBtn);
            this.Controls.Add(this.DataTitle);
            this.Controls.Add(this.SortPanel);
            this.Controls.Add(this.GameBtn);
            this.Controls.Add(this.DataBtn);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.DataBox);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "DataPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SortingVisualiser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DataPage_FormClosing);
            this.SortPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Label DataTitle;
        private System.Windows.Forms.RichTextBox DataBox;
        private System.Windows.Forms.Button AddDataBtn;
        private System.Windows.Forms.Button SaveDataBtn;
        private System.Windows.Forms.Label InfoLbl;
    }
}