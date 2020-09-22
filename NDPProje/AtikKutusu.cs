using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDPProje
{
    public class AtikKutusu
    {

		public int BosaltmaPuani { get; set; }

		public int Kapasite { get; set; }

		public int DoluHacim { get; set; }

		public int DolulukOrani { get; set; }

		public bool Bosalt()
		{
			if (DolulukOrani >= 75 && DolulukOrani <= 100)
			{
				DoluHacim = 0;
				DolulukOrani = 0;
				return true;
			}
			else return false;
		}

		public bool Ekle(Atik atik)
		{
			if (atik.Hacim <= (Kapasite - DoluHacim))
			{
				DoluHacim += atik.Hacim;
				return true;
			}
			else return false;
		}
	}
}
