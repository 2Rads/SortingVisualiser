using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace SortingVisualiser
{
    public enum SortingName
    {
        Bubble, Merge, Quick, Radix, Insertion, Selection
    }
    public partial class SortPage : Form
    {
        private bool CloseAll = true;
        private static int[] nums;
        private static List<Bars> bars = new List<Bars>();
        private static SortingName Title;
        private static readonly Random rand = new Random();
        public static float HeightConstant;                     //multiplier for height
        public static float WidthConstant { get; private set; } //multiplier for width
        private static float GraphBoxHeight;                    
        public static int Delay { get; private set; } = 30;
        private bool CopyCurrentArray = false;
        public static int Reads = 0, Writes = 0, Comparisons = 0;

        public SortPage(SortingName name)
        {
            Title = name;
            InitializeComponent();
            SortTitle.Text = name.ToString() + " Sort";
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            CloseAll = false;
            var formToShow = Application.OpenForms.Cast<Form>()
                            .FirstOrDefault(c => c is HomePage);

            formToShow.Size = new Size(this.SizeLbl.Width, this.SizeLbl.Height);
            formToShow.Location = new Point(this.Location.X, this.Location.Y);
            formToShow.Show();
            this.Close();
        }
        private void DataBtn_Click(object sender, EventArgs e)
        {
            CloseAll = false;
            DataPage data = new DataPage();
            data.Size = new Size(this.SizeLbl.Width, this.SizeLbl.Height);
            data.Location = new Point(this.Location.X, this.Location.Y);
            data.Show();
            this.Close();

        }
        private void GameBtn_Click(object sender, EventArgs e)
        {
            CloseAll = false;
            GamePage game = new GamePage();
            game.Size = new Size(this.SizeLbl.Width, this.SizeLbl.Height);
            game.Location = new Point(this.Location.X, this.Location.Y);
            game.Show();
            this.Close();

        }
        private void SortBtn_Click(object sender, EventArgs e)
        {
            //shows and hides sorting algorithms
            if (SortPanel.Height == SortPanel.MaximumSize.Height)
            {
                SortPanel.Height = SortPanel.MinimumSize.Height;
            }
            else
            {
                SortPanel.Height = SortPanel.MaximumSize.Height;
            }
        }
        private void BubbleSortBtn_Click(object sender, EventArgs e)
        {
            CreateSortPage(SortingName.Bubble);
        }
        private void MergeSortBtn_Click(object sender, EventArgs e)
        {
            CreateSortPage(SortingName.Merge);
        }
        private void QuickSortBtn_Click(object sender, EventArgs e)
        {
            CreateSortPage(SortingName.Quick);
        }
        private void RadixSortBtn_Click(object sender, EventArgs e)
        {
            CreateSortPage(SortingName.Radix);
        }
        private void InsertionSortBtn_Click(object sender, EventArgs e)
        {
            CreateSortPage(SortingName.Insertion);
        }
        private void SelectionSortBtn_Click(object sender, EventArgs e)
        {
            CreateSortPage(SortingName.Selection);
        }
        private void CreateSortPage(SortingName name)
        {
            CloseAll = false;
            SortPage sort = new SortPage(name);
            sort.Size = new Size(this.Size.Width, this.Size.Height);
            sort.Location = new Point(this.Location.X, this.Location.Y);
            sort.Show();
            this.Close();

        }
        private void SortPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseAll)
            {
                Application.Exit();
            }
        }

        public static void UpdateReadLbl()
        {
            ReadsLbl.Text = "Reads = " + Reads;
            ReadsLbl.Update();
        }
        public static void UpdateWriteLbl()
        {
            WritesLbl.Text = "Writes = " + Writes;
            WritesLbl.Update();
        }
        public static void UpdateComparisonLbl()
        {
            ComparisonsLbl.Text = "Comparisons = " + Comparisons;
            ComparisonsLbl.Update();
        }

        private void SizeBar_Scroll(object sender, EventArgs e)
        {
            //displays current size
            SizeLbl.Text = "Size: " + SizeBar.Value;
        }
        private void SizeBar_MouseUp(object sender, MouseEventArgs e)
        {
            //displays current 
            CopyCurrentArray = true;
            CreateRandomArray(SizeBar.Value);
            InitialiseGraph();
        }

        private void DelayBar_Scroll(object sender, EventArgs e)
        {
            Delay = DelayBar.Value;
            DelayLbl.Text = "Delay: " + Delay;
        }

        private void InfoBtn_Click(object sender, EventArgs e)
        {
            Info info = new Info(Title);
            info.Show();
        }

        private void UseData_Click(object sender, EventArgs e)
        {
            //if nums is not initialised or no inputs.
            if (DataPage.DataNums == null || DataPage.DataNums.Length == 0)
            {
                UseData.Checked = false;
                return;
            }
            //shows what graph looks like using input data
            if (UseData.Checked)
            {
                CopyArray();
                InitialiseGraph();
            }
            //hides or shows, opposite of checked.
            SizeLbl.Visible = !UseData.Checked;
            SizeBar.Visible = !UseData.Checked;
        }

        private void GraphBox_Paint(object sender, PaintEventArgs e)
        {
            //takes values from the list and adds them in
            int ThisCount = bars.Count;         //used so it is only applied once on each item
            for (int i = 0; i < ThisCount; i++)
            {
                bars[i].UseBar(out RectangleF rec, out Color colour, out bool initial);
                Brush brush = new SolidBrush(colour);
                e.Graphics.FillRectangle(brush, rec); //draws rectangle

                if (!initial)
                {
                    bars.RemoveAt(i);
                    i--; ThisCount--;
                }
            }
        }

        private void SortDataBtn_Click(object sender, EventArgs e)
        {
            if (UseData.Checked)
            {
                CopyArray();//recopies.
            }
            else if (!CopyCurrentArray)
            {
                CreateRandomArray(SizeBar.Value);
            }
            //re-initialise values
            Comparisons = Writes = Reads = 0;
            UpdateReadLbl();
            UpdateWriteLbl();
            UpdateComparisonLbl();
            InitialiseGraph();//some values (like form size) might have changed
            Thread.Sleep(1000);//so user has time to see initial graph
            ChooseAlgorithm();
            CopyCurrentArray = false;
        }

        private void ChooseAlgorithm()
        {
            //sorts using sorting algorithm
            switch (Title)
            {
                case SortingName.Bubble:
                    BubbleSort.Sort(nums, GraphBox, bars);
                    break;
                case SortingName.Merge:
                    MergeSort.Sort(nums, GraphBox, bars);
                    break;
                case SortingName.Quick:
                    QuickSort.Sort(nums, GraphBox, bars);
                    break;
                case SortingName.Radix:
                    RadixSort.Sort(nums, GraphBox, bars);
                    break;
                case SortingName.Insertion:
                    InsertionSort.Sort(nums, GraphBox, bars);
                    break;
                case SortingName.Selection:
                    SelectionSort.Sort(nums, GraphBox, bars);
                    break;
            }
        }

        private void InitialiseGraph()
        {
            //initialise constants for graph
            WidthConstant = GraphBox.Width / nums.Length;
            GraphBoxHeight = GraphBox.Height;//contant incase it changes during running
            HeightConstant = (float)GraphBox.Height / nums.Max();

            //display unsorted graph
            bars = new List<Bars>();
            for (int i = 0; i < nums.Length; i++)
            {
                bars.Add(new Bars(CreateRectangle(i)));
            }
            GraphBox.Invalidate();
            GraphBox.Update();
        }

        public static RectangleF CreateRectangle(int i)
        {
            RectangleF rectangle = new RectangleF(new PointF(WidthConstant * i, GraphBoxHeight - (nums[i] * HeightConstant)),
                                                     new SizeF(WidthConstant, GraphBoxHeight));
            return rectangle;
        }

        private void CopyArray()
        {
            nums = new int[DataPage.DataNums.Length];
            DataPage.DataNums.CopyTo(nums, 0);
        }
        private void CreateRandomArray(int size)
        {
            nums = new int[size];
            for (int i = 0; i < size; i++)
            {
                nums[i] = rand.Next(0, 999);
            }
        }
    }

    class Bars
    {
        private RectangleF rectangle;                       //used for bar
        private readonly Color colour = HomePage.SecondaryColour;    //changed colour (red)
        private readonly Color FinalColour = HomePage.PrimaryColour; //change colour back (blue)
        public Region Region { get; }                       //area to invalidate
        private bool initial;                               //determines if colour will change back

        //permenant with default primary colour
        public Bars(RectangleF rectangle) 
        {
            this.rectangle = rectangle;
            this.initial = false;
        }
        //default, change to secondary then to primary
        public Bars(RectangleF rectangle, Region region )
        {
            this.rectangle = rectangle;
            this.Region = region;
            this.initial = true;
        }
        //permentant custom colour
        public Bars(RectangleF rectangle, Color colour, Region region)
        {
            this.rectangle = rectangle;
            this.FinalColour = colour;
            this.Region = region;
            this.initial = false;
        }
        //returns variales for update
        public void UseBar(out RectangleF rectangle, out Color col, out bool initial)
        {
            col = this.initial ? colour : FinalColour;
            rectangle = this.rectangle;
            initial = this.initial;
            this.initial = false;
        }
    }
 }

