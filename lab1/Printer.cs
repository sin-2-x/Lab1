using Lab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Printer
    {
        public static void printBinaryTree(BinaryTree root, ref List<string> saveResultString)
        {
            LinkedList<BinaryTree> treeLevel = new LinkedList<BinaryTree>();
            treeLevel = new LinkedList<BinaryTree>(treeLevel.Append(root));
            LinkedList<BinaryTree> temp = new LinkedList<BinaryTree>();
            int counter = 0;
            int height = heightOfTree(root) - 1;
            //Console.WriteLine(height);
            double numberOfElements = (Math.Pow(2, (height + 1)) - 1);
            //Console.WriteLine(numberOfElements);
            while (counter <= height)
            {
                BinaryTree removed = treeLevel.First();
                    treeLevel.RemoveFirst();
                if (temp.Count==0)
                {
                    printSpace(numberOfElements / Math.Pow(2, counter + 1), removed, ref saveResultString);
                }
                else
                {
                    printSpace(numberOfElements / Math.Pow(2, counter), removed, ref saveResultString);
                }
                if (removed == null)
                {
                    temp = new LinkedList<BinaryTree>(temp.Append(null));
                    temp = new LinkedList<BinaryTree>(temp.Append(null));
                }
                else
                {
                    temp = new LinkedList<BinaryTree>(temp.Append(removed.Left));
                    temp = new LinkedList<BinaryTree>(temp.Append(removed.Right));
                }

                if (treeLevel.Count==0)
                {
                    //Console.WriteLine("");
                    Console.WriteLine("");
                    saveResultString.Add("");
                    treeLevel = new LinkedList<BinaryTree>(temp);
                    temp.Clear();
                    counter++;
                }

            }
        }

        public static void printSpace(double n, BinaryTree removed, ref List<string> saveResultString)
        {
            for (; n > 0; n--)
            {
                Console.Write("    ");
                saveResultString[saveResultString.Count-1] += "    ";
            }
            if (removed == null)
            {
                Console.Write(" ");
                saveResultString[saveResultString.Count - 1] += " ";
            }
            else
            {
                Console.Write(removed.Data);
                saveResultString[saveResultString.Count - 1] += removed.Data;
            }
        }

        public static int heightOfTree(BinaryTree root)
        {
            if (root == null)
            {
                return 0;
            }
            return 1 + Math.Max(heightOfTree(root.Left), heightOfTree(root.Right));
        }
    }
}
