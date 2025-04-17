using ListaAtividades.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaAtividades
{
    public partial class CriarAtividades : Form
    {
        public CriarAtividades()
        {
            InitializeComponent();
        }

        private void buttonDescartar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void CriarAtividades_Load(object sender, EventArgs e)
        {
            labelErro.Text = string.Empty;
        }

        private void buttonCriarAtividade_Click(object sender, EventArgs e)
        {
            Atividade atividade = new()
            {
                Titulo = textBoxTitulo.Text,
            };

            if (!atividade.Criar())
            {
                labelErro.Text = "Não foi possível criar atividade";
                labelErro.ForeColor = Color.Red;
                return;
            }
            

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
