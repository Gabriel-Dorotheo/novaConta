using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace novaConta
{
	public partial class Form1 : Form
	{
		public string nome;
		public string email;
		public string senha;
		public Form1()
		{
			InitializeComponent();
		}
		private void tb1_TextChanged(object sender, EventArgs e)
		{
			nome = tb1.Text;
		}

		private void tb2_TextChanged(object sender, EventArgs e)
		{
			email = tb2.Text;
		}

		private void tb3_TextChanged(object sender, EventArgs e)
		{
			senha = tb3.Text;
		}


		public void cadastrar()
		{
			if (tb1.Text == string.Empty || tb2.Text == string.Empty || tb3.Text == string.Empty)
			{
			
				MessageBox.Show("Preencha todos os campos.");
			}
			else
			{

				MessageBox.Show("Conta criada com sucesso.");
				Form2 cadInfo = new Form2(tb1.Text);
				cadInfo.Show();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			cadastrar();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
