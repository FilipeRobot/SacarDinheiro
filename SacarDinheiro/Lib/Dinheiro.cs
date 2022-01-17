using System;
using System.Windows.Forms;

namespace SacarDinheiro.Lib
{
    internal class Dinheiro
    {
        /// <summary>
        /// Método para sacar o valor informado pelo usuário
        /// </summary>
        /// <param name="valorSacar">Valor que deseja sacar</param>
        /// <param name="notasDisponiveis">Lista de notas ou moedas disponíveis</param>
        /// <returns>
        ///     <para>
        ///         Retorna um <paramref name="Array"/> de inteiros onde os itens desse array são a quantidade de notas ou moedas a serem sacadas.<br>
        ///         Se não houver notas ou moedas de um determinado valor a serem sacadas o item é igual a zero
        ///         </br>
        ///     </para>
        /// </returns>
        public static int[] SacarValor(double valorSacar, double[] notasDisponiveis)
        {
            int[] qtdNotasSacadas = new int[notasDisponiveis.Length];

            foreach (double nota in notasDisponiveis)
            {
                if (valorSacar == 0)
                {
                    break;
                }
                else if (nota > valorSacar)
                {
                    continue;
                }

                int qtdNotas = (int)(valorSacar / nota); // Determina a quantidade de notas a serem sacadas

                if (qtdNotas > 0)
                {
                    valorSacar -= Math.Round(qtdNotas * nota, 2); // Remove da variável "valorSacar" o valor total equivalente a quantidade de notas do loop atual

                    for (int i = 0; i < notasDisponiveis.Length; i++)
                    {
                        if (nota == notasDisponiveis[i])
                        {
                            qtdNotasSacadas[i] = qtdNotas;
                        }
                    }
                }
            } // Visita cada nota na lista(array) de notas disponíveis

            return qtdNotasSacadas;
        }

        /// <summary>
        /// Método para verificar o valor informado pelo usuário
        /// </summary>
        /// <returns>
        ///     <para>
        ///         Se o valor não for informado retorna <c>false</c>
        ///     </para>
        ///     <para>
        ///         Se foi informado mas não foi possível converter em <c>double</c> retorna <c>false</c>
        ///     </para>
        ///     <para>
        ///         Se foi informado e foi possível converter em <c>double</c> mas o valor é menor ou igual a zero retorna <c>false</c>
        ///     </para>
        ///     <para>
        ///         Se foi informado, foi possível converter em <c>double</c>, é maior que zero e maior que o saldo disponível retorna <c>false</c>
        ///     </para>
        ///     <para>
        ///         Se foi informado, foi possível converter em <c>double</c>, é maior que zero, é maior que o saldo disponível e tem as casas decimais separadas com ponto em vez de virgula retorna <c>false</c>
        ///     </para>
        ///     <para>
        ///         No caso de nenhuma das condições anteriores se aplicar retorna <c>true</c>
        ///     </para>
        /// </returns>
        /// <param name="valorSacar">Valor que deseja sacar</param>
        /// <param name="saldoTotal">Saldo total disponível para saque</param>
        /// <param name="tituloMsg">Título para as mensagens</param>
        public static bool VericarEntrada(string valorSacar, int saldoTotal, string tituloMsg)
        {
            if (valorSacar.Equals(string.Empty))
            {
                MessageBox.Show("Para sacar primeiro informe algum valor!", tituloMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!double.TryParse(valorSacar, out _))
            {
                MessageBox.Show("Por favor informe um valor numérico válido\nFormato: R$1,00 ou R$1000,00", tituloMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            } // Verifica se é possível converter o valor informado em um valor double, se não for possível então o valor informado é uma letra, texto ou um valor numérico inválido, então informa o usuário junto com o formato numérico aceito pelo programa
            else if (Convert.ToDouble(valorSacar) <= 0)
            {
                MessageBox.Show("Para sacar informe um valor numérico maior que 0", tituloMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (Convert.ToDouble(valorSacar) > saldoTotal)
            {
                MessageBox.Show("Saldo Insuficiente", tituloMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
    }
}
