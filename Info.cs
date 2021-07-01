using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingVisualiser
{
    public partial class Info : Form
    {
        public Info(SortingName name)
        {
            InitializeComponent();
            LoadImage(name);
        }
        private void LoadImage(SortingName name)
        {
            //loads image into container
            switch (name)
            {
                case SortingName.Bubble:
                    pictureBox1.Image = Properties.Resources.Bubble_Sort_av;
                    break;
                case SortingName.Merge:
                    pictureBox1.Image = Properties.Resources.Merge_Sort_av;
                    break;
                case SortingName.Quick:
                    pictureBox1.Image = Properties.Resources.Quick_Sort_av;
                    break;
                case SortingName.Radix:
                    pictureBox1.Image = Properties.Resources.Radix_Sort;
                    break;
                case SortingName.Insertion:
                    pictureBox1.Image = Properties.Resources.InsertionTree;
                    break;
                case SortingName.Selection:
                    pictureBox1.Image = Properties.Resources.Selection_Sort_av;
                    break;
            }
            //makes container size of image
            pictureBox1.Size = pictureBox1.Image.Size;
            //makes form size if image with borders
            this.Size = new Size(pictureBox1.Width + 16, pictureBox1.Height + 39);
        }
    }
}
