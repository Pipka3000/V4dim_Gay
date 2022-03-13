using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ4
{
    public class Taburet
    {
        public Taburet()
        {

        }

        public int Height;
        private int Leg;
        private string Material;


        public Taburet(int Height, int Leg, string Material)
        {
            if (Height >= 20 && Height <= 60)
            {
                this.Height = Height;
            }
            else
            {
                Console.WriteLine("Кол-во не входит в диапазон");
            }

            if (Leg == 1 || Leg == 2 || Leg == 4)
            {
                this.Leg = Leg;
            }
            else
            {
                Console.WriteLine("Кол-во не входит в диапазон");
            }

            if (Material == "Девево" || Material == "Пластик" || Material == "Металл")
            {
                this.Material = Material;
            }
            else
            {
                Console.WriteLine("Материал не вхордит в перечень");
            }
        }


        //Высота сидушки
        public void SetHeight(int Height)
        {
            if (Height >= 20 && Height <= 60)
            {
                this.Height = Height;
            }
            else
            {
                Console.WriteLine("Кол-во не входит в диапазон");
            }
        }
        public void PrintHeight()
        {
            Console.WriteLine("Размер сидушки = " + Height + " см");
        }

        //Количество ножек
        public void SetLeg(int Leg)
        {
            if (Leg == 1 || Leg == 3 || Leg == 4)
            {
                this.Leg = Leg;
            }
            else
            {
                Console.WriteLine("Кол-во не входит в диапазон");
            }
        }
        public void PrintLeg()
        {
            Console.WriteLine("Количество ножек = " + Leg);
        }

        //Вид материала изделия
        public void GetMaterial(string Material)
        {
            if (Material == "Дерево" || Material == "Пластик" || Material == "Металл")
            {
                this.Material = Material;
            }
            else
            {
                Console.WriteLine("Материал не вхордит в перечень");
            }
        }
        public void PrintMaterial()
        {
            Console.WriteLine("Материал изделия = " + Material);
        }


    }
}
