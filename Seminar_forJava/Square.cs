using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seminar_forJava
{
    class Square:Figure
    {
      public Square(int s) : base(s) { }
      public override string getName(){
         return "квадрат";
      }
      public override double getArea(){
        double k = 1;
        return size*size*k;
      }
    }
}