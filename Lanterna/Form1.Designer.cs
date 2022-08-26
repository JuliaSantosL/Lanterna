namespace Lanterna
{
    partial class Lanterna
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lanterna));
            this.Bateria = new System.Windows.Forms.ProgressBar();
            this.Ligado = new System.Windows.Forms.Button();
            this.Desligado = new System.Windows.Forms.Button();
            this.PercentualBateria = new System.Windows.Forms.TextBox();
            this.Status = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TocarBateria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bateria
            // 
            this.Bateria.BackColor = System.Drawing.SystemColors.ControlText;
            this.Bateria.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Bateria.Location = new System.Drawing.Point(12, 103);
            this.Bateria.MarqueeAnimationSpeed = 1;
            this.Bateria.Name = "Bateria";
            this.Bateria.Size = new System.Drawing.Size(283, 34);
            this.Bateria.TabIndex = 0;
            this.Bateria.Value = 100;
            // 
            // Ligado
            // 
            this.Ligado.Location = new System.Drawing.Point(12, 180);
            this.Ligado.Name = "Ligado";
            this.Ligado.Size = new System.Drawing.Size(75, 23);
            this.Ligado.TabIndex = 1;
            this.Ligado.Text = "Ligado";
            this.Ligado.UseVisualStyleBackColor = true;
            this.Ligado.Click += new System.EventHandler(this.Ligado_Click);
            // 
            // Desligado
            // 
            this.Desligado.BackColor = System.Drawing.Color.Red;
            this.Desligado.Location = new System.Drawing.Point(220, 180);
            this.Desligado.Name = "Desligado";
            this.Desligado.Size = new System.Drawing.Size(75, 23);
            this.Desligado.TabIndex = 2;
            this.Desligado.Text = "Desligado";
            this.Desligado.UseVisualStyleBackColor = false;
            this.Desligado.Click += new System.EventHandler(this.Desligado_Click);
            // 
            // PercentualBateria
            // 
            this.PercentualBateria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PercentualBateria.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PercentualBateria.Location = new System.Drawing.Point(124, 143);
            this.PercentualBateria.Name = "PercentualBateria";
            this.PercentualBateria.Size = new System.Drawing.Size(38, 13);
            this.PercentualBateria.TabIndex = 3;
            this.PercentualBateria.Text = "100 %";
            this.PercentualBateria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Status
            // 
            this.Status.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Status.AutoSize = true;
            this.Status.BackColor = System.Drawing.Color.Red;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.Location = new System.Drawing.Point(13, 28);
            this.Status.Name = "Status";
            this.Status.Padding = new System.Windows.Forms.Padding(28, 10, 10, 20);
            this.Status.Size = new System.Drawing.Size(282, 72);
            this.Status.TabIndex = 4;
            this.Status.Text = "DESLIGADO";
            this.Status.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TocarBateria
            // 
            this.TocarBateria.Location = new System.Drawing.Point(86, 209);
            this.TocarBateria.Name = "TocarBateria";
            this.TocarBateria.Size = new System.Drawing.Size(137, 23);
            this.TocarBateria.TabIndex = 5;
            this.TocarBateria.Text = "Trocar Bateria";
            this.TocarBateria.UseVisualStyleBackColor = true;
            this.TocarBateria.Click += new System.EventHandler(this.TocarBateria_Click);
            // 
            // Lanterna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(307, 245);
            this.Controls.Add(this.TocarBateria);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.PercentualBateria);
            this.Controls.Add(this.Desligado);
            this.Controls.Add(this.Ligado);
            this.Controls.Add(this.Bateria);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lanterna";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar Bateria;
        private System.Windows.Forms.Button Ligado;
        private System.Windows.Forms.Button Desligado;
        private System.Windows.Forms.TextBox PercentualBateria;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button TocarBateria;
    }
}

