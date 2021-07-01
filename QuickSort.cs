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
    class QuickSort
    {
        private static int[] nums;
        private static PictureBox graph;
        private static List<Bars> bars;
        public static void Sort(int[] numbers, PictureBox box, List<Bars> barsList)
        {
            //copies numbers to nums
            graph = box;
            nums = numbers;
            bars = barsList;

            //split is entire array length
            Split(0, nums.Length - 1);
        }
        public static void Split(int start, int end)
        {
            if (start < end)
            {                                       //condition to end recurtion
                int lastpivot = Pivot(start, end);  //return final position of pivot
                AddPivotBar(lastpivot);
                UpdateGraph(0);
                Split(start, lastpivot - 1);        //repeats Pivoting on left
                Split(lastpivot + 1, end);          //repeats Pivoting on right
            }
        }
        public static int Pivot(int start, int end)
        {
            SortPage.Reads++;
            SortPage.UpdateReadLbl();
            int PivotValue = nums[end];             //gets value of pivot
            int lastswap = start;                   //index to swap when smaller than pivot

            for (int i = start; i < end; i++)
            {
                SortPage.Reads++;
                SortPage.UpdateReadLbl();
                SortPage.Comparisons++;
                SortPage.UpdateComparisonLbl();
                if (nums[i] < PivotValue)
                {                                   //if less than pivot
                    Swap(i, lastswap);              //swaps with pointer
                    lastswap++;                     //left of lastswap is less than pivot
                }
            }
            Swap(lastswap, end);                    //moves pivot into the correct place
            return lastswap;
        }

        private static void Swap(int a, int b)
        {
            int temp = nums[a];
            nums[a] = nums[b];
            nums[b] = temp;

            SortPage.Writes += 2;
            SortPage.UpdateWriteLbl();
            AddSwapBar(a);
            AddSwapBar(b);
            UpdateGraph(SortPage.Delay);
            UpdateGraph(0);
        }

        private static void AddSwapBar(int i)
        {
            RectangleF rectangle = new RectangleF(new PointF(i * SortPage.WidthConstant, 0),
                                                  new SizeF(SortPage.WidthConstant, 9999));
            Bars bar = new Bars(SortPage.CreateRectangle(i), new Region(rectangle));
            bars.Add(bar);
        }
        private static void AddPivotBar(int i)
        {
            RectangleF rectangle = new RectangleF(new PointF(i * SortPage.WidthConstant, 0),
                                                  new SizeF(SortPage.WidthConstant, 9999));
            Bars bar = new Bars(SortPage.CreateRectangle(i),
                                Color.FromArgb(255, 153, 255, 51) ,new Region(rectangle));
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
