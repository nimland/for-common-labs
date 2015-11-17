using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
	class Statistics
	{
		private List<double> distributionList = new List<double>();

		public double ExpectedValue { get; private set; }
		public double Dispersion { get; private set; }
		public double StandardDeviation { get; private set; }
		public double IndirectUniformity { get; private set; }

		public Statistics(List<double> distributionList)
		{
			this.distributionList = distributionList;
			GetStatistics();
		}

		private void GetStatistics()
		{
			ExpectedValue = distributionList.Sum() / distributionList.Count;
			Dispersion = distributionList.Aggregate(0d,(sum, next) => sum + Math.Pow((next - ExpectedValue), 2)) / distributionList.Count;
			StandardDeviation = Math.Sqrt(Dispersion);
			int k = 0;
			for (int i = 0; i < distributionList.Count - 1; i += 2)
			{
				if (Math.Pow( distributionList[i],2) + Math.Pow(distributionList[i+1],2) < 1)
				{
					k++;
				}
			}
			IndirectUniformity = 2d * k / distributionList.Count;
			
		}
	}
}
