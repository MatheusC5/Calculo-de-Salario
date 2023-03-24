namespace CalcularSalario
{
    partial class Form1
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
            this.TxtHorasExtras = new System.Windows.Forms.TextBox();
            this.LblHorasExtras = new System.Windows.Forms.Label();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.LblCalculoSalario = new System.Windows.Forms.Label();
            this.TxtSalarioMes = new System.Windows.Forms.TextBox();
            this.TxtValorHora = new System.Windows.Forms.TextBox();
            this.TxtHorasTrabalhadas = new System.Windows.Forms.TextBox();
            this.BtnCalcularSalario = new System.Windows.Forms.Button();
            this.LblValorHora = new System.Windows.Forms.Label();
            this.LblHorasTrabalhadas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtHorasExtras
            // 
            this.TxtHorasExtras.Location = new System.Drawing.Point(421, 184);
            this.TxtHorasExtras.Name = "TxtHorasExtras";
            this.TxtHorasExtras.Size = new System.Drawing.Size(154, 22);
            this.TxtHorasExtras.TabIndex = 40;
            this.TxtHorasExtras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtHorasExtras_KeyDown);
            this.TxtHorasExtras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtHorasExtras_KeyPress);
            // 
            // LblHorasExtras
            // 
            this.LblHorasExtras.AutoSize = true;
            this.LblHorasExtras.Location = new System.Drawing.Point(225, 184);
            this.LblHorasExtras.Name = "LblHorasExtras";
            this.LblHorasExtras.Size = new System.Drawing.Size(87, 16);
            this.LblHorasExtras.TabIndex = 39;
            this.LblHorasExtras.Text = "Horas Extras:";
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(62)))));
            this.BtnLimpar.Location = new System.Drawing.Point(228, 301);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(145, 49);
            this.BtnLimpar.TabIndex = 38;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // LblCalculoSalario
            // 
            this.LblCalculoSalario.AutoSize = true;
            this.LblCalculoSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCalculoSalario.Location = new System.Drawing.Point(310, 33);
            this.LblCalculoSalario.Name = "LblCalculoSalario";
            this.LblCalculoSalario.Size = new System.Drawing.Size(199, 29);
            this.LblCalculoSalario.TabIndex = 37;
            this.LblCalculoSalario.Text = "Calcular Salário";
            // 
            // TxtSalarioMes
            // 
            this.TxtSalarioMes.Enabled = false;
            this.TxtSalarioMes.Location = new System.Drawing.Point(315, 395);
            this.TxtSalarioMes.Name = "TxtSalarioMes";
            this.TxtSalarioMes.Size = new System.Drawing.Size(154, 22);
            this.TxtSalarioMes.TabIndex = 36;
            // 
            // TxtValorHora
            // 
            this.TxtValorHora.Location = new System.Drawing.Point(421, 242);
            this.TxtValorHora.Name = "TxtValorHora";
            this.TxtValorHora.Size = new System.Drawing.Size(154, 22);
            this.TxtValorHora.TabIndex = 35;
            this.TxtValorHora.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtValorHora_KeyDown);
            this.TxtValorHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorHora_KeyPress);
            // 
            // TxtHorasTrabalhadas
            // 
            this.TxtHorasTrabalhadas.Location = new System.Drawing.Point(421, 123);
            this.TxtHorasTrabalhadas.Name = "TxtHorasTrabalhadas";
            this.TxtHorasTrabalhadas.Size = new System.Drawing.Size(154, 22);
            this.TxtHorasTrabalhadas.TabIndex = 34;
            this.TxtHorasTrabalhadas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtHorasTrabalhadas_KeyDown);
            this.TxtHorasTrabalhadas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtHorasTrabalhadas_KeyPress);
            // 
            // BtnCalcularSalario
            // 
            this.BtnCalcularSalario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(255)))), ((int)(((byte)(74)))));
            this.BtnCalcularSalario.Location = new System.Drawing.Point(421, 301);
            this.BtnCalcularSalario.Name = "BtnCalcularSalario";
            this.BtnCalcularSalario.Size = new System.Drawing.Size(145, 49);
            this.BtnCalcularSalario.TabIndex = 33;
            this.BtnCalcularSalario.Text = "Calcular Salário";
            this.BtnCalcularSalario.UseVisualStyleBackColor = false;
            this.BtnCalcularSalario.Click += new System.EventHandler(this.BtnCalcularSalario_Click);
            // 
            // LblValorHora
            // 
            this.LblValorHora.AutoSize = true;
            this.LblValorHora.Location = new System.Drawing.Point(225, 242);
            this.LblValorHora.Name = "LblValorHora";
            this.LblValorHora.Size = new System.Drawing.Size(98, 16);
            this.LblValorHora.TabIndex = 32;
            this.LblValorHora.Text = "Valor por Hora:";
            // 
            // LblHorasTrabalhadas
            // 
            this.LblHorasTrabalhadas.AutoSize = true;
            this.LblHorasTrabalhadas.Location = new System.Drawing.Point(225, 123);
            this.LblHorasTrabalhadas.Name = "LblHorasTrabalhadas";
            this.LblHorasTrabalhadas.Size = new System.Drawing.Size(128, 16);
            this.LblHorasTrabalhadas.TabIndex = 31;
            this.LblHorasTrabalhadas.Text = "Horas Trabalhadas:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(255)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(842, 457);
            this.Controls.Add(this.TxtHorasExtras);
            this.Controls.Add(this.LblHorasExtras);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.LblCalculoSalario);
            this.Controls.Add(this.TxtSalarioMes);
            this.Controls.Add(this.TxtValorHora);
            this.Controls.Add(this.TxtHorasTrabalhadas);
            this.Controls.Add(this.BtnCalcularSalario);
            this.Controls.Add(this.LblValorHora);
            this.Controls.Add(this.LblHorasTrabalhadas);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtHorasExtras;
        private System.Windows.Forms.Label LblHorasExtras;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Label LblCalculoSalario;
        private System.Windows.Forms.TextBox TxtSalarioMes;
        private System.Windows.Forms.TextBox TxtValorHora;
        private System.Windows.Forms.TextBox TxtHorasTrabalhadas;
        private System.Windows.Forms.Button BtnCalcularSalario;
        private System.Windows.Forms.Label LblValorHora;
        private System.Windows.Forms.Label LblHorasTrabalhadas;
    }
}

