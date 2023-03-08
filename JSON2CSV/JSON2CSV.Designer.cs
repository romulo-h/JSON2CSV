namespace JSON2CSV
{
	partial class JSON2CSV
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
			this.txbJSON = new System.Windows.Forms.TextBox();
			this.txbCSV = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnConverter = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.lblErro = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txbJSON
			// 
			this.txbJSON.BackColor = System.Drawing.SystemColors.Window;
			this.txbJSON.Location = new System.Drawing.Point(77, 29);
			this.txbJSON.Multiline = true;
			this.txbJSON.Name = "txbJSON";
			this.txbJSON.Size = new System.Drawing.Size(633, 89);
			this.txbJSON.TabIndex = 0;
			// 
			// txbCSV
			// 
			this.txbCSV.Location = new System.Drawing.Point(77, 139);
			this.txbCSV.Multiline = true;
			this.txbCSV.Name = "txbCSV";
			this.txbCSV.Size = new System.Drawing.Size(633, 89);
			this.txbCSV.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "JSON";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(25, 142);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(28, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "CSV";
			// 
			// btnConverter
			// 
			this.btnConverter.Location = new System.Drawing.Point(288, 253);
			this.btnConverter.Name = "btnConverter";
			this.btnConverter.Size = new System.Drawing.Size(75, 23);
			this.btnConverter.TabIndex = 4;
			this.btnConverter.Text = "Converter";
			this.btnConverter.UseVisualStyleBackColor = true;
			this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
			// 
			// btnLimpar
			// 
			this.btnLimpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnLimpar.Location = new System.Drawing.Point(390, 253);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(75, 23);
			this.btnLimpar.TabIndex = 5;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// lblErro
			// 
			this.lblErro.AutoSize = true;
			this.lblErro.ForeColor = System.Drawing.Color.Red;
			this.lblErro.Location = new System.Drawing.Point(311, 121);
			this.lblErro.Name = "lblErro";
			this.lblErro.Size = new System.Drawing.Size(0, 13);
			this.lblErro.TabIndex = 6;
			this.lblErro.Visible = false;
			// 
			// JSON2CSV
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(747, 309);
			this.Controls.Add(this.lblErro);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnConverter);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txbCSV);
			this.Controls.Add(this.txbJSON);
			this.Name = "JSON2CSV";
			this.Text = "JSON2CSV";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txbJSON;
		private System.Windows.Forms.TextBox txbCSV;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnConverter;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Label lblErro;
	}
}

