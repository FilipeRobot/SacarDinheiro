namespace SacarDinheiro
{
    partial class Frm_SacarDinheiro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_ValorSacar = new System.Windows.Forms.Label();
            this.gpb_Resultado = new System.Windows.Forms.GroupBox();
            this.lbl_Moedas1 = new System.Windows.Forms.Label();
            this.lbl_Notas2 = new System.Windows.Forms.Label();
            this.lbl_Notas5 = new System.Windows.Forms.Label();
            this.lbl_Notas10 = new System.Windows.Forms.Label();
            this.lbl_Notas20 = new System.Windows.Forms.Label();
            this.lbl_Notas50 = new System.Windows.Forms.Label();
            this.lbl_Notas100 = new System.Windows.Forms.Label();
            this.lbl_SaldoDisponivel = new System.Windows.Forms.Label();
            this.btn_Sacar = new System.Windows.Forms.Button();
            this.txt_ValorSacar = new System.Windows.Forms.TextBox();
            this.btnTeste = new System.Windows.Forms.Button();
            this.gpb_Resultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_ValorSacar
            // 
            this.lbl_ValorSacar.AutoSize = true;
            this.lbl_ValorSacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ValorSacar.Location = new System.Drawing.Point(10, 10);
            this.lbl_ValorSacar.Name = "lbl_ValorSacar";
            this.lbl_ValorSacar.Size = new System.Drawing.Size(226, 16);
            this.lbl_ValorSacar.TabIndex = 0;
            this.lbl_ValorSacar.Text = "Valor Desejado para saque: R$";
            this.lbl_ValorSacar.Click += new System.EventHandler(this.Lbl_ValorSacar_Click);
            // 
            // gpb_Resultado
            // 
            this.gpb_Resultado.CausesValidation = false;
            this.gpb_Resultado.Controls.Add(this.lbl_Moedas1);
            this.gpb_Resultado.Controls.Add(this.lbl_Notas2);
            this.gpb_Resultado.Controls.Add(this.lbl_Notas5);
            this.gpb_Resultado.Controls.Add(this.lbl_Notas10);
            this.gpb_Resultado.Controls.Add(this.lbl_Notas20);
            this.gpb_Resultado.Controls.Add(this.lbl_Notas50);
            this.gpb_Resultado.Controls.Add(this.lbl_Notas100);
            this.gpb_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_Resultado.Location = new System.Drawing.Point(12, 29);
            this.gpb_Resultado.Name = "gpb_Resultado";
            this.gpb_Resultado.Size = new System.Drawing.Size(195, 200);
            this.gpb_Resultado.TabIndex = 1;
            this.gpb_Resultado.TabStop = false;
            this.gpb_Resultado.Text = "Resultado";
            this.gpb_Resultado.MouseCaptureChanged += new System.EventHandler(this.Lbl_ValorSacar_Click);
            // 
            // lbl_Moedas1
            // 
            this.lbl_Moedas1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Moedas1.AutoSize = true;
            this.lbl_Moedas1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Moedas1.Location = new System.Drawing.Point(5, 175);
            this.lbl_Moedas1.Name = "lbl_Moedas1";
            this.lbl_Moedas1.Size = new System.Drawing.Size(101, 16);
            this.lbl_Moedas1.TabIndex = 8;
            this.lbl_Moedas1.Text = "Moedas de 1:";
            // 
            // lbl_Notas2
            // 
            this.lbl_Notas2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Notas2.AutoSize = true;
            this.lbl_Notas2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Notas2.Location = new System.Drawing.Point(5, 150);
            this.lbl_Notas2.Name = "lbl_Notas2";
            this.lbl_Notas2.Size = new System.Drawing.Size(86, 16);
            this.lbl_Notas2.TabIndex = 7;
            this.lbl_Notas2.Text = "Notas de 2:";
            // 
            // lbl_Notas5
            // 
            this.lbl_Notas5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Notas5.AutoSize = true;
            this.lbl_Notas5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Notas5.Location = new System.Drawing.Point(5, 125);
            this.lbl_Notas5.Name = "lbl_Notas5";
            this.lbl_Notas5.Size = new System.Drawing.Size(86, 16);
            this.lbl_Notas5.TabIndex = 6;
            this.lbl_Notas5.Text = "Notas de 5:";
            // 
            // lbl_Notas10
            // 
            this.lbl_Notas10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Notas10.AutoSize = true;
            this.lbl_Notas10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Notas10.Location = new System.Drawing.Point(5, 100);
            this.lbl_Notas10.Name = "lbl_Notas10";
            this.lbl_Notas10.Size = new System.Drawing.Size(94, 16);
            this.lbl_Notas10.TabIndex = 5;
            this.lbl_Notas10.Text = "Notas de 10:";
            // 
            // lbl_Notas20
            // 
            this.lbl_Notas20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Notas20.AutoSize = true;
            this.lbl_Notas20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Notas20.Location = new System.Drawing.Point(5, 75);
            this.lbl_Notas20.Name = "lbl_Notas20";
            this.lbl_Notas20.Size = new System.Drawing.Size(94, 16);
            this.lbl_Notas20.TabIndex = 4;
            this.lbl_Notas20.Text = "Notas de 20:";
            // 
            // lbl_Notas50
            // 
            this.lbl_Notas50.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Notas50.AutoSize = true;
            this.lbl_Notas50.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Notas50.Location = new System.Drawing.Point(5, 50);
            this.lbl_Notas50.Name = "lbl_Notas50";
            this.lbl_Notas50.Size = new System.Drawing.Size(94, 16);
            this.lbl_Notas50.TabIndex = 3;
            this.lbl_Notas50.Text = "Notas de 50:";
            // 
            // lbl_Notas100
            // 
            this.lbl_Notas100.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Notas100.AutoSize = true;
            this.lbl_Notas100.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Notas100.Location = new System.Drawing.Point(5, 25);
            this.lbl_Notas100.Name = "lbl_Notas100";
            this.lbl_Notas100.Size = new System.Drawing.Size(102, 16);
            this.lbl_Notas100.TabIndex = 2;
            this.lbl_Notas100.Text = "Notas de 100:";
            // 
            // lbl_SaldoDisponivel
            // 
            this.lbl_SaldoDisponivel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_SaldoDisponivel.AutoSize = true;
            this.lbl_SaldoDisponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SaldoDisponivel.Location = new System.Drawing.Point(212, 60);
            this.lbl_SaldoDisponivel.Name = "lbl_SaldoDisponivel";
            this.lbl_SaldoDisponivel.Size = new System.Drawing.Size(131, 16);
            this.lbl_SaldoDisponivel.TabIndex = 2;
            this.lbl_SaldoDisponivel.Text = "Saldo R$17523,00";
            this.lbl_SaldoDisponivel.Click += new System.EventHandler(this.Lbl_ValorSacar_Click);
            // 
            // btn_Sacar
            // 
            this.btn_Sacar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Sacar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sacar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sacar.Location = new System.Drawing.Point(220, 185);
            this.btn_Sacar.Name = "btn_Sacar";
            this.btn_Sacar.Size = new System.Drawing.Size(117, 41);
            this.btn_Sacar.TabIndex = 3;
            this.btn_Sacar.Text = "Sacar";
            this.btn_Sacar.UseVisualStyleBackColor = true;
            this.btn_Sacar.Click += new System.EventHandler(this.Btn_Sacar_Click);
            // 
            // txt_ValorSacar
            // 
            this.txt_ValorSacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_ValorSacar.Location = new System.Drawing.Point(236, 8);
            this.txt_ValorSacar.Name = "txt_ValorSacar";
            this.txt_ValorSacar.Size = new System.Drawing.Size(107, 22);
            this.txt_ValorSacar.TabIndex = 4;
            this.txt_ValorSacar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_ValorSacar_KeyDown);
            // 
            // btnTeste
            // 
            this.btnTeste.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTeste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeste.Location = new System.Drawing.Point(215, 104);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(117, 41);
            this.btnTeste.TabIndex = 5;
            this.btnTeste.Text = "Teste";
            this.btnTeste.UseVisualStyleBackColor = true;
            this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
            // 
            // Frm_SacarDinheiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 236);
            this.Controls.Add(this.btnTeste);
            this.Controls.Add(this.txt_ValorSacar);
            this.Controls.Add(this.btn_Sacar);
            this.Controls.Add(this.lbl_SaldoDisponivel);
            this.Controls.Add(this.gpb_Resultado);
            this.Controls.Add(this.lbl_ValorSacar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(365, 275);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(365, 275);
            this.Name = "Frm_SacarDinheiro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Software de Sacar Dinheiro";
            this.Click += new System.EventHandler(this.Lbl_ValorSacar_Click);
            this.gpb_Resultado.ResumeLayout(false);
            this.gpb_Resultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ValorSacar;
        private System.Windows.Forms.GroupBox gpb_Resultado;
        private System.Windows.Forms.Button btn_Sacar;
        private System.Windows.Forms.Label lbl_SaldoDisponivel;
        private System.Windows.Forms.Label lbl_Moedas1;
        private System.Windows.Forms.Label lbl_Notas2;
        private System.Windows.Forms.Label lbl_Notas5;
        private System.Windows.Forms.Label lbl_Notas10;
        private System.Windows.Forms.Label lbl_Notas20;
        private System.Windows.Forms.Label lbl_Notas50;
        private System.Windows.Forms.Label lbl_Notas100;
        private System.Windows.Forms.TextBox txt_ValorSacar;
        private System.Windows.Forms.Button btnTeste;
    }
}

