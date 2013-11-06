/*
 * Created by SharpDevelop.
 * User: Alumnos
 * Date: 31/10/2013
 * Time: 07:05 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Practica_6
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void TextBox2TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void Label2Click(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			
			int aciertos=0;
			
			if(this.DF.Checked){
				aciertos++;
			}
			
			if(this.Portugal.Checked){
			      aciertos++;
                } 
			if(this.ReinoUnido.Checked){
				aciertos++;
				}
			if(this.Macedonia.Checked){
				aciertos++;
				
			}
			 
			if(this.numericUpDown1.Text=="32"){
				aciertos++;
			}
			
			DateTime fecha= Calendario.SelectionStart;
			
			if(fecha.ToShortDateString()=="07/05/1945"){
				aciertos++;
			}
			
			MessageBox.Show("Codigo: " + Codigo.Text + "\n Nombre: " + Nombre.Text +"\n Aciertos: " + aciertos);
		}
			
		
		
		}
		
	}
