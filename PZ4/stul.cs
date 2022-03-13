using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ4
{
    public class stul:Taburet
    {
        protected int Height_Spinka;

        public void SetHeight_Spinka(int Height_Spinka)
        {
            if (Height_Spinka >= Height * 0.5 && Height_Spinka <= Height)
            {
                this.Height_Spinka = Height_Spinka;
                
            }
            else
            {
                Console.WriteLine("Кол-во не входит в диапазон");
            }
        }
        public void PrintHeight_Spinka()
        {
            Console.WriteLine("Размер сидушки = " + Height_Spinka + " см");
        }
        public override void PrintObj()
        {
            Console.WriteLine(
                "Высота: " + Height +
                "| ножек: " + Leg +
                "| Материал: " + Material+
                "| Высота спинки: " + Height_Spinka
                );
        }
    }
}
