using System;
using System.Diagnostics;

namespace SortingAlgorithmTime
{
    class TreeSort
    {
        private static Tree node;                                      //private so only accessible in this class
        private static int[] nums;
        public static void Sort(int[] numbers)
        {
            nums = new int[numbers.Length];
            for (int num = 0; num < numbers.Length; num++)
            {
                nums[num] = numbers[num];
            }
            Stopwatch StopWatch = new Stopwatch();                     //create and start timer
            StopWatch.Start();

            node = new Tree(nums[0]); //assigns first array value as root node

            for (int i = 1; i < nums.Length; i++)
            {
                AddNode(nums[i]);    //adds a new node, 1 by 1
            }

            StopWatch.Stop();                                          //stops timer
            TimeSpan time = StopWatch.Elapsed;
            Console.Write("\n" + time.TotalMilliseconds + "    ");     //output time

            //Traverse(node);                                            //prints out values
        }

        private static void AddNode(int value)
        {
            Tree temp = node;                                          //node to replace root node so it's not lost.
            while (true)
            {
                if (value < temp.Value)                                //repeats until added
                {
                    if (temp.Left == null)                             //checks not empty
                    {  
                        temp.Left = new Tree(value);
                        return;                                       //added, so now can return
                    }
                    else
                    {
                        temp = temp.Left;                             //repeates with left node
                    }
                }
                else
                {                                                     //greater than or equal
                    if (temp.Right == null)
                    {
                        temp.Right = new Tree(value);
                        return;
                    }
                    else
                    {
                        temp = temp.Right;
                    }
                }
            }
        }

        private static void Traverse(Tree tree)
        {
            if (tree.Left != null)                                    //checkes left is assigned
            {    
                Traverse(tree.Left);                                  //then visits that node if not
            }
            Console.Write(tree.Value + " ");                          //then writes this value
            if (tree.Right != null)                                   //repeats with right side
            {  
                Traverse(tree.Right);
            }
        }
    }

    class Tree
    {
        public int Value;
        public Tree Left;
        public Tree Right;

        public Tree(int val)
        {
            Value = val;
        }
    }
}
