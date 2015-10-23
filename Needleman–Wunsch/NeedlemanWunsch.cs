using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Needleman_Wunsch
{
    public class NeedlemannWunsch
    {
        int komsuUst;
        int komsuSol;
        int komsuCapraz;
        char[] koordinat1;
        char[] koordinat2;
        int[,] atamaMatris;
        int UyusmaSkoru;
        int UyusmamaSkoru;
        int BoslukSkoru;
        string kissi1;
        string kissi2;
        int sayacc1, sayacc2;
        string HizalamaSatir;
        char[] hizalanmisSatir;
        char[] hizalanmisSutun;
        string HizalamaSutun;

        public NeedlemannWunsch() { }
        public NeedlemannWunsch(string kisi1, string kisi2, int sayac1, int sayac2, int uyusmaSkoru, int uyusmamaSkoru, int boslukSkoru)
        {
            UyusmaSkoru = uyusmaSkoru;
            UyusmamaSkoru = uyusmamaSkoru;
            BoslukSkoru = boslukSkoru;
            kissi1 = kisi1;
            kissi2 = kisi2;
            sayacc1 = sayac1;
            sayacc2 = sayac2;



            islemYap(kissi1, kissi2);




        }
        public void HizaYazdir(string hizalaSat, string hizalaSut)
        {
            Console.WriteLine(HizalamaSatir);
            Console.WriteLine(HizalamaSutun);
        }
        public void islemYap(string kisii1, string kisii2)
        {
            string kkisi1 = kisii1;
            string kkisi2 = kisii2;
            matriseElemanAta(kkisi1, kkisi2);
            komsuluklaraGoreDeger();

        }

        private void komsuluklaraGoreDeger()
        {
            int fark = 0;
            for (int i = 2; i < koordinat1.Length + 2; i++)
            {
                for (int j = 2; j < koordinat2.Length + 2; j++)
                {





                    if (atamaMatris[i, 0] == atamaMatris[0, j])
                    {
                        komsuCapraz = atamaMatris[i - 1, j - 1] + UyusmaSkoru;
                        // atamaMatris[i, j] += UyusmaSkoru;
                    }

                    else
                    {
                        komsuCapraz = atamaMatris[i - 1, j - 1] + UyusmamaSkoru;
                    }
                    //if (atamaMatris[i - 1, j] > atamaMatris[i, j - 1])
                    komsuUst = atamaMatris[i - 1, j] + BoslukSkoru;
                    // else
                    komsuSol = atamaMatris[i, j - 1] + BoslukSkoru;

                    if (komsuSol > komsuUst && komsuSol > komsuCapraz)
                        atamaMatris[i, j] = komsuSol;
                    else if (komsuUst > komsuSol && komsuUst > komsuCapraz)
                        atamaMatris[i, j] = komsuUst;
                    else if (komsuCapraz > komsuUst && komsuCapraz > komsuSol)
                        atamaMatris[i, j] = komsuCapraz;
                    else if (komsuSol == komsuUst && komsuSol > komsuCapraz)
                    {
                        atamaMatris[i, j] = komsuSol;
                    }
                    else if (komsuSol == komsuCapraz && komsuUst < komsuCapraz)
                    {
                        atamaMatris[i, j] = komsuCapraz;
                    }
                    else if (komsuUst == komsuCapraz && komsuSol < komsuCapraz)
                    {
                        atamaMatris[i, j] = komsuUst;
                    }
                    else if (komsuUst == komsuSol && komsuSol == komsuCapraz)
                    {

                        atamaMatris[i, j] = komsuUst;
                    }


                }












            }
            //int k = koordinat1.Length + 1;
            //int t = koordinat2.Length  +1;

            //while (k > 1 && t > 1)
            //{
            //    if (atamaMatris[k, t] == atamaMatris[k - 1, t - 1] + UyusmaSkoru || atamaMatris[k, t] == atamaMatris[k - 1, t - 1] + UyusmamaSkoru)
            //    {

            //        HizalamaSatir = kissi2[t- 2] + HizalamaSatir;
            //        HizalamaSutun = kissi1[k - 2] + HizalamaSutun;
            //        k -= 1;
            //        t -= 1;
            //    }
            //    else if (atamaMatris[k, t] == atamaMatris[k, t - 1] + BoslukSkoru)
            //    {
            //        HizalamaSatir = "-" + HizalamaSatir;
            //        HizalamaSutun = kissi1[k - 2] + HizalamaSutun;
            //        k -= 1;
            //    }
            //    else
            //    {
            //        HizalamaSatir = kissi2[t - 2] + HizalamaSatir;
            //        HizalamaSutun = "-" + HizalamaSutun;
            //        t -= 1;
            //    }

            //}
            //HizaYazdir(HizalamaSatir, HizalamaSutun);
            int k = koordinat1.Length + 1;
            int t = koordinat2.Length + 1;
            while (k > 1 && t > 1)
            {

                //HizalamaSatir = koordinat1[koordinat1.Length - 1].ToString() + HizalamaSatir;//koordinat2.Length - j - 1);
                //HizalamaSutun = koordinat2[koordinat2.Length - 1].ToString() + HizalamaSutun;

                if (atamaMatris[k, t] == atamaMatris[k, t - 1] + BoslukSkoru) {
                    
                    HizalamaSutun = koordinat2[t - 2] + HizalamaSutun;
                    HizalamaSatir = "-" + HizalamaSatir;
                    t--;
                }
                else if (atamaMatris[k, t] == atamaMatris[k-1, t ] + BoslukSkoru)
                {
                    
                    HizalamaSatir = koordinat1[k- 2] + HizalamaSatir;
                    HizalamaSutun = "-" + HizalamaSutun;
                    k--;

                }
                else if (atamaMatris[k, t] == (atamaMatris[k - 1, t - 1] + UyusmaSkoru) || atamaMatris[k, t] == (atamaMatris[k - 1, t - 1] + UyusmamaSkoru))
                {
                    HizalamaSatir = koordinat1[k - 2] + HizalamaSatir;
                    HizalamaSutun = koordinat2[t - 2] + HizalamaSutun;
                    k--;
                    t--;

                }

            }


            Console.WriteLine(HizalamaSatir);
            Console.WriteLine(HizalamaSutun);



            if (koordinat1.Length > koordinat2.Length)
            {
                for (int i = 0; i < koordinat1.Length + 2; i++)
                {
                    for (int j = 0; j < koordinat1.Length + 2; j++)
                    {
                        Console.Write("\t" + atamaMatris[i, j]);

                    }
                    Console.WriteLine();
                    Console.WriteLine();


                }
                Console.WriteLine();
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < koordinat2.Length + 2; i++)
                {
                    for (int j = 0; j < koordinat2.Length + 2; j++)
                    {
                        Console.Write("\t" + atamaMatris[i, j]);

                    }
                    Console.WriteLine();
                    Console.WriteLine();


                }
                Console.WriteLine();
                Console.WriteLine();
            }

        }
        private void matriseElemanAta(string kisii1, string kisii2)
        {
            basamaklarinaAyir(kisii1, kisii2);
            if (koordinat1.Length > koordinat2.Length)
                atamaMatris = new int[koordinat1.Length + 2, koordinat1.Length + 2];
            else
                atamaMatris = new int[koordinat2.Length + 2, koordinat2.Length + 2];
            for (int i = 2; i < koordinat1.Length + 2; i++)
            {

                atamaMatris[i, 0] = Convert.ToInt32(koordinat1[i - 2].ToString());
                atamaMatris[i, 1] = -i + 1;
                atamaMatris[1, 1] = 0;

            }
            for (int j = 2; j < koordinat2.Length + 2; j++)
            {
                atamaMatris[0, j] = Convert.ToInt32(koordinat2[j - 2].ToString());

                atamaMatris[1, j] = -j + 1;
            }
            //for (int i = 0; i < koordinat1.Length + 2; i++)
            //{
            //    for (int j = 0; j < koordinat2.Length + 2; j++)
            //    {
            //        Console.Write("\t" + atamaMatris[i, j]);

            //    }
            //    Console.WriteLine();
            //    Console.WriteLine();


            //}
            //Console.WriteLine();
            //Console.WriteLine();
        }

        private void basamaklarinaAyir(string kisii1, string kisii2)
        {
            koordinat1 = kisii1.ToCharArray();
            koordinat2 = kisii2.ToCharArray();

        }
    }
}
