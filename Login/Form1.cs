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

            if (usuario == null || usuario == "")
            {
                labelResultado.Text = "Usu�rio � obrigat�rio!";
                labelResultado.ForeColor = Color.Red;
            }
            else if (usuario == "andre.luiz" && senha == "1234")
            {
                labelResultado.Text = "Autenticado com Sucesso!";
                labelResultado.ForeColor = Color.Green; 
            }
            else
            {
                labelResultado.Text = "Usu�rio ou senha Incorreto";
                labelResultado.ForeColor = Color.Red;

                
            }
        }

    }
}
