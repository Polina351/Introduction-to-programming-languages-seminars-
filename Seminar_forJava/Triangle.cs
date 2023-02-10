using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seminar_forJava
{
    class Triangle : Figure
    {
        public Triangle(int s):base(s){ }
        public override string getName(){
            return "треугольник";
        }
        public override double getArea(){
            double k = Math.Sqrt(3)/4;
            return size*size*k;
        }
    }
}