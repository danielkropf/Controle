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
using System.IO;

namespace Controle
{
	public partial class Form1 : Form
	{
		List<string> funcionarios;
		List<string> produtos;
		List<string> historico = new List<string>();
		List<List<string>> historicoSplited = new List<List<string>>();

		public Form1()
		{
			InitializeComponent();
			LoadFuncionarios(funcionarios);
			LoadProdutos(produtos);
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
			tab1DayController.Value = DateTime.Now.Day;
			tab1MonthController.Value = DateTime.Now.Month;
			tab1YearController.Minimum = DateTime.Now.Year - 2;
			tab1YearController.Maximum = DateTime.Now.Year + 5;
			tab1YearController.Value = DateTime.Now.Year;
			LoadHistorico(historico);
		}

		private void SaveHistorico()
		{
			if (System.IO.File.Exists("Historico.txt"))
			{
				System.IO.File.Delete("Historico.txt");
			}
			System.IO.StreamWriter file = new System.IO.StreamWriter("Historico.txt", false);

			for (int i = 0; i < historico.Count; i++)
			{
				file.WriteLine(historico[i]);
			}
			file.Close();
			SplitHistorico(historicoSplited);
		}

		private void LoadFuncionarios(List<string> list)
		{
			list = new List<string>();
			System.IO.StreamReader fileSR = new System.IO.StreamReader("Funcionarios.txt");
			string line;

			while ((line = fileSR.ReadLine()) != null)
			{
				list.Add(line);
				tab1ComboFuncionarios.Items.Add(line);
			}
			fileSR.Close();
		}

		private void LoadHistorico(List<string> list)
		{
			System.IO.StreamReader fileSR = new System.IO.StreamReader("Historico.txt");
			string line;

			while((line = fileSR.ReadLine()) != null)
			{
				list.Add(line);
			}
			fileSR.Close();
			SplitHistorico(historicoSplited);
			WriteHistorico();
		}

		private void SplitHistorico(List<List<string>> list)
		{
			if (historico.Count > 0)
			{
				for (int i = 0; i < historico.Count; i++)
				{
					string[] array = historico[i].Split('#');
					list.Add(new List<string>());
					for (int j = 0; j < array.Length; j++)
					{
						list[i].Add(array[j]);
					}
				}
			}
		}

		private void LoadProdutos(List<String> list)
		{
			list = new List<string>();
			System.IO.StreamReader fileSR = new System.IO.StreamReader("Produtos.txt");
			string line;

			while ((line = fileSR.ReadLine()) != null)
			{
				list.Add(line);
				tab1ComboProdutos.Items.Add(line);
			}
			fileSR.Close();
		}

		private void WriteHistorico()
		{
			if (historico.Count > 0)
			{
				listBox1.Items.Clear();
				for (int i = 0; i < historico.Count; i++)
				{
					listBox1.Items.Add(historicoSplited[i][3] + " - " + historicoSplited[i][0] + " - " + historicoSplited[i][1] + " - " + historicoSplited[i][2]);
				}
			}
			UpdateTab2();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (tab1ComboFuncionarios.Text != "" && tab1ComboProdutos.Text != "")
			{
				historico.Add(tab1ComboFuncionarios.Text + "#" + tab1ComboProdutos.Text + "#" + tab1QuantidadeController.Value + "#" + tab1DayController.Value + "/" + tab1MonthController.Value + "/" + tab1YearController.Value);
				SaveHistorico();
				MessageBox.Show(tab1ComboFuncionarios.Text + " - " + tab1ComboProdutos.Text + " - " + tab1QuantidadeController.Value + " - " + tab1DayController.Value + "/" + tab1MonthController.Value + "/" + tab1YearController.Value + " adicionado.", "Controle", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Preencha todos os campos.", "Controle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			WriteHistorico();
		}

		private void UpdateTab2()
		{
			string[] line;
			string[] years = new string[historicoSplited.Count];
			bool counted = true;

			for(int i = 0; i < historicoSplited.Count; i++)
			{
				line = historicoSplited[i][3].Split('/');
				for(int j = 0; j < years.Length; j++)
				{
					for (int l = 0; l < j; l++)
					{
						if (line[2] == years[l]) counted = false;
					}
					if (counted) years[j] = line[2];
					counted = true;
				}
				for(int j = 0; j < years.Length; j++)
				{
					if (years[j] != null) tab2ComboYear.Items.Add(years[j]);
				}
			}
		}
	}
}
