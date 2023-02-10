
namespace Seminar_forJava
{
    class Program
    {
        static void Main(){
            Figure triangle = new Triangle(2);
            Figure square = new Square(3);
            Figure circle = new Circle(2);

            triangle.show();
            square.show();
            circle.show();
        }
    }
}
