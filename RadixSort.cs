using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SortingVisualiser
{
    class RadixSort
    {
        private static int[] nums;
        private static PictureBox graph;
        public static void Sort(int[] numbers, PictureBox box, List<Bars> bars)
        {
            //copies numbers to nums
            nums = numbers;
            graph = box;

            //creates a list of stacks
            List<Stack<int>> ls = CreateStructure();

            int MaxLength = MaxLen();
            for (int len = 0; len < MaxLength; len++)
            {
                for (int i = nums.Length - 1; i >= 0; i--)
                {
                    //gets current digit
                    int digit = (int)(nums[i] / Math.Pow(10, len));
                    digit %= 10;

                    //adds in correct stack
                    ls[digit].Push(nums[i]);
                    SortPage.Reads+=2;//read twice (for digit and to add to stack)
                    SortPage.UpdateReadLbl();

                    AddBarColours(i, digit, bars);
                    UpdateGraph(SortPage.Delay, bars);
                }

                //goes through each stack
                for (int i = 0, j = 0; i < 10; i++)
                {
                    //removes all values until it is empty
                    while (ls[i].Count > 0)
                    {
                        nums[j] = ls[i].Pop();
                        SortPage.Writes++;
                        SortPage.UpdateWriteLbl();

                        AddBarBack(j, bars);
                        UpdateGraph(SortPage.Delay, bars);
                        j++;
                    }
                }
            }
            UpdateGraph(0, bars);
        }

        private static List<Stack<int>> CreateStructure()
        {
            List<Stack<int>> ls = new List<Stack<int>>();

            //adds 10 stacks to list
            for (int i = 0; i < 10; i++)
            {
                Stack<int> st = new Stack<int>();
                ls.Add(st);
            }
            return ls;
        }
        private static int MaxLen()
        {
            int max = 0;                //lowest value is 0, no negatives

            //finds highest value
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];      //if greater value, replace current max
                }
            }
            int Length = 0;
            for (; max >= 1; Length++)
            {
                max /= 10;         //after each devide, length decreases by 1
            }
            return Length;
        }
        private static void AddBarBack(int i, List<Bars> bars)
        {
            RectangleF rectangle = new RectangleF(new PointF(i * SortPage.WidthConstant, 0),
                                                  new SizeF(SortPage.WidthConstant, 9999));
            Bars bar = new Bars(SortPage.CreateRectangle(i), new Region(rectangle));
            bars.Add(bar);
        }
        private static void AddBarColours(int i, int digit, List<Bars> bars)
        {
            Color colour = GetColour(digit);
            RectangleF rectangle = new RectangleF(new PointF(i * SortPage.WidthConstant, 0),
                                                  new SizeF(SortPage.WidthConstant, 9999));
            Bars bar = new Bars(SortPage.CreateRectangle(i), colour, new Region(rectangle));
            bars.Add(bar);
        }
        private static void UpdateGraph(int delay, List<Bars> bars)
        {
            //updates panel
            for (int j = 0; j < bars.Count; j++)
            {
                graph.Invalidate(bars[j].Region);
            }
            graph.Update();
            Thread.Sleep(delay);
        }
        private static Color GetColour(int digit)
        {
            switch (digit)
            {
                case 1:
                    return Color.FromArgb(255, 255, 153, 51);
                case 2:
                    return Color.FromArgb(255, 255, 255, 51);
                case 3:
                    return Color.FromArgb(255, 153, 255, 51);
                case 4:
                    return Color.FromArgb(255, 34, 139, 34);
                case 5:
                    return Color.FromArgb(255, 64, 224, 208);
                case 6:
                    return Color.FromArgb(255, 51, 51, 255);
                case 7:
                    return Color.FromArgb(255, 153, 51, 255);
                case 8:
                    return Color.FromArgb(255, 255, 105, 180);
                case 9:
                    return Color.FromArgb(255, 240, 15, 15);
                default:                                        //0
                    return Color.FromArgb(255, 255, 51, 51);
            }
        }
    }
}
