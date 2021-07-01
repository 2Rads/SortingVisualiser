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
    class MergeSort
    {
        private static int[] nums;
        private static PictureBox graph;
        private static List<Bars> bars;
        public static void Sort(int[] numbers, PictureBox box, List<Bars> barsList)
        {
            graph = box;
            nums = numbers;                         //passed by reference
            bars = barsList;                        //accessible anywhere in class
            //split is entire array length
            Split(0, nums.Length - 1);
        }
        public static void Split(int start, int end)
        {
            if (start < end)
            {                                       //condition to end recurtion
                int mid = (start + end) / 2;        //get middle value
                Split(start, mid);
                Split(mid + 1, end);                //splits into half1 and half2
                Merge(start, mid, end);             //merges both sets
            }
        }

        public static void Merge(int start, int mid, int end)
        {
            int half1len = mid - start + 1;
            int half2len = end - mid;

            int[] half1 = new int[half1len];        //initialses new arrays
            int[] half2 = new int[half2len];        //will merge in main array

            //assigns a copy of the valuse in the range
            for (int i = 0; i < half1len; i++)
            {
                half1[i] = nums[start + i];
                SortPage.Reads++;
                SortPage.UpdateReadLbl();
            }
            for (int i = 0; i < half2len; i++)
            {
                half2[i] = nums[mid + i + 1];
                SortPage.Reads++;
                SortPage.UpdateReadLbl();
            }

            int Half1Index = 0;                      //start index of half1
            int Half2Index = 0;                      //start index of half2

            while (Half1Index < half1len && Half2Index < half2len)
            {                                        //while either index is less than length of its array
                SortPage.Comparisons++;
                SortPage.UpdateComparisonLbl();                                
                if (half1[Half1Index] < half2[Half2Index])
                {
                    nums[start + Half1Index + Half2Index] = half1[Half1Index];
                    SortPage.Writes++;
                    SortPage.UpdateWriteLbl();
                    AddMergedBar(start + Half1Index + Half2Index);
                    UpdateGraph(SortPage.Delay);
                    Half1Index++;
                }                                 //adds the smaller value to nums, then increments
                else
                {
                    nums[start + Half1Index + Half2Index] = half2[Half2Index];
                    SortPage.Writes++;
                    SortPage.UpdateWriteLbl();
                    AddMergedBar(start + Half1Index + Half2Index);
                    UpdateGraph(SortPage.Delay);
                    Half2Index++;
                }
            }

            while (Half1Index < half1len)
            {          //some may be left, so it will add them
                nums[start + Half1Index + Half2Index] = half1[Half1Index];
                SortPage.Writes++;
                SortPage.UpdateWriteLbl();
                AddMergedBar(start + Half1Index + Half2Index);
                UpdateGraph(SortPage.Delay);
                Half1Index++;
            }

            while (Half2Index < half2len)
            {         //some may be left, so it will add them
                nums[start + Half1Index + Half2Index] = half2[Half2Index];
                SortPage.Writes++;
                SortPage.UpdateWriteLbl();
                AddMergedBar(start + Half1Index + Half2Index);
                UpdateGraph(SortPage.Delay);
                Half2Index++;
            }
            UpdateGraph(0);
        }
        private static void AddMergedBar(int i)
        {
            RectangleF rectangle = new RectangleF(new PointF(i * SortPage.WidthConstant, 0), new SizeF(SortPage.WidthConstant, 9999));
            Bars bar = new Bars(SortPage.CreateRectangle(i), new Region(rectangle));
            bars.Add(bar);
        }
        private static void UpdateGraph(int delay)
        {

            for (int j = 0; j < bars.Count; j++)
            {
                graph.Invalidate(bars[j].Region);
            }
            graph.Update();
            Thread.Sleep(delay);
        }
    }
}
