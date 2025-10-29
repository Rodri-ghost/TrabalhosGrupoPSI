using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabGrupoM9C_Pert
{
    public partial class Form1 : Form
    {
        public string path= @"C:\Users\Rodrigo Almeida\source\repos\Rodri-ghost\TrabalhosGrupoPSI\TrabGrupoM9C_Pert\bin\Debug\Maior.txt";
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSalv_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(txtVet.Text);
                File.AppendAllText(path, num + "\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            txtVet.Clear();
        }
        private void btnMaior_Click(object sender, EventArgs e)
        {
            int maiorNum=0;
            for (int i = 0; i < File.ReadAllLines(path).Length; i++)
            {
                int num = int.Parse(File.ReadAllLines(path)[i]);
                maiorNum = maior(maiorNum, num);
            }

            lblMaior.Text = $"Maior número: {maiorNum}";
        }
        private int maior(int num1, int num2)
        {
            if(num1>num2)
                return num1;
            else
                return num2;
        }
    }
}