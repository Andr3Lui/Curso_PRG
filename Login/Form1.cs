using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;

namespace Login
{
    public partial class Formulario_login : Form
    {

        List<string> listaUsuarios = new List<string>() { "Neymar.jr", "Pablo.Vitar", "Sukuna.Silva" };
        List<string> listaSenhas = new List<string>() { "bruna", "12345", "777" };
        List<string> listamin = new List<string>() {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        List<string> listamais = new List<string>() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        List<string> listanum = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        List<string> listacarac = new List<string>() { "!", "@", "#", "$", "%", "&", "*", "/", "{", "}", "[", "]"};




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
                _ = labelResultado.Text = "E-mail � obrigat�ria";
                labelResultado.ForeColor = Color.Red;
                return;
            }
            if (senha == null || senha == "")
            {
                _ = labelResultado.Text = "Senha � obrigat�ria";
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
          //string caractereEspecial = ("@!#$%&*{}[]?/|_-");

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
            /*
            if (novaSenha.Length < 8)
            {
                _ = labResultado.Text = "A senha deve ter ao menos 8 caracteres";
                labResultado.ForeColor = Color.Red;
                return;
            }
            if (!novaSenha.Any(char.IsUpper))
            {
                _ = labResultado.Text = "A senha deve ter ao menos 1 letra mai�scula";
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
                _ = labResultado.Text = "A senha deve ter ao menos 1 n�mero";
                labResultado.ForeColor = Color.Red;
                return;
            }

            if (!novaSenha.Any(c => caractereEspecial.Contains(c)))
            {
                _ = labResultado.Text = "A senha deve ter ao menos 1 caractere especial";
                labResultado.ForeColor = Color.Red;
                return;
            }
            */

            bool letraMin = false;
            bool letraMai = false;
            bool umNum = false;
            bool umCar = false;

            if (novaSenha.Length < 8)
            {
                _ = labResultado.Text = "A senha deve conter ao menos 8 caracteres";
                labResultado.ForeColor = Color.Red;
            }

            for (int i = 0; i < listamin.Count; i++)
            {
                if ( novaSenha == listamin[i])
                {
                    letraMin = true;
                    labResultado.Text = "A senha deve haver ao menos 1 letra min�scula";
                    labResultado.ForeColor = Color.Red;
                    return;
                }
                
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
                labResultado.Text = "Usuario j� existente";
                labResultado.ForeColor = Color.Red;
            }


        }

    }
}
