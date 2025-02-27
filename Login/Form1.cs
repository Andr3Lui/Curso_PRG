using System.Diagnostics.Eventing.Reader;

namespace Login
{
    public partial class Formulario_login : Form
    {
        public Formulario_login()
        {
            InitializeComponent();
        }

        private void Logar_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text;
            string senha = textBoxSenha.Text;
            /*

            if (usuario == null || usuario == "")
            {
                labelResultado.Text = "Usuário é obrigatório!";
                labelResultado.ForeColor = Color.Red;
            }
            else if (senha == null || senha == "")
            {
                labelResultado.Text = "Senha é obrigatória";
                labelResultado.ForeColor = Color.Red;
            }
            else if (usuario == "andre.luiz" && senha == "1234")
            {
                labelResultado.Text = "Autenticado com Sucesso!";
                labelResultado.ForeColor = Color.Green; 
            }
            else
            {
                labelResultado.Text = "Usuário ou senha Incorreto";
                labelResultado.ForeColor = Color.Red;
            }
            */



            if (string.IsNullOrWhiteSpace(usuario))
            {
                _ = labelResultado.Text = "E-mail é obrigatória";
                labelResultado.ForeColor = Color.Red;
                return;
            }

            if (senha == null || senha == "")
            {
                _ = labelResultado.Text = "Senha é obrigatória";
                labelResultado.ForeColor = Color.Red;

            }
            else if (usuario == "andre.luiz" && senha == "1234")
            {
                labelResultado.Text = "Autenticado com Sucesso!";
                labelResultado.ForeColor = Color.Green;

            }
            else
            {
                labelResultado.Text = "Usuário ou senha Incorreto";
                labelResultado.ForeColor = Color.Red;
            }



            /*
            if (usuario == null || usuario == "" )
            {
                _ = labelResultado.Text = "E-mail é obrigatória";
                labelResultado.ForeColor = Color.Red;
                return;
            }
            if (senha == null || senha == "")
            {
                _ = labelResultado.Text = "Senha é obrigatória";
                labelResultado.ForeColor = Color.Red;
                return;
            }

            if ( usuario == "andre.luiz" && senha == "1234")
            {
                labelResultado.Text = "Autenticado com Sucesso!";
                labelResultado.ForeColor = Color.Green;
                
            }
            else
            {
                labelResultado.Text = "Usuário ou senha Incorreto";
                labelResultado.ForeColor = Color.Red;
            }
            */



            /*
            if (usuario == string.Empty || senha == string.Empty)
            {

                labelResultado.Text = "E-mail e senha obrigatório(s)";
                labelResultado.ForeColor = Color.Red;
                return;
            }  
            if (usuario == "andre.luiz" && senha == "1234")
            {
                labelResultado.Text = "Autenticado com Sucesso!";
                labelResultado.ForeColor = Color.Green;

            }
            else
            {
                labelResultado.Text = "Usuário ou senha Incorreto";
                labelResultado.ForeColor = Color.Red;
            }
            */


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
