
namespace CRUD
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnovo = new System.Windows.Forms.Button();
            this.bteditar = new System.Windows.Forms.Button();
            this.btconsultar = new System.Windows.Forms.Button();
            this.btexibir = new System.Windows.Forms.Button();
            this.btexcluir = new System.Windows.Forms.Button();
            this.nometxt = new System.Windows.Forms.TextBox();
            this.sobrenometxt = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SOBRENOME";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(762, 201);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnovo
            // 
            this.btnovo.Location = new System.Drawing.Point(29, 115);
            this.btnovo.Name = "btnovo";
            this.btnovo.Size = new System.Drawing.Size(109, 24);
            this.btnovo.TabIndex = 4;
            this.btnovo.Text = "Novo";
            this.btnovo.UseVisualStyleBackColor = true;
            this.btnovo.Click += new System.EventHandler(this.button1_Click);
            // 
            // bteditar
            // 
            this.bteditar.Location = new System.Drawing.Point(180, 115);
            this.bteditar.Name = "bteditar";
            this.bteditar.Size = new System.Drawing.Size(109, 24);
            this.bteditar.TabIndex = 5;
            this.bteditar.Text = "Editar";
            this.bteditar.UseVisualStyleBackColor = true;
            this.bteditar.Click += new System.EventHandler(this.bteditar_Click);
            // 
            // btconsultar
            // 
            this.btconsultar.Location = new System.Drawing.Point(331, 115);
            this.btconsultar.Name = "btconsultar";
            this.btconsultar.Size = new System.Drawing.Size(109, 24);
            this.btconsultar.TabIndex = 6;
            this.btconsultar.Text = "Consultar";
            this.btconsultar.UseVisualStyleBackColor = true;
            this.btconsultar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btexibir
            // 
            this.btexibir.Location = new System.Drawing.Point(493, 115);
            this.btexibir.Name = "btexibir";
            this.btexibir.Size = new System.Drawing.Size(109, 24);
            this.btexibir.TabIndex = 7;
            this.btexibir.Text = "Exibir";
            this.btexibir.UseVisualStyleBackColor = true;
            this.btexibir.Click += new System.EventHandler(this.button4_Click);
            // 
            // btexcluir
            // 
            this.btexcluir.Location = new System.Drawing.Point(667, 115);
            this.btexcluir.Name = "btexcluir";
            this.btexcluir.Size = new System.Drawing.Size(109, 24);
            this.btexcluir.TabIndex = 8;
            this.btexcluir.Text = "Excluir";
            this.btexcluir.UseVisualStyleBackColor = true;
            this.btexcluir.Click += new System.EventHandler(this.btexcluir_Click);
            // 
            // nometxt
            // 
            this.nometxt.Location = new System.Drawing.Point(105, 53);
            this.nometxt.Name = "nometxt";
            this.nometxt.Size = new System.Drawing.Size(228, 20);
            this.nometxt.TabIndex = 9;
            // 
            // sobrenometxt
            // 
            this.sobrenometxt.Location = new System.Drawing.Point(105, 82);
            this.sobrenometxt.Name = "sobrenometxt";
            this.sobrenometxt.Size = new System.Drawing.Size(228, 20);
            this.sobrenometxt.TabIndex = 10;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(105, 23);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(228, 20);
            this.txtID.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.sobrenometxt);
            this.Controls.Add(this.nometxt);
            this.Controls.Add(this.btexcluir);
            this.Controls.Add(this.btexibir);
            this.Controls.Add(this.btconsultar);
            this.Controls.Add(this.bteditar);
            this.Controls.Add(this.btnovo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnovo;
        private System.Windows.Forms.Button bteditar;
        private System.Windows.Forms.Button btconsultar;
        private System.Windows.Forms.Button btexibir;
        private System.Windows.Forms.Button btexcluir;
        private System.Windows.Forms.TextBox nometxt;
        private System.Windows.Forms.TextBox sobrenometxt;
        private System.Windows.Forms.TextBox txtID;
    }
}

