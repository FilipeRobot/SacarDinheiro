﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SacarDinheiro.Lib;

namespace SacarDinheiro
{
    public partial class Frm_SacarDinheiro : Form
    {

        /* Nomes e motivos dos itens do formulario
         * 
         * Label - Controle Comum
         *      lbl_ValorSacar ==> Não faz nada de especial
         *      lbl_Notas100 ==> Informa a quantidade de notas de R$ 100,00 sacadas
         *      lbl_Notas50 ==> Informa a quantidade de notas de R$ 50,00 sacadas
         *      lbl_Notas20 ==> Informa a quantidade de notas de R$ 20,00 sacadas
         *      lbl_Notas10 ==> Informa a quantidade de notas de R$ 10,00 sacadas
         *      lbl_Notas5 ==> Informa a quantidade de notas de R$ 5,00 sacadas
         *      lbl_Notas2 ==> Informa a quantidade de notas de R$ 2,00 sacadas
         *      lbl_Moedas1 ==> Informa a quantidade de moedas de R$ 1,00 sacadas
         *      lbl_SaldoDisponivel ==> Informa o saldo total disponível, fixo em R$ 17523,00
         *      
         * GroupBox - Conteiner
         *      gpb_Resultado ==> Apenas Agrupa no formulario a quantidade de notas sacadas
         *      
         * TextBox - Controle Comum
         *      txt_ValorSacar ==> Recebe o valor que o usuario deseja sacar
         *      
         * Button - Controle Comum
         *      btn_Sacar ==> Botão para sacar um determinado valor (recebido do txt_ValorSacar)
         *                   e mostrar a quantidade de notas e moedas a serem entregues nas respectivas areas do formulario
         */

        private const int saldoTotal = 17523; //saldo disponível para saque
        private readonly float[] notasDisponiveis = { 100, 50, 20, 10, 5, 2, 1 }; // novas notas/moedas em ordem crescente
        public Frm_SacarDinheiro()
        {
            InitializeComponent();
        }

        private void Lbl_ValorSacar_Click(object sender, EventArgs e)
        {
            txt_ValorSacar.Focus();
            
        }

        private void Btn_Sacar_Click(object sender, EventArgs e)
        {
            lbl_Notas100.Text = "Notas de 100:";
            lbl_Notas50.Text = "Notas de 50:";
            lbl_Notas20.Text = "Notas de 20:";
            lbl_Notas10.Text = "Notas de 10:";
            lbl_Notas5.Text = "Notas de 5:";
            lbl_Notas2.Text = "Notas de 2:";
            lbl_Moedas1.Text = "Moedas de 1:";
            if (Dinheiro.VericarEntrada(txt_ValorSacar.Text.Trim(), saldoTotal, Text))
            {
                int[] qtdNotasSacadas = Dinheiro.SacarValor(Convert.ToDouble(txt_ValorSacar.Text.Trim()), notasDisponiveis);

                for (int i = 0; i < qtdNotasSacadas.Length; i++)
                {
                    if (qtdNotasSacadas[i] > 0)
                    {
                        switch (i)
                        {
                            case 0:
                                lbl_Notas100.Text = $"Notas de 100: {qtdNotasSacadas[i]}";
                                break;
                            case 1:
                                lbl_Notas50.Text = $"Notas de 50: {qtdNotasSacadas[i]}";
                                break;
                            case 2:
                                lbl_Notas20.Text = $"Notas de 20: {qtdNotasSacadas[i]}";
                                break;
                            case 3:
                                lbl_Notas10.Text = $"Notas de 10: {qtdNotasSacadas[i]}";
                                break;
                            case 4:
                                lbl_Notas5.Text = $"Notas de 5: {qtdNotasSacadas[i]}";
                                break;
                            case 5:
                                lbl_Notas2.Text = $"Notas de 2: {qtdNotasSacadas[i]}";
                                break;
                            case 6:
                                lbl_Moedas1.Text = $"Moedas de 1: {qtdNotasSacadas[i]}";
                                break;
                        }
                    }
                }
                
            }
            txt_ValorSacar.Focus();
        }

        private void Txt_ValorSacar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_Sacar_Click(sender, e);
            }
            else if(e.KeyCode == Keys.OemPeriod) //Keys.OemPeriod = botão ponto entre a virgula e o ponto e virgula acima da tecla Win Esquerda
            {
                MessageBox.Show("O separador de casas decimais é virgula", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (!txt_ValorSacar.Text.Equals(String.Empty))
                {
                    txt_ValorSacar.Text = txt_ValorSacar.Text.Remove(txt_ValorSacar.Text.Length - 1);
                }
            }
            else if (Keys.Decimal.CompareTo(e.KeyCode) == 1)
            {
                if(e.KeyValue == 194) // botão numPad ponto = 194
                {
                    MessageBox.Show("O separador de casas decimais é virgula", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (!txt_ValorSacar.Text.Equals(String.Empty))
                    {
                        txt_ValorSacar.Text = txt_ValorSacar.Text.Remove(txt_ValorSacar.Text.Length - 1);
                    }
                }
            }
        }
    }
}