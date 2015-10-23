using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class DosyadanOku
{
    int sayac = 0;

    private int uyusmaSkoru = 0;
    private int uyusmamaSkoru = 0;
    private int boslukSkoru = 0;
    int sayac0 = 0;
    int sayac4 = 0;
    int sayac5 = 0;
    int sayac1338 = 0;

    public int Sayac1338
    {
        get { return sayac1338; }
        set { sayac1338 = value; }
    }
    public int Sayac5
    {
        get { return sayac5; }
        set { sayac5 = value; }
    }


    public int Sayac4
    {
        get { return sayac4; }
        set { sayac4 = value; }
    }

    public int Sayac0
    {
        get { return sayac0; }
        set { sayac0 = value; }
    }


    public int BoslukSkoru
    {
        get { return boslukSkoru; }
        set { boslukSkoru = value; }
    }

    public int UyusmaSkoru
    {
        get { return uyusmaSkoru; }
        set { uyusmaSkoru = value; }
    }


    public int UyusmamaSkoru
    {
        get { return uyusmamaSkoru; }
        set { uyusmamaSkoru = value; }
    }

    ArrayList kisi0 = new ArrayList();

    public ArrayList Kisi0
    {
        get { return kisi0; }
        set { kisi0 = value; }
    }
    ArrayList kisi4 = new ArrayList();


    public ArrayList Kisi4
    {
        get { return kisi4; }
        set { kisi4 = value; }
    }
    ArrayList kisi5 = new ArrayList();

    public ArrayList Kisi5
    {
        get { return kisi5; }
        set { kisi5 = value; }
    }
    ArrayList kisi1338 = new ArrayList();

    public ArrayList Kisi1338
    {
        get { return kisi1338; }
        set { kisi1338 = value; }
    }

    public DosyadanOku() { }

    public DosyadanOku(string yol)
    {

        FileStream fs = new FileStream(yol, FileMode.Open, FileAccess.Read);
        StreamReader sw = new StreamReader(fs);
        // ArrayList inputlar = new ArrayList();
        string satir;
        while ((satir = sw.ReadLine()) != null)
        {
            //char[] karakterler = satir.ToCharArray();
            if (sayac > 2)
            {

                if (Convert.ToInt32(satir.Substring(0, satir.IndexOf(' '))) == 0)
                {
                    kisi0.Add(satir.Substring(satir.IndexOf(' ') + 1));
                    sayac0++;
                }

                else if (Convert.ToInt32(satir.Substring(0, satir.IndexOf(' '))) == 4)
                {
                    kisi4.Add(satir.Substring(satir.IndexOf(' ') + 1));
                    sayac4++;
                }

                else if (Convert.ToInt32(satir.Substring(0, satir.IndexOf(' '))) == 5)
                {
                    kisi5.Add(satir.Substring(satir.IndexOf(' ') + 1));
                    sayac5++;
                }

                else if (Convert.ToInt32(satir.Substring(0, satir.IndexOf(' '))) == 1338)
                {
                    kisi1338.Add(satir.Substring(satir.IndexOf(' ') + 1));
                    sayac1338++;
                }

            }
            else
            {
                if (sayac == 0)
                    uyusmaSkoru = Convert.ToInt32(satir);
                else if (sayac == 1)
                    uyusmamaSkoru = Convert.ToInt32(satir);
                else if (sayac == 2)
                    boslukSkoru = Convert.ToInt32(satir);
            }
            sayac++;
        }

        //for (int i = 0; i < kisi5.Count; i++)
        //{
        //    Console.WriteLine("dosya içeriği:{0}", kisi5[i]);
        //}


    }

}


