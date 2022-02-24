using Lab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1 {
  class Printer {
    public static List<StringBuilder> PrintBinaryTree(Node root) {
      List<StringBuilder> saveResultString = new List<StringBuilder> {
        new StringBuilder()
      };

      LinkedList<Node> treeLevel = new LinkedList<Node>();
      treeLevel = new LinkedList<Node>(treeLevel.Append(root));
      //treeLevel.Add(root);
      LinkedList<Node> temp = new LinkedList<Node>();
      int counter = 0;
      int height = HeightOfTree(root) - 1;
      double numberOfElements = (Math.Pow(2, (height + 1)) - 1);

      while (counter <= height) {
        Node removed = treeLevel.First();
        //treeLevel.RemoveFirst();
        treeLevel.Remove(treeLevel.First());
        if (temp.Count == 0) {
          PrintSpace(numberOfElements / Math.Pow(2, counter + 1), removed, ref saveResultString);
        }
        else {
          PrintSpace(numberOfElements / Math.Pow(2, counter), removed, ref saveResultString);
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
          saveResultString.Add(new StringBuilder());
          treeLevel = new LinkedList<Node>(temp);
          temp.Clear();
          counter++;
        }

      }
      return saveResultString;
    }

    public static void PrintSpace(double n, Node removed, ref List<StringBuilder> saveResultString) {
      for (; n > 0; n--) {
        Console.Write("    ");
        saveResultString.ElementAt(saveResultString.Count - 1).Append("    ");
      }
      if (removed == null) {
        Console.Write(" ");
        saveResultString[saveResultString.Count - 1].Append(" ");
      }
      else {
        Console.Write(removed.Data);
        saveResultString[saveResultString.Count - 1].Append(removed.Data);
      }
    }

    public static int HeightOfTree(Node root) {
      if (root == null) {
        return 0;
      }
      return 1 + Math.Max(HeightOfTree(root.Left), HeightOfTree(root.Right));
    }
  }
}
