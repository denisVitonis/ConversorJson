namespace ConversorJson
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtCsvFilePath = new System.Windows.Forms.TextBox();
            this.txtEntidade = new System.Windows.Forms.TextBox();
            this.txtCompetencia = new System.Windows.Forms.TextBox();
            this.lblCsvFilePath = new System.Windows.Forms.Label();
            this.lblEntidade = new System.Windows.Forms.Label();
            this.lblCompetencia = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCsvFilePath
            // 
            this.txtCsvFilePath.Location = new System.Drawing.Point(12, 32);
            this.txtCsvFilePath.Name = "txtCsvFilePath";
            this.txtCsvFilePath.Size = new System.Drawing.Size(200, 22);
            this.txtCsvFilePath.TabIndex = 0;
            // 
            // txtEntidade
            // 
            this.txtEntidade.Location = new System.Drawing.Point(12, 82);
            this.txtEntidade.Name = "txtEntidade";
            this.txtEntidade.Size = new System.Drawing.Size(200, 22);
            this.txtEntidade.TabIndex = 2;
            // 
            // txtCompetencia
            // 
            this.txtCompetencia.Location = new System.Drawing.Point(12, 132);
            this.txtCompetencia.Name = "txtCompetencia";
            this.txtCompetencia.Size = new System.Drawing.Size(200, 22);
            this.txtCompetencia.TabIndex = 3;
            // 
            // lblCsvFilePath
            // 
            this.lblCsvFilePath.AutoSize = true;
            this.lblCsvFilePath.Location = new System.Drawing.Point(12, 15);
            this.lblCsvFilePath.Name = "lblCsvFilePath";
            this.lblCsvFilePath.Size = new System.Drawing.Size(128, 16);
            this.lblCsvFilePath.TabIndex = 5;
            this.lblCsvFilePath.Text = "Caminho do Arquivo";
            // 
            // lblEntidade
            // 
            this.lblEntidade.AutoSize = true;
            this.lblEntidade.Location = new System.Drawing.Point(12, 65);
            this.lblEntidade.Name = "lblEntidade";
            this.lblEntidade.Size = new System.Drawing.Size(61, 16);
            this.lblEntidade.TabIndex = 6;
            this.lblEntidade.Text = "Entidade";
            // 
            // lblCompetencia
            // 
            this.lblCompetencia.AutoSize = true;
            this.lblCompetencia.Location = new System.Drawing.Point(12, 115);
            this.lblCompetencia.Name = "lblCompetencia";
            this.lblCompetencia.Size = new System.Drawing.Size(87, 16);
            this.lblCompetencia.TabIndex = 7;
            this.lblCompetencia.Text = "Competência";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(218, 130);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Converter";
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(218, 30);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(105, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Buscar Csv";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(382, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(504, 188);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtCompetencia);
            this.Controls.Add(this.lblCompetencia);
            this.Controls.Add(this.txtEntidade);
            this.Controls.Add(this.lblEntidade);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtCsvFilePath);
            this.Controls.Add(this.lblCsvFilePath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor CSV para JSON (Vitonis)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtCsvFilePath;
        private System.Windows.Forms.TextBox txtEntidade;
        private System.Windows.Forms.TextBox txtCompetencia;
        private System.Windows.Forms.Label lblCsvFilePath;
        private System.Windows.Forms.Label lblEntidade;
        private System.Windows.Forms.Label lblCompetencia;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
