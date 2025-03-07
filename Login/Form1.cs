using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;

namespace Login
{
    public partial class Formulario_login : Form
    {

        List<string> listaUsuarios = new List<string>() { "Neymar.jr", "Pablo.Vitar", "Sukuna.Silva" };
        List<string> listaSenhas = new List<string>() { "Bruna22@", "paBlito_17", "Itad0r!" };
       
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
                labelResultado.Text = "Usu�rio � obrigat�rio!";
                labelResultado.ForeColor = Color.Red;
            }
            else if (senha == null || senha == "")
            {
                labelResultado.Text = "Senha � obrigat�ria";
                labelResultado.ForeColor = Color.Red;
            }
            else if (usuarioBuscado == "andre.luiz" && senha == "1234")
            {
                labelResultado.Text = "Autenticado com Sucesso!";
                labelResultado.ForeColor = Color.Green; 
            }
            else
            {
                labelResultado.Text = "Usu�rio ou senha Incorreto";
                labelResultado.ForeColor = Color.Red;
            }
            */


            /*
            if (string.IsNullOrWhiteSpace(usuario))
            {
                _ = labelResultado.Text = "E-mail � obrigat�ria";
                labelResultado.ForeColor = Color.Red;
                return;
            }

            if (senha == null || senha == "")
            {
                _ = labelResultado.Text = "Senha � obrigat�ria";
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
            */



            if (usuarioBuscado == null || usuarioBuscado == "")
            {
                labelResultado.Text = "E-mail � obrigat�ria";
                labelResultado.ForeColor = Color.Red;
                return;
            }
            if (senha == null || senha == "")
            {
                labelResultado.Text = "Senha � obrigat�ria";
                labelResultado.ForeColor = Color.Red;
                return;
            }

            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                if (usuarioBuscado == listaUsuarios[i])
                {
                    posicaoUsuarioEncontrado = i;
                }
                continue;
            }

            //f (usuarioBuscado == listaUsuarios[posicaoUsuarioEncontrado] && senha == "1234")
            //N�O FUNCIONA, USUARIO AQUI � O PRINCIPAL POR TANTO "usuarioBuscado" ou "listaUsuarios" N�O � NECESSARIO
            //H� A NECESSIDADE DE MUDAR RESULTADO DE USUARIO PARA"!=" POIS ASSIM O PROGRAMA N�O APLICAR� UMA EXE��O EM MEIO A EXECU��O
            //E CASSO O USUARIO N�O SEJA ENCONTRADO, N�O HAVER� ERRO POR N�O SER ASSOCIADO A UM NUMERO INEXISTENTE NA LISTA QUE � "-1"

            if (posicaoUsuarioEncontrado != -1 && senha == listaSenhas[posicaoUsuarioEncontrado])
            {
                labelResultado.Text = "Autenticado com Sucesso!";
                labelResultado.ForeColor = Color.Green;

            }
            else
            {
                labelResultado.Text = "Usu�rio ou senha Incorreto";
                labelResultado.ForeColor = Color.Red;
            }




            /*
            if (usuario == string.Empty || senha == string.Empty)
            {

                labelResultado.Text = "E-mail e senha obrigat�rio(s)";
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
                labelResultado.Text = "Usu�rio ou senha Incorreto";
                labelResultado.ForeColor = Color.Red;
            }
            */


        }
        private void BotaoCriar_Click(object sender, EventArgs e)
        {
            string novoUsuario = txbCadUsu.Text;
            string novaSenha = txbCadSen.Text;
            bool usuarioEncontrado = false;
            string caractereEspecial = ("@!#$%&*{}[]?/|_-");

            if (string.IsNullOrWhiteSpace(novoUsuario))
            {
                labResultado.Text = "Crie um E-mail" +
                    "";
                labResultado.ForeColor = Color.Red;
                return;
            }
            if (string.IsNullOrWhiteSpace(novaSenha))
            {
                labResultado.Text = "Crie uma senha";
                labResultado.ForeColor = Color.Red;
                return;
            }


            //UMA FORMA EFICIENTE DE EXIGIR UM CARACTERE EXPECIFICO AO USUARIO QUE DEVA SER INCLUSO A SENHA 
            //P�REM "Regex" PARECE SER UM METODO UM TANTO COMPLEXO DE SE ENTENDER, SERIA IDEAL ESTUDAR SOBRE ISSO DEPOIS.
            /*
            if (!Regex.IsMatch(novaSenha, "[A-Z], [a-z], [0-9],[/*._@!#$%&*]"))
            {
                _ = labResultado.Text = "A senha deve ter ao menos 1 letra mai�scula";
                _ = labResultado.Text = "A senha deve ter ao menos 1 letra min�scula";
                _ = labResultado.Text = "A senha deve ter ao menos 1 n�mero";
                _ = labResultado.Text = "A senha deve ter ao menos 1 caractere especial";
                labResultado.ForeColor = Color.Red;
                return;
            }
            if(!Regex.IsMatch(novaSenha, "[A-Z]"))
            {
                _ = labResultado.Text = "A senha deve ter ao menos 1 letra mai�scula";
                labResultado.ForeColor = Color.Red;
                return;
            }

            if (!Regex.IsMatch(novaSenha, "[a-z]"))
            {
                _ = labResultado.Text = "A senha deve ter ao menos 1 letra min�scula";
                labResultado.ForeColor = Color.Red;
                return;
            }

            if (!Regex.IsMatch(novaSenha, "[0-9]"))
            {
                _ = labResultado.Text = "A senha deve ter ao menos 1 n�mero";
                labResultado.ForeColor = Color.Red;
                return;
            }

            if (!Regex.IsMatch(novaSenha, "[/*._@!#$%&*]"))
            {
                _ = labResultado.Text = "A senha deve ter ao menos 1 caractere especial";
                labResultado.ForeColor = Color.Red;
                return;
            }
            */
            
            if (novaSenha.Length < 8)
            {
                labResultado.Text = "A senha deve ter ao menos 8 caracteres";
                labResultado.ForeColor = Color.Red;
                return;
            }
            if (!novaSenha.Any(char.IsUpper))
            {
                labResultado.Text = "A senha deve ter ao menos 1 letra mai�scula";
                labResultado.ForeColor = Color.Red;
                return;
            }
            if (!novaSenha.Any(char.IsLower))
            {
                _ = labResultado.Text = "A senha deve ter ao menos 1 letra min�scula";
                labResultado.ForeColor = Color.Red;
                return;
            }
            if (!novaSenha.Any(char.IsNumber))
            {
                labResultado.Text = "A senha deve ter ao menos 1 n�mero";
                labResultado.ForeColor = Color.Red;
                return;
            }
            //UMA SOLU��O FEITA COM LAMINA, CRIANDO UMA SOLU��O.
            /*if (!novaSenha.Any(c => caractereEspecial.Contains(c)))
            {
                labResultado.Text = "A senha deve ter ao menos 1 caractere especial";
                labResultado.ForeColor = Color.Red;
                return;
            }
            */
            if(!novaSenha.Any(char.IsSymbol) && !novaSenha.Any(char.IsPunctuation) && !novaSenha.Contains("@"))
            {
                labResultado.Text = "A senha deve ter ao menos 1 caractere especial";
                labResultado.ForeColor = Color.Red;
                return;
            }
            if (novaSenha.Any(char.IsWhiteSpace))
            {
                labResultado.Text = "A senha n�o pode ter espa�os em branco";
                labResultado.ForeColor = Color.Red;
                return;
            }
            
            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                if (novoUsuario == listaUsuarios[i])
                {
                    usuarioEncontrado = true;
                }
                continue;
            }
            if (!usuarioEncontrado)
            {
                listaUsuarios.Add(novoUsuario);
                listaSenhas.Add(novaSenha);
                labResultado.Text = "Criado com sucesso!";
                labResultado.ForeColor = Color.Green;
                txbCadUsu.Clear();
                txbCadSen.Clear();
            }
            else
            {
                labResultado.Text = "Usuario j� existente";
                labResultado.ForeColor = Color.Red;
            }


        }

    }
}
