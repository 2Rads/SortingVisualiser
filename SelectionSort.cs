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
    class SelectionSort
    {
        private static int[] nums;
        private static List<Bars> bars;
        private static PictureBox graph;
        public static void Sort(int[] numbers, PictureBox box, List<Bars> barsList)
        {
            nums = numbers;
            graph = box;
            bars = barsList;

            //finds next smallest then moves it infront
            for (int i = 0; i < nums.Length - 1; i++)
            {
                int smallest = FindSmallest(i);
                Swap(i, smallest);
                AddSwapBar(i);
                AddSwapBar(smallest);
                UpdateGraph(SortPage.Delay);
            }
            UpdateGraph(0);
        }

        private static int FindSmallest(int i)
        {
            int smallest = i++;                   //current smallest index

            for (; i < nums.Length; i++)
            {
                AddincrementBar(i);
                UpdateGraph(SortPage.Delay);

                SortPage.Comparisons++;
                SortPage.UpdateComparisonLbl();
                SortPage.Reads += 2;
                SortPage.UpdateReadLbl();
                if (nums[i] < nums[smallest])
                {
                    smallest = i;               //assigned as new smallest
                }
            }
            return smallest;
        }

        private static void Swap(int a, int b)
        {
            int temp = nums[a];
            nums[a] = nums[b];
            nums[b] = temp;
            SortPage.Writes+=2;
            SortPage.UpdateWriteLbl();
        }
        private static void AddSwapBar(int i)
        {
            RectangleF rectangle = new RectangleF(new PointF(i * SortPage.WidthConstant, 0),
                                                  new SizeF(SortPage.WidthConstant, 9999));
            Bars bar = new Bars(SortPage.CreateRectangle(i), new Region(rectangle));
            bars.Add(bar);
        }
        private static void AddincrementBar(int i)
        {
            RectangleF rectangle = new RectangleF(new PointF(i * SortPage.WidthConstant, 0),
                                                  new SizeF(SortPage.WidthConstant, 9999));
            Bars bar = new Bars(SortPage.CreateRectangle(i), new Region(rectangle));
            bars.Add(bar);
        }
        private static void UpdateGraph(int delay)
        {
            //updates panel
            for (int j = 0; j < bars.Count; j++)
            {
                graph.Invalidate(bars[j].Region);
            }
            graph.Update();
            Thread.Sleep(delay);
        }
    }
}
