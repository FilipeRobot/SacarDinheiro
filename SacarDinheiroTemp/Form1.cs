using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SacarDinheiroTemp.LibTemp;

namespace SacarDinheiroTemp
{
    public partial class Form1 : Form
    {
        private const int saldoTotal = 17523; //saldo disponível para saque
        private readonly float[] notasDisponiveis = { 100, 50, 20, 10, 5, 2, 1 }; // novas notas/moedas em ordem crescente

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < notasDisponiveis.Length; i++)
            {
                if (notasDisponiveis[i] < 1)
                {
                    ltbNotas.Items[i] = $"Moedas de {notasDisponiveis[i]:N2}: ";

                }else if (notasDisponiveis[i] == 1)
                {
                    ltbNotas.Items[i] = $"Moedas de {notasDisponiveis[i]}: ";
                }
                else
                {
                    ltbNotas.Items[i] = $"Notas de {notasDisponiveis[i]}: ";
                }
            }

            if (DinheiroTemp.VericarEntrada(txtEntrada.Text.Trim(), saldoTotal, Text))
            {
                int[] qtdNotasSacadas = DinheiroTemp.SacarValor(Convert.ToDouble(txtEntrada.Text.Trim()), notasDisponiveis);

                for(int i = 0; i < notasDisponiveis.Length; i++)
                {
                    if(qtdNotasSacadas[i] > 0)
                    {
                        if (notasDisponiveis[i] < 1)
                        {
                            ltbNotas.Items[i] = $"Moedas de {notasDisponiveis[i]:N2}: {qtdNotasSacadas[i]}";
                        }
                        else if (notasDisponiveis[i] == 1)
                        {
                            ltbNotas.Items[i] = $"Moedas de {notasDisponiveis[i]}: {qtdNotasSacadas[i]}";
                        }
                        else
                        {
                            ltbNotas.Items[i] = $"Notas de {notasDisponiveis[i]}: {qtdNotasSacadas[i]}";
                        }
                    }
                }
            }
            txtEntrada.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (ltbNotas.Items.Count != notasDisponiveis.Count())
            {
                ltbNotas.Items.Clear();
                for (int i = 0; i < notasDisponiveis.Length; i++)
                {
                    if (notasDisponiveis[i] < 1)
                    {
                        ltbNotas.Items.Add($"Moedas de {notasDisponiveis[i]:N2}: ");
                    }
                    else if (notasDisponiveis[i] == 1)
                    {
                        ltbNotas.Items.Add($"Moedas de {notasDisponiveis[i]}: ");
                    }
                    else
                    {
                        ltbNotas.Items.Add($"Notas de {notasDisponiveis[i]}: ");
                    }
                }
            }
        }
    }
}
