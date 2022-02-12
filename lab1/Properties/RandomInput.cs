﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Properties
{
    public class RandomInput : Input
    {

        public override int[] input(string inputStr)
        {
            int size = int.Parse(inputStr);
            int[] arr = new int[size];
            //Создание объекта для генерации чисел
            Random rnd = new Random();

            
            for (int i = 0; i < size; i++)
            {
                //Получить случайное число (в диапазоне от 0 до 10)

                arr[i] = rnd.Next(0, 100);
            }
            return arr;
        }
    }
}

/*
 public class RandomInput extends Input{
    @Override
     public int[] input(String inputStr){
        int size = Integer.parseInt(inputStr);
        int[] arr = new int[size];
        for (int i = 0; i<size; i++){
            arr[i] = (int)(Math.random()*i*60 - Math.random()*i*60);
        }
        return arr;
    }
}
 */