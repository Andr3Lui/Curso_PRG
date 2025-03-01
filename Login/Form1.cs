using System.Diagnostics.Eventing.Reader;

namespace Login
{
    public partial class Formulario_login : Form
    {

        List<string> listaUsuarios = new List<string>() { "Neymar.jr", "Pablo.Vitar", "Sukuna.Silva" };
        List<string> listaSenhas = new List<string>() { "bruna", "12345", "777" };

        public Formulario_login()
        {
            InitializeComponent();
        }

        private void Logar_Click(object sender, EventArgs e)
        {
            string usuarioBuscado = textBoxUsuario.Text;
            string senha = textBoxSenha.Text;
            int posicaoUsuarioEncontrado = -1;


            //MODOS DIFERENTES DE EXERCUTAR UM PROGRAMA COM DIFERENTES FORMULAS.

            /*
            if (usuarioBuscado == null || usuarioBuscado == "")
            {
                labelResultado.Text = "Usuário é obrigatório!";
                labelResultado.ForeColor = Color.Red;
            }
            else if (senha == null || senha == "")
            {
                labelResultado.Text = "Senha é obrigatória";
                labelResultado.ForeColor = Color.Red;
            }
            else if (usuarioBuscado == "andre.luiz" && senha == "1234")
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
            */



            if (usuarioBuscado == null || usuarioBuscado == "")
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

            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                if (usuarioBuscado == listaUsuarios[i])
                {
                    posicaoUsuarioEncontrado = i;
                }

            }

            //f (usuarioBuscado == listaUsuarios[posicaoUsuarioEncontrado] && senha == "1234")
            //NÃO FUNCIONA, USUARIO AQUI É O PRINCIPAL POR TANTO "usuarioBuscado" ou "listaUsuarios" NÃO É NECESSARIO
            //HÁ A NECESSIDADE DE MUDAR RESULTADO DE USUARIO PARA"!=" POIS ASSIM O PROGRAMA NÃO APLICARÁ UMA EXEÇÃO EM MEIO A EXECUÇÃO
            //E CASSO O USUARIO NÃO SEJA ENCONTRADO, NÃO HAVERÁ ERRO POR NÃO SER ASSOCIADO A UM NUMERO INEXISTENTE NA LISTA QUE É "-1"

            if (posicaoUsuarioEncontrado != -1 && senha == listaSenhas[posicaoUsuarioEncontrado])
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
        private void BotaoCriar_Click(object sender, EventArgs e)
        {
            string novoUsuario = txbCadUsu.Text;
            string novaSenha = txbCadSen.Text;
            bool usuarioEncontrado = false;

            if (string.IsNullOrWhiteSpace(novoUsuario))
            {
                _ = labResultado.Text = "Crie um E-mail" +
                    "";
                labResultado.ForeColor = Color.Red;
                return;
            }
            if (string.IsNullOrWhiteSpace(novaSenha))
            {
                _ = labResultado.Text = "Crie uma senha";
                labResultado.ForeColor = Color.Red;
                return;
            }

            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                if (novoUsuario == listaUsuarios[i])
                {
                    usuarioEncontrado = true;
                }

            }

            if (!usuarioEncontrado)
            {
                listaUsuarios.Add(novoUsuario);
                listaSenhas.Add(novaSenha);
                labResultado.Text = "Criado com sucesso!";
                labResultado.ForeColor = Color.Green;
            }
            else
            {
                labResultado.Text = "Usuario já existente";
                labResultado.ForeColor = Color.Red;
            }
        }

    }
}
