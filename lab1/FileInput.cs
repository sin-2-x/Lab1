using Lab1.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Properties {
  public class FileInput : Input {
    public override int[] input(string inputStr) {
      StringBuilder oneNumInStr = new StringBuilder();    //Строка с числами для перегонки в int
      List<int> intArrayList = new List<int>();      //Временный массив с числами

      for (int i = 0; i < inputStr.Length; i++) {
        if (inputStr.ElementAt(i) <= '9' && inputStr.ElementAt(i) >= '0' || inputStr.ElementAt(i) == '-') {
          oneNumInStr.Append(inputStr.ElementAt(i).ToString());
        }
        else if (oneNumInStr.Length > 0) {
          string a = oneNumInStr.ToString();
          int b = int.Parse(a);
          intArrayList.Add(b);
          oneNumInStr.Clear();
        }

      }
      if (oneNumInStr.Length > 0) {
        intArrayList.Add(int.Parse(oneNumInStr.ToString()));
        //System.out.println(Integer.valueOf(oneNumInStr.toString()));
        oneNumInStr.Clear();
      }

      int[] clearArr = intArrayList.ToArray(); // Преобразование в массив из списка

      return clearArr;
    }
  }
}
