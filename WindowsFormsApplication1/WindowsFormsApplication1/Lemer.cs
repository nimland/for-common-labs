using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
	class Lemer : Distribution
	{
		private int a;
		private int m;
		private double current;
		public double Period { get; set; }
		public double Aperiodicity { get; set; }

		public override void Generate(Request request)
		{
			CheckParams(request);
			double number = Next();
			while (!distributionList.Contains(number))
			{
				distributionList.Add(number);
				number = Next();
			}
			Aperiodicity = distributionList.Count();
			Period = Aperiodicity - distributionList.IndexOf(number);
		}

		protected virtual void CheckParams(Request request)
		{
			a = int.Parse(request.A);
			m = int.Parse(request.M);
			current = double.Parse(request.Ro);
			if (a <= 0 || m <= a)
			{
				throw new ArgumentException();
			}
		}

		private double Next()
		{
			current = a * current % m;
			return current / m;
		}
	}
}
