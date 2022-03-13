using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Taburet first = new Taburet();
            //Высота сидушки
            first.SetHeight(22);
            first.PrintHeight();
            //Кол-во ножек
            first.SetLeg(4);
            first.PrintLeg();
            //Вид материала
            first.GetMaterial("Дерево");
            first.PrintMaterial();
            //Высота спинки
            Spinka second = new Spinka();
            second.SetHeight_Spinka();
            second.PrintHeight_Spinka();


            Console.ReadLine();
        }
    }
}
