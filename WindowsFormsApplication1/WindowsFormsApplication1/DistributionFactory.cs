using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
	static class DistributionFactory
	{
		public static Distribution GetDistribution(int choice)
		{
			switch (choice)
			{
				case 0: return new Lemer();
				default: return null;
			}
		}
	}
}
