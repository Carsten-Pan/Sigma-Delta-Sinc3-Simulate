using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SigmaDelta
{
	public partial class Form1 : Form
	{
		SDInstance sDInstance;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			sDInstance = new SDInstance(double.Parse(TxtPLimit.Text), double.Parse(TxtNLimit.Text), int.Parse(CbxRatio.Text));
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			TxtVout.Text = sDInstance.GetVout().ToString("0.000");
			TxtVoutRaw.Text = sDInstance.GetRawVout().ToString();
		}

		private void BtnStart_Click(object sender, EventArgs e)
		{
			double vin = 3;
			double.TryParse(TxtVin.Text, out vin);
			sDInstance.SetVin(vin);
			sDInstance.Start();
		}

		private void BtnStop_Click(object sender, EventArgs e)
		{
			sDInstance.Stop();
		}

		private void BtnCatch_Click(object sender, EventArgs e)
		{
			sDInstance?.Catch();
		}

		private void BtnSet_Click(object sender, EventArgs e)
		{
			double vin = 3;
			double.TryParse(TxtVin.Text, out vin);
			sDInstance.SetVin(vin);
		}

		private void BtnSetParam_Click(object sender, EventArgs e)
		{
			sDInstance.Stop();
			sDInstance = new SDInstance(double.Parse(TxtPLimit.Text), double.Parse(TxtNLimit.Text), int.Parse(CbxRatio.Text));
		}
	}
}
