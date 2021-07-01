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
    class BubbleSort
    {
        public static void Sort(int[] nums, PictureBox graph, List<Bars> bars)
        {
            //Reads = Writes = Comparisons = 0;
            bool swapped = true;                       //checks if swapped in last pass
            for (int passes = 0; passes < nums.Length && swapped == true; passes++)
            {
                swapped = false;
                for (int i = 0; i < nums.Length - 1 - passes; i++)
                {
                    SortPage.Reads+=2;
                    SortPage.UpdateReadLbl();
                    SortPage.Comparisons++;
                    SortPage.UpdateComparisonLbl();
                    if (nums[i] > nums[i + 1])
                    {

                        Swap(nums, i, i + 1); //swaps value if in wrong order
                        swapped = true; //swapped, so true

                        //adds bars that were swapped
                        AddSwapBar(i, bars);
                        AddSwapBar(i + 1, bars);

                        //uses bars to update graph
                        UpdateGraph(bars, graph, SortPage.Delay);
                        UpdateGraph(bars, graph, 0);
                    }
                }
            }
        }
        private static void AddSwapBar(int i, List<Bars> bars)
        {
            RectangleF rectangle = new RectangleF(new PointF(i * SortPage.WidthConstant, 0),
                                                  new SizeF(SortPage.WidthConstant, 9999));
            Bars bar = new Bars(SortPage.CreateRectangle(i), new Region(rectangle));
            bars.Add(bar);
        }
        private static void UpdateGraph(List<Bars> bars, PictureBox graph, int delay)
        {
            for (int j = 0; j < bars.Count; j++)
            {
                graph.Invalidate(bars[j].Region);
            }
            graph.Update();
            Thread.Sleep(delay);
        }
        private static void Swap(int[] nums, int a, int b)
        {
            int temp = nums[a];
            nums[a] = nums[b];
            nums[b] = temp;
            SortPage.Writes += 2;
            SortPage.UpdateWriteLbl();
        }
    }
}
