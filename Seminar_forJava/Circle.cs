using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seminar_forJava
{
    class Circle : Figure
    {
        public Circle(int s):base(s){ }
        public override string getName(){
            return "круг";
        }
        public override double getArea(){
            double k = Math.PI;
            return size*size*k;
        }
        new public string getSizeName(){
            return "радиус";
        }


    }
}