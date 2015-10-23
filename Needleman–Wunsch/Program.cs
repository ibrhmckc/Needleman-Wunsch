using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Needleman_Wunsch
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string yol=@"C:\Users\Halil\Desktop\Needleman–Wunsch\Needleman–Wunsch\dosya.txt";
            DosyadanOku dO = new DosyadanOku(yol);
            for (int i = 0; i < dO.Sayac0; i++)
            {
                for (int j = 0; j < dO.Sayac4; j++)
                {
                     NeedlemannWunsch nw = new NeedlemannWunsch(dO.Kisi0[i].ToString(), dO.Kisi4[j].ToString(),dO.Sayac0,dO.Sayac4,dO.UyusmaSkoru,dO.UyusmamaSkoru,dO.BoslukSkoru);
                }
            }
           
            //Console.WriteLine(dO.Kisi0[0]);
            
            Console.ReadKey();
            
        }

     
    }
}
