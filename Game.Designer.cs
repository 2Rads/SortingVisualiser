namespace SortingVisualiser
{
    partial class GamePage
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
            this.components = new System.ComponentModel.Container();
            this.GameBtn = new System.Windows.Forms.Button();
            this.DataBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.SortPanel = new System.Windows.Forms.Panel();
            this.SortBtn = new System.Windows.Forms.Button();
            this.BubbleSortBtn = new System.Windows.Forms.Button();
            this.SelectionSortBtn = new System.Windows.Forms.Button();
            this.QuickSortBtn = new System.Windows.Forms.Button();
            this.RadixSortBtn = new System.Windows.Forms.Button();
            this.MergeSortBtn = new System.Windows.Forms.Button();
            this.InsertionSortBtn = new System.Windows.Forms.Button();
            this.GameTitle = new System.Windows.Forms.Label();
            this.RotateTimer = new System.Windows.Forms.Timer(this.components);
            this.ComparisonsLbl = new System.Windows.Forms.Label();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.CheckBtn = new System.Windows.Forms.Button();
            this.GamePnl = new System.Windows.Forms.Panel();
            this.CompareBtn = new System.Windows.Forms.Button();
            this.RightComparer = new System.Windows.Forms.Panel();
            this.LeftComparer = new System.Windows.Forms.Panel();
            this.MassBox8 = new SortingVisualiser.CustomPictureBox(this.components);
            this.MassBox7 = new SortingVisualiser.CustomPictureBox(this.components);
            this.MassBox6 = new SortingVisualiser.CustomPictureBox(this.components);
            this.MassBox5 = new SortingVisualiser.CustomPictureBox(this.components);
            this.MassBox4 = new SortingVisualiser.CustomPictureBox(this.components);
            this.MassBox3 = new SortingVisualiser.CustomPictureBox(this.components);
            this.MassBox2 = new SortingVisualiser.CustomPictureBox(this.components);
            this.MassBox1 = new SortingVisualiser.CustomPictureBox(this.components);
            this.Place8 = new System.Windows.Forms.Panel();
            this.Place7 = new System.Windows.Forms.Panel();
            this.Place6 = new System.Windows.Forms.Panel();
            this.Place5 = new System.Windows.Forms.Panel();
            this.Place4 = new System.Windows.Forms.Panel();
            this.Place3 = new System.Windows.Forms.Panel();
            this.Place2 = new System.Windows.Forms.Panel();
            this.Place1 = new System.Windows.Forms.Panel();
            this.Arrow = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.TimeLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SortPanel.SuspendLayout();
            this.GamePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MassBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow)).BeginInit();
            this.SuspendLayout();
            // 
            // GameBtn
            // 
            this.GameBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GameBtn.BackColor = System.Drawing.Color.DimGray;
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
            this.SortPanel.Controls.Add(this.BubbleSortBtn);
            this.SortPanel.Controls.Add(this.SelectionSortBtn);
            this.SortPanel.Controls.Add(this.QuickSortBtn);
            this.SortPanel.Controls.Add(this.RadixSortBtn);
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
            // GameTitle
            // 
            this.GameTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GameTitle.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameTitle.ForeColor = System.Drawing.Color.White;
            this.GameTitle.Location = new System.Drawing.Point(425, 31);
            this.GameTitle.Name = "GameTitle";
            this.GameTitle.Size = new System.Drawing.Size(410, 61);
            this.GameTitle.TabIndex = 21;
            this.GameTitle.Text = "Game";
            this.GameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RotateTimer
            // 
            this.RotateTimer.Interval = 20;
            this.RotateTimer.Tick += new System.EventHandler(this.Rotate_Tick);
            // 
            // ComparisonsLbl
            // 
            this.ComparisonsLbl.AutoSize = true;
            this.ComparisonsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComparisonsLbl.ForeColor = System.Drawing.Color.White;
            this.ComparisonsLbl.Location = new System.Drawing.Point(860, 104);
            this.ComparisonsLbl.Name = "ComparisonsLbl";
            this.ComparisonsLbl.Size = new System.Drawing.Size(152, 24);
            this.ComparisonsLbl.TabIndex = 24;
            this.ComparisonsLbl.Text = "Comparisons = 0";
            // 
            // ResetBtn
            // 
            this.ResetBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ResetBtn.BackColor = System.Drawing.Color.Black;
            this.ResetBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ResetBtn.FlatAppearance.BorderSize = 3;
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.ForeColor = System.Drawing.Color.White;
            this.ResetBtn.Location = new System.Drawing.Point(944, 618);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(104, 38);
            this.ResetBtn.TabIndex = 25;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // CheckBtn
            // 
            this.CheckBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CheckBtn.BackColor = System.Drawing.Color.Black;
            this.CheckBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CheckBtn.FlatAppearance.BorderSize = 3;
            this.CheckBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBtn.ForeColor = System.Drawing.Color.White;
            this.CheckBtn.Location = new System.Drawing.Point(1099, 618);
            this.CheckBtn.Name = "CheckBtn";
            this.CheckBtn.Size = new System.Drawing.Size(104, 38);
            this.CheckBtn.TabIndex = 26;
            this.CheckBtn.Text = "Check";
            this.CheckBtn.UseVisualStyleBackColor = false;
            this.CheckBtn.Click += new System.EventHandler(this.CheckBtn_Click);
            // 
            // GamePnl
            // 
            this.GamePnl.Controls.Add(this.label3);
            this.GamePnl.Controls.Add(this.label2);
            this.GamePnl.Controls.Add(this.CompareBtn);
            this.GamePnl.Controls.Add(this.RightComparer);
            this.GamePnl.Controls.Add(this.LeftComparer);
            this.GamePnl.Controls.Add(this.MassBox8);
            this.GamePnl.Controls.Add(this.MassBox7);
            this.GamePnl.Controls.Add(this.MassBox6);
            this.GamePnl.Controls.Add(this.MassBox5);
            this.GamePnl.Controls.Add(this.MassBox4);
            this.GamePnl.Controls.Add(this.MassBox3);
            this.GamePnl.Controls.Add(this.MassBox2);
            this.GamePnl.Controls.Add(this.MassBox1);
            this.GamePnl.Controls.Add(this.Place8);
            this.GamePnl.Controls.Add(this.Place7);
            this.GamePnl.Controls.Add(this.Place6);
            this.GamePnl.Controls.Add(this.Place5);
            this.GamePnl.Controls.Add(this.Place4);
            this.GamePnl.Controls.Add(this.Place3);
            this.GamePnl.Controls.Add(this.Place2);
            this.GamePnl.Controls.Add(this.Place1);
            this.GamePnl.Controls.Add(this.Arrow);
            this.GamePnl.Location = new System.Drawing.Point(51, 126);
            this.GamePnl.Name = "GamePnl";
            this.GamePnl.Size = new System.Drawing.Size(1152, 486);
            this.GamePnl.TabIndex = 23;
            // 
            // CompareBtn
            // 
            this.CompareBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CompareBtn.BackColor = System.Drawing.Color.Black;
            this.CompareBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CompareBtn.FlatAppearance.BorderSize = 3;
            this.CompareBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompareBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompareBtn.ForeColor = System.Drawing.Color.White;
            this.CompareBtn.Location = new System.Drawing.Point(535, 268);
            this.CompareBtn.Name = "CompareBtn";
            this.CompareBtn.Size = new System.Drawing.Size(115, 38);
            this.CompareBtn.TabIndex = 24;
            this.CompareBtn.Text = "Compare";
            this.CompareBtn.UseVisualStyleBackColor = false;
            this.CompareBtn.Click += new System.EventHandler(this.CompareBtn_Click);
            // 
            // RightComparer
            // 
            this.RightComparer.BackColor = System.Drawing.Color.White;
            this.RightComparer.Location = new System.Drawing.Point(695, 182);
            this.RightComparer.Name = "RightComparer";
            this.RightComparer.Size = new System.Drawing.Size(80, 100);
            this.RightComparer.TabIndex = 10;
            // 
            // LeftComparer
            // 
            this.LeftComparer.BackColor = System.Drawing.Color.White;
            this.LeftComparer.Location = new System.Drawing.Point(402, 182);
            this.LeftComparer.Name = "LeftComparer";
            this.LeftComparer.Size = new System.Drawing.Size(80, 100);
            this.LeftComparer.TabIndex = 10;
            // 
            // MassBox8
            // 
            this.MassBox8.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.MassBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MassBox8.Location = new System.Drawing.Point(902, 15);
            this.MassBox8.Name = "MassBox8";
            this.MassBox8.Size = new System.Drawing.Size(80, 100);
            this.MassBox8.TabIndex = 16;
            this.MassBox8.TabStop = false;
            this.MassBox8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MassBox8_MouseUp);
            // 
            // MassBox7
            // 
            this.MassBox7.BackColor = System.Drawing.Color.Teal;
            this.MassBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MassBox7.Location = new System.Drawing.Point(763, 15);
            this.MassBox7.Name = "MassBox7";
            this.MassBox7.Size = new System.Drawing.Size(80, 100);
            this.MassBox7.TabIndex = 15;
            this.MassBox7.TabStop = false;
            this.MassBox7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MassBox7_MouseUp);
            // 
            // MassBox6
            // 
            this.MassBox6.BackColor = System.Drawing.Color.DarkGreen;
            this.MassBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MassBox6.Location = new System.Drawing.Point(620, 15);
            this.MassBox6.Name = "MassBox6";
            this.MassBox6.Size = new System.Drawing.Size(80, 100);
            this.MassBox6.TabIndex = 14;
            this.MassBox6.TabStop = false;
            this.MassBox6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MassBox6_MouseUp);
            // 
            // MassBox5
            // 
            this.MassBox5.BackColor = System.Drawing.Color.LawnGreen;
            this.MassBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MassBox5.Location = new System.Drawing.Point(474, 15);
            this.MassBox5.Name = "MassBox5";
            this.MassBox5.Size = new System.Drawing.Size(80, 100);
            this.MassBox5.TabIndex = 13;
            this.MassBox5.TabStop = false;
            this.MassBox5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MassBox5_MouseUp);
            // 
            // MassBox4
            // 
            this.MassBox4.BackColor = System.Drawing.Color.BlueViolet;
            this.MassBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MassBox4.Location = new System.Drawing.Point(1040, 15);
            this.MassBox4.Name = "MassBox4";
            this.MassBox4.Size = new System.Drawing.Size(80, 100);
            this.MassBox4.TabIndex = 14;
            this.MassBox4.TabStop = false;
            this.MassBox4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MassBox4_MouseUp);
            // 
            // MassBox3
            // 
            this.MassBox3.BackColor = System.Drawing.Color.Gold;
            this.MassBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MassBox3.Location = new System.Drawing.Point(327, 15);
            this.MassBox3.Name = "MassBox3";
            this.MassBox3.Size = new System.Drawing.Size(80, 100);
            this.MassBox3.TabIndex = 12;
            this.MassBox3.TabStop = false;
            this.MassBox3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MassBox3_MouseUp);
            // 
            // MassBox2
            // 
            this.MassBox2.BackColor = System.Drawing.Color.OrangeRed;
            this.MassBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MassBox2.Location = new System.Drawing.Point(180, 15);
            this.MassBox2.Name = "MassBox2";
            this.MassBox2.Size = new System.Drawing.Size(80, 100);
            this.MassBox2.TabIndex = 11;
            this.MassBox2.TabStop = false;
            this.MassBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MassBox2_MouseUp);
            // 
            // MassBox1
            // 
            this.MassBox1.BackColor = System.Drawing.Color.Maroon;
            this.MassBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MassBox1.Location = new System.Drawing.Point(40, 15);
            this.MassBox1.Name = "MassBox1";
            this.MassBox1.Size = new System.Drawing.Size(80, 100);
            this.MassBox1.TabIndex = 10;
            this.MassBox1.TabStop = false;
            this.MassBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MassBox1_MouseUp);
            // 
            // Place8
            // 
            this.Place8.BackColor = System.Drawing.Color.White;
            this.Place8.Location = new System.Drawing.Point(1040, 358);
            this.Place8.Name = "Place8";
            this.Place8.Size = new System.Drawing.Size(80, 100);
            this.Place8.TabIndex = 9;
            // 
            // Place7
            // 
            this.Place7.BackColor = System.Drawing.Color.White;
            this.Place7.Location = new System.Drawing.Point(902, 358);
            this.Place7.Name = "Place7";
            this.Place7.Size = new System.Drawing.Size(80, 100);
            this.Place7.TabIndex = 9;
            // 
            // Place6
            // 
            this.Place6.BackColor = System.Drawing.Color.White;
            this.Place6.Location = new System.Drawing.Point(763, 358);
            this.Place6.Name = "Place6";
            this.Place6.Size = new System.Drawing.Size(80, 100);
            this.Place6.TabIndex = 9;
            // 
            // Place5
            // 
            this.Place5.BackColor = System.Drawing.Color.White;
            this.Place5.Location = new System.Drawing.Point(620, 358);
            this.Place5.Name = "Place5";
            this.Place5.Size = new System.Drawing.Size(80, 100);
            this.Place5.TabIndex = 9;
            // 
            // Place4
            // 
            this.Place4.BackColor = System.Drawing.Color.White;
            this.Place4.Location = new System.Drawing.Point(474, 358);
            this.Place4.Name = "Place4";
            this.Place4.Size = new System.Drawing.Size(80, 100);
            this.Place4.TabIndex = 9;
            // 
            // Place3
            // 
            this.Place3.BackColor = System.Drawing.Color.White;
            this.Place3.Location = new System.Drawing.Point(327, 358);
            this.Place3.Name = "Place3";
            this.Place3.Size = new System.Drawing.Size(80, 100);
            this.Place3.TabIndex = 9;
            // 
            // Place2
            // 
            this.Place2.BackColor = System.Drawing.Color.White;
            this.Place2.Location = new System.Drawing.Point(180, 358);
            this.Place2.Name = "Place2";
            this.Place2.Size = new System.Drawing.Size(80, 100);
            this.Place2.TabIndex = 9;
            // 
            // Place1
            // 
            this.Place1.BackColor = System.Drawing.Color.White;
            this.Place1.Location = new System.Drawing.Point(40, 358);
            this.Place1.Name = "Place1";
            this.Place1.Size = new System.Drawing.Size(80, 100);
            this.Place1.TabIndex = 8;
            // 
            // Arrow
            // 
            this.Arrow.Image = global::SortingVisualiser.Properties.Resources.arrowimg;
            this.Arrow.Location = new System.Drawing.Point(535, 167);
            this.Arrow.Name = "Arrow";
            this.Arrow.Size = new System.Drawing.Size(115, 115);
            this.Arrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Arrow.TabIndex = 25;
            this.Arrow.TabStop = false;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // TimeLbl
            // 
            this.TimeLbl.AutoSize = true;
            this.TimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLbl.ForeColor = System.Drawing.Color.White;
            this.TimeLbl.Location = new System.Drawing.Point(731, 102);
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(82, 24);
            this.TimeLbl.TabIndex = 27;
            this.TimeLbl.Text = "Time: 0s";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 616);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 54);
            this.label1.TabIndex = 28;
            this.label1.Text = "Objective: Sort the colourful blocks from lightest to heaviest.\r\nUse the comparer" +
    " in the middle to point to the heavier mass.\r\nTry to do it in the least comparis" +
    "ons.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(49, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Lightest";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1050, 461);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Heaviest";
            // 
            // GamePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeLbl);
            this.Controls.Add(this.SortPanel);
            this.Controls.Add(this.GamePnl);
            this.Controls.Add(this.CheckBtn);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.ComparisonsLbl);
            this.Controls.Add(this.GameTitle);
            this.Controls.Add(this.GameBtn);
            this.Controls.Add(this.DataBtn);
            this.Controls.Add(this.HomeBtn);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "GamePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SortingVisualiser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GamePage_FormClosing);
            this.SortPanel.ResumeLayout(false);
            this.GamePnl.ResumeLayout(false);
            this.GamePnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MassBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow)).EndInit();
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
        private System.Windows.Forms.Label GameTitle;
        private System.Windows.Forms.Timer RotateTimer;
        private System.Windows.Forms.Label ComparisonsLbl;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button CheckBtn;
        private System.Windows.Forms.Panel GamePnl;
        private System.Windows.Forms.Button CompareBtn;
        public System.Windows.Forms.Panel RightComparer;
        public System.Windows.Forms.Panel LeftComparer;
        private CustomPictureBox MassBox8;
        private CustomPictureBox MassBox7;
        private CustomPictureBox MassBox6;
        private CustomPictureBox MassBox5;
        private CustomPictureBox MassBox4;
        private CustomPictureBox MassBox3;
        private CustomPictureBox MassBox2;
        private CustomPictureBox MassBox1;
        public System.Windows.Forms.Panel Place8;
        public System.Windows.Forms.Panel Place7;
        public System.Windows.Forms.Panel Place6;
        public System.Windows.Forms.Panel Place5;
        public System.Windows.Forms.Panel Place4;
        public System.Windows.Forms.Panel Place3;
        public System.Windows.Forms.Panel Place2;
        public System.Windows.Forms.Panel Place1;
        private System.Windows.Forms.PictureBox Arrow;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label TimeLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}