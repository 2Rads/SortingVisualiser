using System;
using System.Drawing;
using System.Windows.Forms;

namespace SortingVisualiser
{
    public partial class HomePage : Form
    {
        //colours used for sort page
        public static Color PrimaryColour { get; private set; }
        public static Color SecondaryColour { get; private set; } 
        public HomePage()
        {
            InitializeComponent();
            PrimaryColour = Color.FromArgb(255, 66, 133, 244);
            SecondaryColour  = Color.FromArgb(255, 219, 68, 55);
        }

        private void DataBtn_Click(object sender, EventArgs e)
        {
            DataPage data = new DataPage();
            data.Size = new Size(this.Size.Width, this.Size.Height);
            data.Location = new Point(this.Location.X, this.Location.Y);
            data.Show();
            SortPanel.Height = SortPanel.MinimumSize.Height;
            this.Hide();
        }

        private void GameBtn_Click(object sender, EventArgs e)
        {
            GamePage game = new GamePage();
            game.Size = new Size(this.Size.Width, this.Size.Height);
            game.Location = new Point(this.Location.X, this.Location.Y);
            game.Show();
            SortPanel.Height = SortPanel.MinimumSize.Height;
            this.Hide();
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
            SortPage sort = new SortPage(name);
            sort.Size = new Size(this.Size.Width, this.Size.Height);
            sort.Location = new Point(this.Location.X, this.Location.Y);
            sort.Show();
            SortPanel.Height = SortPanel.MinimumSize.Height;
            this.Hide();
        }

        private void ColourBtn1_Click(object sender, EventArgs e)
        {
            //allows user to select colour
            colorDialog1.ShowDialog();
            //allows access to be used by bars and makes it the border colour
            PrimaryColour = colorDialog1.Color;
            ColourBtn1.FlatAppearance.BorderColor = colorDialog1.Color;
        }

        private void ColourBtn2_Click(object sender, EventArgs e)
        {
            //allows user to select colour
            colorDialog2.ShowDialog();
            //allows access to be used by bars and makes it the border colour
            SecondaryColour = colorDialog2.Color;
            ColourBtn2.FlatAppearance.BorderColor = colorDialog2.Color;
        }
    }
}
