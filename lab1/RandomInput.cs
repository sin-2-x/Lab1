using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Properties {
  public class RandomInput : Input {

    public override int[] input(string inputStr) {
      int size = int.Parse(inputStr);
      List<int> arr = new List<int>();
      //Создание объекта для генерации чисел
      Random rnd = new Random();


      for (int i = 0; i < size; i++) {
        //Получить случайное число (в диапазоне от 0 до 10)
        int nextNodeValue = rnd.Next(0, 500);
        while (arr.Contains(nextNodeValue))
          nextNodeValue = rnd.Next(0, 500);
        arr.Add(nextNodeValue);
      }
      return arr.ToArray();
    }
  }
}


