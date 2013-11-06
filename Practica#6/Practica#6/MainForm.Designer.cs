/*
 * Created by SharpDevelop.
 * User: Alumnos
 * Date: 31/10/2013
 * Time: 07:05 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Practica_6
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.Codigo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Nombre = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.DF = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.label4 = new System.Windows.Forms.Label();
			this.Portugal = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.ReinoUnido = new System.Windows.Forms.CheckBox();
			this.Macedonia = new System.Windows.Forms.CheckBox();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.Calendario = new System.Windows.Forms.MonthCalendar();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// Codigo
			// 
			this.Codigo.Location = new System.Drawing.Point(81, 19);
			this.Codigo.Name = "Codigo";
			this.Codigo.Size = new System.Drawing.Size(82, 20);
			this.Codigo.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 18);
			this.label1.TabIndex = 1;
			this.label1.Text = "Codigo:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 19);
			this.label2.TabIndex = 3;
			this.label2.Text = "Nombre:";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// Nombre
			// 
			this.Nombre.Location = new System.Drawing.Point(81, 45);
			this.Nombre.Name = "Nombre";
			this.Nombre.Size = new System.Drawing.Size(82, 20);
			this.Nombre.TabIndex = 4;
			this.Nombre.TextChanged += new System.EventHandler(this.TextBox2TextChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 101);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(126, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "1.-Capital de Mexico?";
			// 
			// DF
			// 
			this.DF.Location = new System.Drawing.Point(34, 127);
			this.DF.Name = "DF";
			this.DF.Size = new System.Drawing.Size(85, 24);
			this.DF.TabIndex = 6;
			this.DF.TabStop = true;
			this.DF.Text = "DF";
			this.DF.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(34, 157);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(85, 24);
			this.radioButton2.TabIndex = 7;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Guadalajara";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			this.radioButton3.Location = new System.Drawing.Point(34, 187);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(85, 24);
			this.radioButton3.TabIndex = 8;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Monterrey\r\n";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 227);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(151, 23);
			this.label4.TabIndex = 9;
			this.label4.Text = "2.- Paises de Europa?";
			// 
			// Portugal
			// 
			this.Portugal.Location = new System.Drawing.Point(15, 253);
			this.Portugal.Name = "Portugal";
			this.Portugal.Size = new System.Drawing.Size(85, 24);
			this.Portugal.TabIndex = 10;
			this.Portugal.Text = "Portugal";
			this.Portugal.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.checkBox2.Location = new System.Drawing.Point(15, 283);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(104, 24);
			this.checkBox2.TabIndex = 11;
			this.checkBox2.Text = "Chile";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// ReinoUnido
			// 
			this.ReinoUnido.Location = new System.Drawing.Point(15, 313);
			this.ReinoUnido.Name = "ReinoUnido";
			this.ReinoUnido.Size = new System.Drawing.Size(85, 24);
			this.ReinoUnido.TabIndex = 12;
			this.ReinoUnido.Text = "Reino Unido";
			this.ReinoUnido.UseVisualStyleBackColor = true;
			// 
			// Macedonia
			// 
			this.Macedonia.Location = new System.Drawing.Point(15, 343);
			this.Macedonia.Name = "Macedonia";
			this.Macedonia.Size = new System.Drawing.Size(104, 24);
			this.Macedonia.TabIndex = 13;
			this.Macedonia.Text = "Macedonia";
			this.Macedonia.UseVisualStyleBackColor = true;
			// 
			// checkBox5
			// 
			this.checkBox5.Location = new System.Drawing.Point(15, 373);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(85, 24);
			this.checkBox5.TabIndex = 14;
			this.checkBox5.Text = "Australia";
			this.checkBox5.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(222, 19);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(233, 43);
			this.label5.TabIndex = 15;
			this.label5.Text = "3.- Cantidad de estados de los que se compone \r\nMexico?";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(342, 65);
			this.numericUpDown1.Maximum = new decimal(new int[] {
									40,
									0,
									0,
									0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(39, 20);
			this.numericUpDown1.TabIndex = 16;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(222, 101);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(255, 23);
			this.label6.TabIndex = 17;
			this.label6.Text = "4.- Dia en que termino la segunda guerra mundial?";
			// 
			// Calendario
			// 
			this.Calendario.Location = new System.Drawing.Point(228, 133);
			this.Calendario.Name = "Calendario";
			this.Calendario.TabIndex = 18;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(201, 387);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 19;
			this.button1.Text = "Terminar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.ClientSize = new System.Drawing.Size(507, 422);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Calendario);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.checkBox5);
			this.Controls.Add(this.Macedonia);
			this.Controls.Add(this.ReinoUnido);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.Portugal);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.radioButton3);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.DF);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Nombre);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Codigo);
			this.Name = "MainForm";
			this.Text = "Practica#6";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.MonthCalendar Calendario;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox checkBox5;
		private System.Windows.Forms.CheckBox Macedonia;
		private System.Windows.Forms.CheckBox ReinoUnido;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox Portugal;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton DF;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox Nombre;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox Codigo;
	}
}
