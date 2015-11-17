using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Request request = new Request()
			{
				A = textBoxA.Text,
				M = textBoxM.Text,
				Ro = textBoxR.Text
			};
			Distribution distribution = DistributionFactory.GetDistribution(comboBox1.SelectedIndex);
			try
			{
				distribution.Generate(request);
				var statistics = new Statistics(distribution.DistributionList);
				distribution.Draw(chart1);
				expValue.Text = statistics.ExpectedValue.ToString();
				dispersion.Text = statistics.Dispersion.ToString();
				standardDeviation.Text = statistics.StandardDeviation.ToString();
				uniformity.Text = statistics.IndirectUniformity.ToString();
				period.Text = (distribution as Lemer).Period.ToString();
				aperiodicity.Text = (distribution as Lemer).Period.ToString();
			}
			catch
			{
				MessageBox.Show("Введите корректные данные.");
			}

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			
			chart1.Series.ToList().ForEach(x => x.Points.Clear());

			switch (comboBox1.SelectedIndex)
			{
				case 0:
					{
						chart1.Series[1].Points.AddXY(0, 0.05);
						chart1.Series[1].Points.AddXY(1, 0.05);
						break;
					}
			}
		}


	}
}
