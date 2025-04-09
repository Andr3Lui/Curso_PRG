using MySql.Data.MySqlClient;

namespace Login
{
    public partial class Formulario_login : Form
    {
        private static readonly string ConnectionString = "datasource=localhost;username=root;password=;database=senac;";
        private readonly MySqlConnection Connection = new MySqlConnection(ConnectionString);

       

        public Formulario_login()
        {
            InitializeComponent();
        }
        private void Logar_Click(object sender, EventArgs e)
        {

            string usuarioBuscado = textBoxUsuario.Text;
            string senha = textBoxSenha.Text;


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
            if (string.IsNullOrWhiteSpace(usuarioBuscado))
            {
                labelResultado.Text = "E-mail é obrigatória";
                labelResultado.ForeColor = Color.Red;
                return;
            }
            if (string.IsNullOrWhiteSpace(senha))
            {
                labelResultado.Text = "Senha é obrigatória";
                labelResultado.ForeColor = Color.Red;
                return;
            }


            /*
             if (usuarioBuscado == null || usuarioBuscado == "")
             {
                 labelResultado.Text = "E-mail é obrigatória";
                 labelResultado.ForeColor = Color.Red;
                 return;
             }
             if (senha == null || senha == "")
             {
                 labelResultado.Text = "Senha é obrigatória";
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
            /*
             * f (usuarioBuscado == listaUsuarios[posicaoUsuarioEncontrado] && senha == "1234")
            NÃO FUNCIONA, USUARIO AQUI É O PRINCIPAL POR TANTO "usuarioBuscado" ou "listaUsuarios" NÃO É NECESSARIO
            HÁ A NECESSIDADE DE MUDAR RESULTADO DE USUARIO PARA"!=" POIS ASSIM O PROGRAMA NÃO APLICARÁ UMA EXEÇÃO EM MEIO A EXECUÇÃO
            E CASSO O USUARIO NÃO SEJA ENCONTRADO, NÃO HAVERÁ ERRO POR NÃO SER ASSOCIADO A UM NUMERO INEXISTENTE NA LISTA QUE É "-1"*/

            /*for (int i = 0; i < usuarios.Count; i++)
            {
                if (usuarios[i].Email == usuarioBuscado && usuarios[i].Senha == senha)
                {
                    autenticado = true;

                }
            }*/
            try
            {
                Connection.Open();

                string query = $"SELECT senha FROM usuario  WHERE email = '{usuarioBuscado}';";

                MySqlCommand mySqlCommand = new MySqlCommand(query, Connection);
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                autenticado = reader.Read() && reader.GetString(0) == senha;
            }
            catch 
            {
                MessageBox.Show("Erro no Banco de Dados");
            }
            finally
            {
                Connection.Close();
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
            //PÓREM "Regex" PARECE SER UM METODO UM TANTO COMPLEXO DE SE ENTENDER, SERIA IDEAL ESTUDAR SOBRE ISSO DEPOIS.
            /*
            if (!Regex.IsMatch(novaSenha, "[A-Z], [a-z], [0-9],[/*._@!#$%&*]"))
            {
                _ = labResultado.Text = "A senha deve ter ao menos 1 letra maiúscula";
                _ = labResultado.Text = "A senha deve ter ao menos 1 letra minúscula";
                _ = labResultado.Text = "A senha deve ter ao menos 1 número";
                _ = labResultado.Text = "A senha deve ter ao menos 1 caractere especial";
                labResultado.ForeColor = Color.Red;
                return;
            }
            if(!Regex.IsMatch(novaSenha, "[A-Z]"))
            {
                _ = labResultado.Text = "A senha deve ter ao menos 1 letra maiúscula";
                labResultado.ForeColor = Color.Red;
                return;
            }

            if (!Regex.IsMatch(novaSenha, "[a-z]"))
            {
                _ = labResultado.Text = "A senha deve ter ao menos 1 letra minúscula";
                labResultado.ForeColor = Color.Red;
                return;
            }

            if (!Regex.IsMatch(novaSenha, "[0-9]"))
            {
                _ = labResultado.Text = "A senha deve ter ao menos 1 número";
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
                labResultado.Text = "A senha deve ter ao menos 1 letra maiúscula";
                labResultado.ForeColor = Color.Red;
                return;
            }
            if (!novaSenha.Any(char.IsLower))
            {
                _ = labResultado.Text = "A senha deve ter ao menos 1 letra minúscula";
                labResultado.ForeColor = Color.Red;
                return;
            }
            if (!novaSenha.Any(char.IsNumber))
            {
                labResultado.Text = "A senha deve ter ao menos 1 número";
                labResultado.ForeColor = Color.Red;
                return;
            }
            //UMA SOLUÇÃO FEITA COM LAMINA, CRIANDO UM MÉTODO.
            /*
             * if (!novaSenha.Any(c => caractereEspecial.Contains(c)))
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
                labResultado.Text = "A senha não pode ter espaços em branco";
                labResultado.ForeColor = Color.Red;
                return;
            }

            bool usuarioEncontrado = false;

            try
            {
                Connection.Open();

                string query = $"SELECT email FROM usuario  WHERE email = '{usuarioEncontrado}';";

                MySqlCommand mySqlCommand = new MySqlCommand(query, Connection);
                MySqlDataReader reader = mySqlCommand.ExecuteReader();
            }
            catch
            {
                MessageBox.Show("Erro no Banco de Dados");
            }
            finally
            {
                Connection.Close();

            }

            if (usuarioEncontrado)
            {
                labResultado.Text = "Usuario já existente";
                labResultado.ForeColor = Color.Red;
            }

            try
            {
                Connection.Open();

                string query = $"INSERT INTO usuario (email, senha) VALUES ('{novoUsuario}', '{novaSenha}');";

                MySqlCommand mySqlCommand = new MySqlCommand(query, Connection);
                mySqlCommand.ExecuteNonQuery();

                 labelResultado.Text = "Usuário cadastrado com sucesso!";
                labelResultado.ForeColor = Color.Green;

            }
            catch
            {
                MessageBox.Show("Erro no Banco de Dados");
            }
            finally
            {
                Connection.Close();

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
