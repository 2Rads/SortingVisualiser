using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SortingVisualiser
{
    public class CustomPictureBox : PictureBox
    {
        public CustomPictureBox(IContainer container)
        {
            container.Add(this);
        }

        private Point point;
        public int Mass;
        public int place;
        public int comparing;

        protected override void OnMouseDown(MouseEventArgs e)
        {
            this.BringToFront();
            base.OnMouseDown(e);
            point = e.Location;
            //no longer in bottom position, so removed
            if (place != 0)
            {
                GamePage.places[place - 1] = 0;
                place = 0;
            }
            if(comparing != 0)
            {
                GamePage.comparers[comparing - 1] = 0;
                comparing = 0;
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
        }
    }
}

/*namespace SortingVisualiser
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
            this.SelectionSortBtn = new System.Windows.Forms.Button();
            this.QuickSortBtn = new System.Windows.Forms.Button();
            this.RadixSortBtn = new System.Windows.Forms.Button();
            this.BubbleSortBtn = new System.Windows.Forms.Button();
            this.MergeSortBtn = new System.Windows.Forms.Button();
            this.InsertionSortBtn = new System.Windows.Forms.Button();
            this.GameTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MassBox9 = new SortingVisualiser.CustomPictureBox(this.components);
            this.MassBox8 = new SortingVisualiser.CustomPictureBox(this.components);
            this.MassBox7 = new SortingVisualiser.CustomPictureBox(this.components);
            this.MassBox6 = new SortingVisualiser.CustomPictureBox(this.components);
            this.MassBox5 = new SortingVisualiser.CustomPictureBox(this.components);
            this.MassBox3 = new SortingVisualiser.CustomPictureBox(this.components);
            this.MassBox2 = new SortingVisualiser.CustomPictureBox(this.components);
            this.MassBox1 = new SortingVisualiser.CustomPictureBox(this.components);
            Place8 = new System.Windows.Forms.Panel();
            Place7 = new System.Windows.Forms.Panel();
            Place6 = new System.Windows.Forms.Panel();
            Place5 = new System.Windows.Forms.Panel();
            Place4 = new System.Windows.Forms.Panel();
            Place3 = new System.Windows.Forms.Panel();
            Place2 = new System.Windows.Forms.Panel();
            Place1 = new System.Windows.Forms.Panel();
            this.SortPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MassBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassBox1)).BeginInit();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.MassBox9);
            this.panel1.Controls.Add(this.MassBox8);
            this.panel1.Controls.Add(this.MassBox7);
            this.panel1.Controls.Add(this.MassBox6);
            this.panel1.Controls.Add(this.MassBox5);
            this.panel1.Controls.Add(this.MassBox3);
            this.panel1.Controls.Add(this.MassBox2);
            this.panel1.Controls.Add(this.MassBox1);
            this.panel1.Controls.Add(Place8);
            this.panel1.Controls.Add(Place7);
            this.panel1.Controls.Add(Place6);
            this.panel1.Controls.Add(Place5);
            this.panel1.Controls.Add(Place4);
            this.panel1.Controls.Add(Place3);
            this.panel1.Controls.Add(Place2);
            this.panel1.Controls.Add(Place1);
            this.panel1.Location = new System.Drawing.Point(51, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 486);
            this.panel1.TabIndex = 23;
            // 
            // MassBox9
            // 
            this.MassBox9.BackColor = System.Drawing.Color.BlueViolet;
            this.MassBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MassBox9.Location = new System.Drawing.Point(1040, 15);
            this.MassBox9.Name = "MassBox9";
            this.MassBox9.Size = new System.Drawing.Size(80, 100);
            this.MassBox9.TabIndex = 14;
            this.MassBox9.TabStop = false;
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
            // 
            // Place8
            // 
            Place8.BackColor = System.Drawing.Color.White;
            Place8.Location = new System.Drawing.Point(1040, 358);
            Place8.Name = "Place8";
            Place8.Size = new System.Drawing.Size(80, 100);
            Place8.TabIndex = 9;
            // 
            // Place7
            // 
            Place7.BackColor = System.Drawing.Color.White;
            Place7.Location = new System.Drawing.Point(902, 358);
            Place7.Name = "Place7";
            Place7.Size = new System.Drawing.Size(80, 100);
            Place7.TabIndex = 9;
            // 
            // Place6
            // 
            Place6.BackColor = System.Drawing.Color.White;
            Place6.Location = new System.Drawing.Point(763, 358);
            Place6.Name = "Place6";
            Place6.Size = new System.Drawing.Size(80, 100);
            Place6.TabIndex = 9;
            // 
            // Place5
            // 
            Place5.BackColor = System.Drawing.Color.White;
            Place5.Location = new System.Drawing.Point(620, 358);
            Place5.Name = "Place5";
            Place5.Size = new System.Drawing.Size(80, 100);
            Place5.TabIndex = 9;
            // 
            // Place4
            // 
            Place4.BackColor = System.Drawing.Color.White;
            Place4.Location = new System.Drawing.Point(474, 358);
            Place4.Name = "Place4";
            Place4.Size = new System.Drawing.Size(80, 100);
            Place4.TabIndex = 9;
            // 
            // Place3
            // 
            Place3.BackColor = System.Drawing.Color.White;
            Place3.Location = new System.Drawing.Point(327, 358);
            Place3.Name = "Place3";
            Place3.Size = new System.Drawing.Size(80, 100);
            Place3.TabIndex = 9;
            // 
            // Place2
            // 
            Place2.BackColor = System.Drawing.Color.White;
            Place2.Location = new System.Drawing.Point(180, 358);
            Place2.Name = "Place2";
            Place2.Size = new System.Drawing.Size(80, 100);
            Place2.TabIndex = 9;
            // 
            // Place1
            // 
            Place1.BackColor = System.Drawing.Color.White;
            Place1.Location = new System.Drawing.Point(40, 358);
            Place1.Name = "Place1";
            Place1.Size = new System.Drawing.Size(80, 100);
            Place1.TabIndex = 8;
            // 
            // GamePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GameTitle);
            this.Controls.Add(this.SortPanel);
            this.Controls.Add(this.GameBtn);
            this.Controls.Add(this.DataBtn);
            this.Controls.Add(this.HomeBtn);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "GamePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SortingVisualiser";
            this.SortPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MassBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassBox1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
        public static System.Windows.Forms.Panel Place8;
        public static System.Windows.Forms.Panel Place7;
        public static System.Windows.Forms.Panel Place6;
        public static System.Windows.Forms.Panel Place5;
        public static System.Windows.Forms.Panel Place4;
        public static System.Windows.Forms.Panel Place3;
        public static System.Windows.Forms.Panel Place2;
        public static System.Windows.Forms.Panel Place1;
        private CustomPictureBox MassBox1;
        private CustomPictureBox MassBox8;
        private CustomPictureBox MassBox7;
        private CustomPictureBox MassBox6;
        private CustomPictureBox MassBox9;
        private CustomPictureBox MassBox5;
        private CustomPictureBox MassBox3;
        private CustomPictureBox MassBox2;
    }
}
*/