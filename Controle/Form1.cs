using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Controle
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void ChangeMonth(object sender, EventArgs e)
		{
			if(tab1MonthController.Value == 1 || tab1MonthController.Value == 3 || tab1MonthController.Value == 5 || tab1MonthController.Value == 7 || tab1MonthController.Value == 8 || tab1MonthController.Value == 10 || tab1MonthController.Value == 12)
			{
				tab1DayController.Maximum = 31;
			}
			else if (tab1MonthController.Value == 4 || tab1MonthController.Value == 6 || tab1MonthController.Value == 9 || tab1MonthController.Value == 11)
			{
				tab1DayController.Maximum = 30;
			}
			else if (tab1MonthController.Value == 2)
			{
				if(DateTime.Now.Year % 4 == 0)
				{
					tab1DayController.Maximum = 29;
				}
				else
				{
					tab1DayController.Maximum = 28;
				}
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			tab1YearController.Minimum = DateTime.Now.Year - 2;
			tab1YearController.Maximum = DateTime.Now.Year + 5;
			tab1YearController.Value = DateTime.Now.Year;

		}
	}
}
