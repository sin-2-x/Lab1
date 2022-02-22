using Lab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1 {
  class Printer {
    public static void printBinaryTree(Node root, ref List<string> saveResultString) {
      LinkedList<Node> treeLevel = new LinkedList<Node>();
      treeLevel = new LinkedList<Node>(treeLevel.Append(root));
      LinkedList<Node> temp = new LinkedList<Node>();
      int counter = 0;
      int height = heightOfTree(root) - 1;
      double numberOfElements = (Math.Pow(2, (height + 1)) - 1);

      while (counter <= height) {
        Node removed = treeLevel.First();
        treeLevel.RemoveFirst();
        if (temp.Count == 0) {
          printSpace(numberOfElements / Math.Pow(2, counter + 1), removed, ref saveResultString);
        }
        else {
          printSpace(numberOfElements / Math.Pow(2, counter), removed, ref saveResultString);
        }
        if (removed == null) {
          temp = new LinkedList<Node>(temp.Append(null));
          temp = new LinkedList<Node>(temp.Append(null));
        }
        else {
          temp = new LinkedList<Node>(temp.Append(removed.Left));
          temp = new LinkedList<Node>(temp.Append(removed.Right));
        }

        if (treeLevel.Count == 0) {
          //Console.WriteLine("");
          Console.WriteLine("");
          saveResultString.Add("");
          treeLevel = new LinkedList<Node>(temp);
          temp.Clear();
          counter++;
        }

      }
    }

    public static void printSpace(double n, Node removed, ref List<string> saveResultString) {
      for (; n > 0; n--) {
        Console.Write("    ");
        saveResultString[saveResultString.Count - 1] += "    ";
      }
      if (removed == null) {
        Console.Write(" ");
        saveResultString[saveResultString.Count - 1] += " ";
      }
      else {
        Console.Write(removed.Data);
        saveResultString[saveResultString.Count - 1] += removed.Data;
      }
    }

    public static int heightOfTree(Node root) {
      if (root == null) {
        return 0;
      }
      return 1 + Math.Max(heightOfTree(root.Left), heightOfTree(root.Right));
    }
  }
}
