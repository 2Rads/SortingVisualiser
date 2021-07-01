using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SortingVisualiser
{
    public partial class DataPage : Form
    {
        private bool CloseAll = true;
        public static int[] DataNums { get; private set; }
        public DataPage()
        {
            InitializeComponent();
        }
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            CloseAll = false;
            //finds home page then unhides it
            var formToShow = Application.OpenForms.Cast<Form>()
                            .FirstOrDefault(c => c is HomePage);
            formToShow.Size = new Size(this.Size.Width, this.Size.Height);
            formToShow.Location = new Point(this.Location.X, this.Location.Y);
            formToShow.Show();
            this.Close();
        }
        private void GameBtn_Click(object sender, EventArgs e)
        {
            CloseAll = false;
            GamePage game = new GamePage();
            game.Size = new Size(this.Size.Width, this.Size.Height);
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
            this.Close();
            sort.Show();

        }
        private void DataPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseAll)
            {
                Application.Exit();
            }
        }

        private void AddDataBtn_Click(object sender, EventArgs e)
        {
            // Open file explorer, allows you to select a text file
            OpenFileDialog openFileDialog = new OpenFileDialog() {
                Filter = "Text Documents|*.txt", Multiselect = false, ValidateNames = true
            };
            //checks valid input
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //places all text into a string then converts it to an array.
                string StringToConvert = File.ReadAllText(openFileDialog.FileName);
                ConvertString(StringToConvert);
                DisplayData();
            }
            openFileDialog.Dispose();
        }

        private void ConvertString(string StringToConvert)
        {
            int CurrentInt = -1;
            List<int> ConvertList = new List<int>();

            for(int i = 0; i< StringToConvert.Length; i++)  //passes through each character
            {                                               
                if(StringToConvert[i] == ',' && CurrentInt != -1)
                {  
                    ConvertList.Add(CurrentInt);            //valid so add to list
                    CurrentInt = -1;
                }
                else if(CurrentInt > 99999999) { }          //to large so ignore
                else if(int.TryParse(StringToConvert[i].ToString(), out int n))     //checks valid int.
                {                                           
                    if(CurrentInt == -1)                    //must start at 0
                    {
                        CurrentInt = 0;
                    }
                    CurrentInt *= 10;                       //left shift
                    CurrentInt += n;                        //adds on current digit
                }
            }

            if(CurrentInt != -1)                            //adds last value
            {
                ConvertList.Add(CurrentInt);
            }

            DataNums = ConvertList.ToArray();               //converts to array
        }

        private void DisplayData()
        {
            DataBox.Clear();
            foreach(int i in DataNums)
            {
                DataBox.Text += i + ",";
            }
        }
        private void SaveDataBtn_Click(object sender, EventArgs e)
        {
            //copies data
            int[] SortedData = new int[DataNums.Length];
            DataNums.CopyTo(SortedData, 0);

            Array.Sort(SortedData);
            //saves as text file
            SaveFileDialog savefile = new SaveFileDialog
            {
                FileName = "SortingVisualiser.txt",
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
            };
            //if location and saved name is valid, then write in file.
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(savefile.FileName))
                {
                    foreach (float num in SortedData)
                    {
                        sw.Write(num + ", ");
                    }
                }
            }
            savefile.Dispose();
        }

    }
}