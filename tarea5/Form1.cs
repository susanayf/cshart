namespace tarea5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            int contrasena = 12345678;
            

            
            

            if (Convert.ToInt32(txtclave.Text) == contrasena)
            {
                //Console.WriteLine("ingrese A, U o X para verificar su perfil");
                //perfil = Console.ReadLine();

                switch (txtperfil.Text)
                {
                    case "A":
                        lblperfil.Text = "Bienvenido administrador";
                        break;
                    case "U":
                        lblperfil.Text = "Bienvenido usuario";
                        break;
                    case "X":
                        lblperfil.Text = "Bienvenido sin perfil definido";
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show ("ingrese la contraseña nuevamente");

                if (Convert.ToInt32(txtclave.Text) == contrasena)
                {
                    //Console.WriteLine("ingrese A, U o X para verificar su perfil");
                    //perfil = Console.ReadLine();

                    switch (txtperfil.Text)
                    {
                        case "A":
                            lblperfil.Text = "Bienvenido administrador";
                            break;
                        case "U":
                            lblperfil.Text = "Bienvenido usuario";
                            break;
                        case "X":
                            lblperfil.Text = "Bienvenido sin perfil definido";
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    lblacceso.Text = "debe reiniciar el sistema";
                }
            }
        }
    }
}
