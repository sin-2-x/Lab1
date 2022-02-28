using Lab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1 {
  class Printer {
    public static List<StringBuilder> PrintBinaryTree(Node node) {
      List<StringBuilder> saveResultString = new List<StringBuilder> {
        new StringBuilder()
      };


      Queue<Node> nodes = new Queue<Node>();
      int depth = Depth(node);
      int numberOfSpaces;
      int numberOfBranchParts;
      int elemPerLevel;
      string levelPrint = "";
      string leftBranch;
      string rightBranch;
      int n = FindMaxData(node);
      nodes.Enqueue(node);
      for (int level = 0; level < depth; level++) {
        numberOfSpaces = (Convert.ToInt32(Math.Pow(2, (depth - 1 - level))) - 1) * n;
        numberOfBranchParts = ((numberOfSpaces / n - 1) / 2) * n;
        elemPerLevel = Convert.ToInt32(Math.Pow(2, level));
        leftBranch = string.Concat(string.Concat(Enumerable.Repeat(" ", n - 1)), "┌", string.Concat(Enumerable.Repeat("─", numberOfBranchParts)));
        rightBranch = string.Concat(string.Concat(Enumerable.Repeat("─", numberOfBranchParts)), "┐", string.Concat(Enumerable.Repeat(" ", n - 1)));
        for (int elemPrint = 0; elemPrint < elemPerLevel; elemPrint++) {
          node = nodes.Dequeue();
          if (node != null) {
            nodes.Enqueue(node.Left);
            nodes.Enqueue(node.Right);
          }
          else {
            nodes.Enqueue(null);
            nodes.Enqueue(null);
          }
          if (node != null) {
            if (node.Left != null) {
              levelPrint = string.Concat(levelPrint, string.Concat(Enumerable.Repeat(" ", numberOfBranchParts)), leftBranch);
            }
            else {
              levelPrint = string.Concat(levelPrint, string.Concat(Enumerable.Repeat(" ", numberOfSpaces)));
            }

            levelPrint = string.Concat(levelPrint, string.Concat(Enumerable.Repeat(" ", n - node.Data.ToString().Length)), node.Data);

            if (node.Right != null) {
              levelPrint = string.Concat(levelPrint, rightBranch, string.Concat(Enumerable.Repeat(" ", numberOfBranchParts)));
            }
            else {
              levelPrint = string.Concat(levelPrint, string.Concat(Enumerable.Repeat(" ", numberOfSpaces)));
            }
            levelPrint = string.Concat(levelPrint, string.Concat(Enumerable.Repeat(" ", n)));
          }
          else {
            levelPrint = string.Concat(levelPrint, string.Concat(Enumerable.Repeat(" ", numberOfSpaces)));
            levelPrint = string.Concat(levelPrint, string.Concat(Enumerable.Repeat(" ", n)));
            levelPrint = string.Concat(levelPrint, string.Concat(Enumerable.Repeat(" ", numberOfSpaces)));
            levelPrint = string.Concat(levelPrint, string.Concat(Enumerable.Repeat(" ", n)));
          }
        }


        saveResultString.Add(new StringBuilder(levelPrint));
        levelPrint = "";
      }
      nodes.Clear();

      bool clear = true;
      for (int element = 0; element < saveResultString.Max(s => s.Length); ++element) {
        for (int stringNumber = 0; stringNumber < saveResultString.Count; stringNumber++) {
          if (saveResultString[stringNumber].Length > element && saveResultString[stringNumber][element] != ' ' && saveResultString[stringNumber][element] != '─') {
            clear = false;
            break;
          }
        }
        if (clear) {
          for (int stringNumber = 0; stringNumber < saveResultString.Count; stringNumber++) {
            if (saveResultString[stringNumber].Length > element)
              saveResultString[stringNumber] = saveResultString[stringNumber].Remove(element, 1);
          }
          element--;
        }
        clear = true;
      }
      return saveResultString;
    }

    public static int Depth(Node node) {
      int depth = 0;
      if (node != null) {
        int leftD = Depth(node.Left);
        int rightD = Depth(node.Right);
        depth = Math.Max(leftD, rightD) + 1;
      }
      return depth;
    }

    public static int FindMaxData(Node node) {

      while (node.Right != null) {
        node = node.Right;
      }
      return node.Data.ToString().Length;
    }
  }
}
