using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;

namespace Login
{
    public partial class Formulario_login : Form
    {
        List<Usuario1> usuarios = new List<Usuario1>();

        public Formulario_login()
        {
            InitializeComponent();
            usuarios.Add(new Usuario1() { Email = "neymar.jr@email.com", Senha = "Bruna22@" });
            usuarios.Add(new Usuario1() { Email = "pablo.vitar@email.com", Senha = "paBlito_17@" });
            usuarios.Add(new Usuario1() { Email = "sukuna.silva@email.com", Senha = "Itad0r!@" });
        }

        private void Logar_Click(object sender, EventArgs e)
        {

            string usuarioBuscado = textBoxUsuario.Text;
            string senha = textBoxSenha.Text;

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
            if (string.IsNullOrWhiteSpace(usuarioBuscado))
            {
                labelResultado.Text = "E-mail � obrigat�ria";
                labelResultado.ForeColor = Color.Red;
                return;
            }
            if (string.IsNullOrWhiteSpace(senha))
            {
                labelResultado.Text = "Senha � obrigat�ria";
                labelResultado.ForeColor = Color.Red;
                return;
            }


            /*
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
            */
            bool autenticado = false;
            /*
            int posicaoUsuarioEncontrado = -1 
            
            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                if(usuarioBuscado == listaUsuarios[i])
                {
                    posicaoUsuarioEncontrado = i;
                }
            }*/
            //f (usuarioBuscado == listaUsuarios[posicaoUsuarioEncontrado] && senha == "1234")
            //N�O FUNCIONA, USUARIO AQUI � O PRINCIPAL POR TANTO "usuarioBuscado" ou "listaUsuarios" N�O � NECESSARIO
            //H� A NECESSIDADE DE MUDAR RESULTADO DE USUARIO PARA"!=" POIS ASSIM O PROGRAMA N�O APLICAR� UMA EXE��O EM MEIO A EXECU��O
            //E CASSO O USUARIO N�O SEJA ENCONTRADO, N�O HAVER� ERRO POR N�O SER ASSOCIADO A UM NUMERO INEXISTENTE NA LISTA QUE � "-1"

            for (int i = 0; i < usuarios.Count; i++)
            {
                if (usuarios[i].Email == usuarioBuscado && usuarios[i].Senha == senha)
                {
                    autenticado = true;

                }
            }


            if (!autenticado)
            {
                labelResultado.Text = "Usuario ou senha incorretos";
                labelResultado.ForeColor = Color.Red;
                return;
            }
            else
            {
                labelResultado.Text = "Usuario Autenticado com sucesso";
                labelResultado.ForeColor = Color.Green;
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
            textBoxUsuario.Clear();
            textBoxSenha.Clear();
        }
        private void BotaoCriar_Click(object sender, EventArgs e)
        {
            string novoUsuario = txbCadUsu.Text;
            string novaSenha = txbCadSen.Text;

            //string caractereEspecial = ("@!#$%&*{}[]?/|_-");

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
            //UMA SOLU��O FEITA COM LAMINA, CRIANDO UM M�TODO.
            /*if (!novaSenha.Any(c => caractereEspecial.Contains(c)))
            {
                labResultado.Text = "A senha deve ter ao menos 1 caractere especial";
                labResultado.ForeColor = Color.Red;
                return;
            }
            */
            if (!novaSenha.Any(char.IsSymbol) && !novaSenha.Any(char.IsPunctuation) && !novaSenha.Contains("@"))
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

            bool usuarioEncontrado = false;
            for (int i = 0; i < usuarios.Count; i++)
            {
                if (usuarios[i].Email == novoUsuario)
                {
                    usuarioEncontrado = true;
                }
                continue;
            }
            if (usuarioEncontrado)
            {
                labResultado.Text = "Usuario j� existente";
                labResultado.ForeColor = Color.Red;
            }
            else
            {
                usuarios.Add(new Usuario1() { Email = novoUsuario, Senha = novaSenha });
                labelResultado.Text = "Usu�rio cadastrado com sucesso!";
                labelResultado.ForeColor = Color.Green;
            }
            txbCadUsu.Clear();
            txbCadSen.Clear();

        }

        private void EsqSenha_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void PrecAjuda_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
