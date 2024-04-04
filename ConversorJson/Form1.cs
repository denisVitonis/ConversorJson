using System;
using System.IO;
using System.Windows.Forms;

namespace ConversorJson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Arquivos CSV (*.csv)|*.csv|Todos os arquivos (*.*)|*.*";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtCsvFilePath.Text = openFileDialog.FileName;
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string csvFilePath = txtCsvFilePath.Text;
            string entidade = txtEntidade.Text;
            string competencia = txtCompetencia.Text;

            if (File.Exists(csvFilePath))
            {
                // Chama o método ConvertToJSON da classe Conversor
                string jsonString = Conversor.ConvertToJSON(File.ReadAllText(csvFilePath), entidade, competencia);

                if (jsonString != null)
                {
                    // Exibe a string JSON em uma nova janela
                    MessageBox.Show(jsonString, "JSON Convertido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao converter o arquivo CSV para JSON.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("O arquivo CSV especificado não foi encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
