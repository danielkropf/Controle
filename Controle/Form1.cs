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
using System.Diagnostics;

namespace Controle
{
	public partial class Form1 : Form
	{
		List<string> funcionarios;
		List<string> produtos;
		List<string> historico = new List<string>();
		List<List<string>> historicoSplited = new List<List<string>>();
		bool changed;

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
				tab2ComboFuncionarios.Items.Add(line);
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
				tab2ComboProdutos.Items.Add(line);
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
				historico.Add(tab1ComboFuncionarios.Text + "#" + tab1ComboProdutos.Text + "#" + tab1QuantidadeController.Value + "#" + tab1YearController.Value + "/" + tab1MonthController.Value + "/" + tab1DayController.Value);
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
			for(int i = 2016; i <= DateTime.Now.Year; i++)
			{
				tab2ComboYear.Items.Add(i);
			}
		}

		private void clearSelections_Click(object sender, EventArgs e)
		{
			tab2ComboMonth.Text = "";
			tab2ComboYear.Text = "";
		}

		private void tab2ComboYear_TextChanged(object sender, EventArgs e)
		{
			if (!changed)
			{
				changed = true;
				tab2ComboMonth.Text = "";
				tab2ComboFuncionarios.Text = "";
				tab2ComboProdutos.Text = "";

				List<string> list = new List<string>();
				string[] listSpilted;

				if (tab2ComboYear.Text != "")
				{
					for (int i = 0; i < historicoSplited.Count; i++)
					{
						listSpilted = historicoSplited[i][3].Split('/');
						if (listSpilted[0] == tab2ComboYear.Text) list.Add(historicoSplited[i][3] + " - " + historicoSplited[i][0] + " - " + historicoSplited[i][1] + " - " + historicoSplited[i][2]);
					}
					listBox1.Items.Clear();
					for (int i = 0; i < list.Count; i++) listBox1.Items.Add(list[i]);
				}
				else {
					listBox1.Items.Clear();
					for (int i = 0; i < historicoSplited.Count; i++) listBox1.Items.Add(historicoSplited[i][3] + " - " + historicoSplited[i][0] + " - " + historicoSplited[i][1] + " - " + historicoSplited[i][2]);
				}
				changed = false;
			}
		}

		private void tab2ComboMonth_TextChanged(object sender, EventArgs e)
		{
			if (!changed)
			{
				changed = true;
				tab2ComboYear.Text = "";
				tab2ComboFuncionarios.Text = "";
				tab2ComboProdutos.Text = "";

				List<string> list = new List<string>();
				string[] listSpilted;
				string[] listSpilted2;

				if (tab2ComboMonth.Text != "")
				{
					listSpilted2 = tab2ComboMonth.Text.Split('-');
					listSpilted2[0] = listSpilted2[0].Remove(0, 1);
					listSpilted2[0] = listSpilted2[0].Remove(1, 1);

					for (int i = 0; i < historicoSplited.Count; i++)
					{
						listSpilted = historicoSplited[i][3].Split('/');
						if (listSpilted[1] == listSpilted2[0]) list.Add(historicoSplited[i][3] + " - " + historicoSplited[i][0] + " - " + historicoSplited[i][1] + " - " + historicoSplited[i][2]);
					}

					listBox1.Items.Clear();
					for (int i = 0; i < list.Count; i++) listBox1.Items.Add(list[i]);
				}
				else {
					listBox1.Items.Clear();
					for (int i = 0; i < historicoSplited.Count; i++) listBox1.Items.Add(historicoSplited[i][3] + " - " + historicoSplited[i][0] + " - " + historicoSplited[i][1] + " - " + historicoSplited[i][2]);
				}
				changed = false;
			}
		}

		private void tab2ComboFuncionarios_TextChanged(object sender, EventArgs e)
		{
			if (!changed)
			{
				changed = true;
				tab2ComboMonth.Text = "";
				tab2ComboYear.Text = "";
				tab2ComboProdutos.Text = "";

				List<string> list = new List<string>();
				string[] listSpilted;

				if (tab2ComboFuncionarios.Text != "")
				{
					for (int i = 0; i < historicoSplited.Count; i++)
					{
						if (historicoSplited[i][0] == tab2ComboFuncionarios.Text) list.Add(historicoSplited[i][3] + " - " + historicoSplited[i][0] + " - " + historicoSplited[i][1] + " - " + historicoSplited[i][2]);
					}
					listBox1.Items.Clear();
					for (int i = 0; i < list.Count; i++) listBox1.Items.Add(list[i]);
				}
				else {
					listBox1.Items.Clear();
					for (int i = 0; i < historicoSplited.Count; i++) listBox1.Items.Add(historicoSplited[i][3] + " - " + historicoSplited[i][0] + " - " + historicoSplited[i][1] + " - " + historicoSplited[i][2]);
				}
				changed = false;
			}
		}

		private void tab2ComboProdutos_TextChanged(object sender, EventArgs e)
		{
			if (!changed)
			{
				changed = true;
				tab2ComboMonth.Text = "";
				tab2ComboFuncionarios.Text = "";
				tab2ComboYear.Text = "";

				List<string> list = new List<string>();
				string[] listSpilted;

				if (tab2ComboProdutos.Text != "")
				{
					for (int i = 0; i < historicoSplited.Count; i++)
					{
						if (historicoSplited[i][1] == tab2ComboProdutos.Text) list.Add(historicoSplited[i][3] + " - " + historicoSplited[i][0] + " - " + historicoSplited[i][1] + " - " + historicoSplited[i][2]);
					}
					listBox1.Items.Clear();
					for (int i = 0; i < list.Count; i++) listBox1.Items.Add(list[i]);
				}
				else {
					listBox1.Items.Clear();
					for (int i = 0; i < historicoSplited.Count; i++) listBox1.Items.Add(historicoSplited[i][3] + " - " + historicoSplited[i][0] + " - " + historicoSplited[i][1] + " - " + historicoSplited[i][2]);
				}
				changed = false;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (listBox1.SelectedIndex.ToString() != "-1")
			{
				int num;
				string word = listBox1.SelectedItem.ToString();
				string[] splitedHistorico = word.Split('-');
				splitedHistorico[0] = splitedHistorico[0].Remove(splitedHistorico[0].Length - 1, 1);
				splitedHistorico[1] = splitedHistorico[1].Remove(0, 1);
				splitedHistorico[1] = splitedHistorico[1].Remove(splitedHistorico[1].Length - 1, 1);
				splitedHistorico[2] = splitedHistorico[2].Remove(0, 1);
				splitedHistorico[2] = splitedHistorico[2].Remove(splitedHistorico[2].Length - 1, 1);
				splitedHistorico[3] = splitedHistorico[3].Remove(0, 1);
				word = splitedHistorico[1] + "#" + splitedHistorico[2] + "#" + splitedHistorico[3] + "#" + splitedHistorico[0];

				historico.Remove(word);
				SplitHistorico(historicoSplited);
				WriteHistorico();
				SaveHistorico();
			}
		}

		private void arquivoHistoricotxtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Não é recomendado fazer alterações manuais nos arquivos. Deseja continuar mesmo assim?", "Controle", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if(dialogResult == DialogResult.Yes) System.Diagnostics.Process.Start("Historico.txt");
		}

		private void arquivoProdutostxtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Não é recomendado fazer alterações manuais nos arquivos. Deseja continuar mesmo assim?", "Controle", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (dialogResult == DialogResult.Yes) System.Diagnostics.Process.Start("Produtos.txt");
		}

		private void arquivoFuncionariostxtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Não é recomendado fazer alterações manuais nos arquivos. Deseja continuar mesmo assim?", "Controle", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (dialogResult == DialogResult.Yes) System.Diagnostics.Process.Start("Funcionarios.txt");
		}
	}
}
