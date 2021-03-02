using SharpBlend;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TestApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			timer1.Start();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			BlendedColor blendedColor = new BlendedColor(
				Color.FromArgb((byte)red1.Value, (byte)green1.Value, (byte)blue1.Value),
				Color.FromArgb((byte)red2.Value, (byte)green2.Value, (byte)blue2.Value),
				(double)(amountOfFirst.Value / 10)
				);

			BackColor = blendedColor.ToColor();
		}
	}
}
