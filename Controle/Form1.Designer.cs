﻿namespace Controle
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.button1 = new System.Windows.Forms.Button();
			this.tab1QuantidadeController = new System.Windows.Forms.NumericUpDown();
			this.tab1YearController = new System.Windows.Forms.NumericUpDown();
			this.tab1MonthController = new System.Windows.Forms.NumericUpDown();
			this.tab1DayController = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tab1ComboProdutos = new System.Windows.Forms.ComboBox();
			this.tab1ComboFuncionarios = new System.Windows.Forms.ComboBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tab2ComboYear = new System.Windows.Forms.ComboBox();
			this.tab2ComboMonth = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tab1QuantidadeController)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tab1YearController)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tab1MonthController)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tab1DayController)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(673, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(0, 27);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(673, 278);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Controls.Add(this.tab1QuantidadeController);
			this.tabPage1.Controls.Add(this.tab1YearController);
			this.tabPage1.Controls.Add(this.tab1MonthController);
			this.tabPage1.Controls.Add(this.tab1DayController);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.tab1ComboProdutos);
			this.tabPage1.Controls.Add(this.tab1ComboFuncionarios);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(665, 252);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Adicionar";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(546, 143);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(95, 23);
			this.button1.TabIndex = 14;
			this.button1.Text = "Confirmation";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tab1QuantidadeController
			// 
			this.tab1QuantidadeController.Location = new System.Drawing.Point(405, 115);
			this.tab1QuantidadeController.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.tab1QuantidadeController.Name = "tab1QuantidadeController";
			this.tab1QuantidadeController.ReadOnly = true;
			this.tab1QuantidadeController.Size = new System.Drawing.Size(92, 20);
			this.tab1QuantidadeController.TabIndex = 13;
			this.tab1QuantidadeController.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// tab1YearController
			// 
			this.tab1YearController.Location = new System.Drawing.Point(588, 117);
			this.tab1YearController.Name = "tab1YearController";
			this.tab1YearController.ReadOnly = true;
			this.tab1YearController.Size = new System.Drawing.Size(53, 20);
			this.tab1YearController.TabIndex = 12;
			// 
			// tab1MonthController
			// 
			this.tab1MonthController.Location = new System.Drawing.Point(546, 117);
			this.tab1MonthController.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
			this.tab1MonthController.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.tab1MonthController.Name = "tab1MonthController";
			this.tab1MonthController.ReadOnly = true;
			this.tab1MonthController.Size = new System.Drawing.Size(36, 20);
			this.tab1MonthController.TabIndex = 11;
			this.tab1MonthController.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.tab1MonthController.ValueChanged += new System.EventHandler(this.ChangeMonth);
			// 
			// tab1DayController
			// 
			this.tab1DayController.Location = new System.Drawing.Point(504, 117);
			this.tab1DayController.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
			this.tab1DayController.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.tab1DayController.Name = "tab1DayController";
			this.tab1DayController.ReadOnly = true;
			this.tab1DayController.Size = new System.Drawing.Size(36, 20);
			this.tab1DayController.TabIndex = 10;
			this.tab1DayController.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(501, 99);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(30, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Data";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(402, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Quantidade";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(237, 98);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Produto";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 99);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Funcionario";
			// 
			// tab1ComboProdutos
			// 
			this.tab1ComboProdutos.FormattingEnabled = true;
			this.tab1ComboProdutos.Location = new System.Drawing.Point(240, 114);
			this.tab1ComboProdutos.Name = "tab1ComboProdutos";
			this.tab1ComboProdutos.Size = new System.Drawing.Size(159, 21);
			this.tab1ComboProdutos.TabIndex = 3;
			// 
			// tab1ComboFuncionarios
			// 
			this.tab1ComboFuncionarios.FormattingEnabled = true;
			this.tab1ComboFuncionarios.Location = new System.Drawing.Point(23, 115);
			this.tab1ComboFuncionarios.Name = "tab1ComboFuncionarios";
			this.tab1ComboFuncionarios.Size = new System.Drawing.Size(211, 21);
			this.tab1ComboFuncionarios.TabIndex = 2;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.tab2ComboYear);
			this.tabPage2.Controls.Add(this.tab2ComboMonth);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.listBox1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(665, 252);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Historico";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tab2ComboYear
			// 
			this.tab2ComboYear.FormattingEnabled = true;
			this.tab2ComboYear.Location = new System.Drawing.Point(561, 19);
			this.tab2ComboYear.Name = "tab2ComboYear";
			this.tab2ComboYear.Size = new System.Drawing.Size(96, 21);
			this.tab2ComboYear.TabIndex = 3;
			// 
			// tab2ComboMonth
			// 
			this.tab2ComboMonth.FormattingEnabled = true;
			this.tab2ComboMonth.Items.AddRange(new object[] {
            "01 - Janeiro",
            "02 - Fevereiro",
            "03 - Março",
            "04 - Abril",
            "05 - Maio",
            "06 - Junho",
            "07 - Julho",
            "08 - Agosto",
            "09 - Setembro",
            "10 - Outubro",
            "11 - Novembro",
            "12 - Dezembro"});
			this.tab2ComboMonth.Location = new System.Drawing.Point(439, 19);
			this.tab2ComboMonth.Name = "tab2ComboMonth";
			this.tab2ComboMonth.Size = new System.Drawing.Size(116, 21);
			this.tab2ComboMonth.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(8, 3);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(246, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "Dia/Mês/Ano - Funcionario - Produto - Quantidade";
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(8, 19);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(424, 225);
			this.listBox1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(673, 305);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tab1QuantidadeController)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tab1YearController)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tab1MonthController)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tab1DayController)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox tab1ComboProdutos;
		private System.Windows.Forms.ComboBox tab1ComboFuncionarios;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.NumericUpDown tab1YearController;
		private System.Windows.Forms.NumericUpDown tab1MonthController;
		private System.Windows.Forms.NumericUpDown tab1DayController;
		private System.Windows.Forms.NumericUpDown tab1QuantidadeController;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox tab2ComboYear;
		private System.Windows.Forms.ComboBox tab2ComboMonth;
	}
}

