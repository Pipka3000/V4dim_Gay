using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ4
{
    internal class Spinka:Taburet
    {
        public int Height_Spinka;

        public void SetHeight_Spinka(int Height_Spinka, int Height)
        {
            if (Height_Spinka >= Height * 0.5 && Height_Spinka <= Height) 
            {
                this.Height_Spinka = Height_Spinka;
                this.Height = Height;
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
    }
}
