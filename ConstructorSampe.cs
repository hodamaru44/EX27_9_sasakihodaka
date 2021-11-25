using System;
using ConsoleUtility;

namespace ConstructorSampe
{
    class ConstructorSampeMain
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(
                 InteractiveInput.InputFloat("幅："),
                 InteractiveInput.InputFloat("高さ："));
            Console.WriteLine($"面積は{triangle.GetArea()}");
            Triangle triangleedge = new Triangle(
                 InteractiveInput.InputFloat("辺A："),
                 InteractiveInput.InputFloat("辺B："),
                 InteractiveInput.InputFloat("辺C："));
            Console.WriteLine($"辺は" + Math.Sqrt(triangleedge.GetHeronsFormula()));
        }
    }
}
