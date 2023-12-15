using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LogoKaresz
{
	public partial class Form1 : Form
	{
		/* Függvények */
		void Oldalaz(double m)
		{
			Jobbra(90);
			Előre(m);
			Balra(90);
		}


		void Odatölt(double x, double y, Color szin) // double elore, double jobbra
        {
			using(new Rajzol(false))
			{
				Előre(y);
				Jobbra(90);
				Előre(x);
				Tölt(szin);
				Hátra(x);
				Balra(90);
				Hátra(y);
			}
		}

        void Odatölt_polar(double f, double m, Color szin) //fok, meret
        {
            using (new Rajzol(false))
            {
				Jobbra(f);
				Előre(m);
				Tölt(szin);
				Hátra(m);
				Balra(f);
            }

        }

        void Négyzet(double meret, Color szin)
		{
			for (int i = 0; i < 4; i++)
			{
				Előre(meret);
				Jobbra(90);
			}
			Odatölt(meret / 2, meret / 2, szin);
		}

        void Sor(double m, int db, Color szin1, Color szin2)
        {
			Color szin = szin1;
			for(int i = 0;i < db;i++)
			{
				Négyzet(m, szin);
				Oldalaz(m);
				szin =szin == szin1 ? szin2 : szin1; 
            }
			Oldalaz(-db * m);
        }

        void Sakktábla(double m, int oszlopdb, int sordb, Color szin1, Color szin2)
        {
            Color szin = szin1;
            for (int i = 0; i < sordb ; i++)
			{
				Sor(m, oszlopdb, szin, szin == szin1 ? szin2 : szin1);
				Előre(m);
                szin = szin == szin1 ? szin2 : szin1;
            }
			Hátra(sordb*m);
        }

		/*Color Masik_szin(Color szin, Color szin1, Color szin2)
		{
			return szin == szin1 ? szin2 : szin1;
        }*/

        /* Függvények vége */
        void FELADAT()
		{
			/* Ezt indítja a START gomb! */
			// Teleport(közép.X, közép.Y+150, észak);
			//Négyzet(50, Color.Black);
			Sor(20, 10, Color.Black, Color.Red);
			
		}
	}
}
