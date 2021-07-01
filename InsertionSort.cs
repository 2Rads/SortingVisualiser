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
    class InsertionSort
    {
        public static void Sort(int[] nums, PictureBox graph, List<Bars> bars)
        {
            //passes through each index
            for (int i = 1; i < nums.Length; i++)
            {
                int temp = nums[i];             //value will be overridden, so temp store
                SortPage.Reads++;
                SortPage.UpdateReadLbl();
                int pointer = i;                //position where current value will be inserted

                //checks values are in range and in order
                SortPage.Comparisons++;
                SortPage.UpdateComparisonLbl();
                for (; pointer > 0 && temp < nums[pointer - 1]; pointer--)
                {
                    nums[pointer] = nums[pointer - 1];  //copies value to the right index
                    SortPage.Comparisons++;
                    SortPage.UpdateComparisonLbl();
                    SortPage.Writes++;
                    SortPage.UpdateWriteLbl();
                    SortPage.Reads+=2;
                    SortPage.UpdateReadLbl();
                    AddSwapBar(pointer, bars);
                    UpdateGraph(SortPage.Delay, graph, bars);
                }
                nums[pointer] = temp;                   //reinserts value, replacing duplicate
                SortPage.Writes++;
                SortPage.UpdateWriteLbl();
                AddSwapBar(pointer, bars);
                UpdateGraph(SortPage.Delay, graph, bars);

            }
            UpdateGraph(0, graph, bars);
        }
        private static void AddSwapBar(int i, List<Bars> bars)
        {
            RectangleF rectangle = new RectangleF(new PointF(i * SortPage.WidthConstant, 0)
                                                , new SizeF(SortPage.WidthConstant, 9999));
            Bars bar = new Bars(SortPage.CreateRectangle(i), new Region(rectangle));
            bars.Add(bar);
        }
        private static void UpdateGraph(int delay, PictureBox graph, List<Bars> bars)
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
