using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
	abstract class Distribution
	{
		protected List<double> distributionList = new List<double>();

		public List<double> DistributionList
		{
			get { return distributionList; }
		}

		public abstract void Generate(Request request);

		public void Draw(System.Windows.Forms.DataVisualization.Charting.Chart chart)
		{
			chart.Series[0].Points.Clear();
			double i = 0;
			var l = new List<double>();
			var r = new Random();
			while (i < 1)
			{
				i = i + 0.05;
				var y = r.NextDouble();
				chart.Series[0].Points.AddXY(i, y);
			}
		}
	}
}
