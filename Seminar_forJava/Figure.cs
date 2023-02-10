using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seminar_forJava
{
     abstract class Figure
    {
      protected int size;
      public Figure(int s) {
        size = s;
      }
      public void show(){
        Console.WriteLine($"Фигура: {getName()}");
        Console.WriteLine($"Размер({getSizeName()}): {size}");
        Console.WriteLine($"Площадь: {getArea():f3}");
        Console.WriteLine();
      }
      public string getSizeName() {
        return "сторона";
      }
      public void set(int s){
        size = s;
      }
      public int get(){
        return size;
      }
      public abstract string getName();
      public abstract double getArea();
    }
}