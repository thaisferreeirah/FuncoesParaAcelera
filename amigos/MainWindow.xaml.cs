using System.IO.Packaging;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace Amigos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private UsuarioManager usuarioManager = new UsuarioManager();
        
        int codUsuario;
        int codAmigo;
        int posAmigo;
        
        public MainWindow()
        {
            InitializeComponent();
            usuarioManager.AmazenarUsuario(0, "Thais", "C:\\Users\\thais\\OneDrive\\Área de Trabalho\\acelera\\amigos\\Amigos\\imagens\\Thais.jpg");
            usuarioManager.AmazenarUsuario(1, "Johnny", "C:\\Users\\thais\\OneDrive\\Área de Trabalho\\acelera\\amigos\\Amigos\\imagens\\JK.png");
            usuarioManager.AmazenarUsuario(2, "Lua", "C:\\Users\\thais\\OneDrive\\Área de Trabalho\\acelera\\amigos\\Amigos\\imagens\\Lua.jpeg");
            usuarioManager.AmazenarUsuario(3, "Pedro", "C:\\Users\\thais\\OneDrive\\Área de Trabalho\\acelera\\amigos\\Amigos\\imagens\\Pedro.png");
            usuarioManager.AmazenarUsuario(4, "Puck", "C:\\Users\\thais\\OneDrive\\Área de Trabalho\\acelera\\amigos\\Amigos\\imagens\\Puck.png");
            
            codUsuario = 0;
            codAmigo = 1;
            posAmigo = 0;
             
            

            usuarioManager.AdicionarAmigo(codUsuario, 0);
            usuarioManager.AdicionarAmigo(codUsuario, 1);
            usuarioManager.AdicionarAmigo(codUsuario, 2);
            usuarioManager.AdicionarAmigo(codUsuario, 3);
            usuarioManager.AdicionarAmigo(codUsuario, 4);


            for (int i = 0; i < usuarioManager.QuantAmigos(codUsuario); i++)
            {  
                codAmigo = usuarioManager.BuscarCodAmigo(codUsuario, i);
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(usuarioManager.BuscarFoto(codAmigo), UriKind.RelativeOrAbsolute);
                bitmap.EndInit();
                if (posAmigo == 0)
                {
                    foto1.ImageSource = bitmap;
                    labelNome1.Content = usuarioManager.BuscarNome(codAmigo);
                    posAmigo++;
                }
                else if (posAmigo == 1)
                {
                    foto2.ImageSource = bitmap;
                    labelNome2.Content = usuarioManager.BuscarNome(codAmigo);
                    posAmigo++;
                }
                else if (posAmigo == 2)
                {
                    foto3.ImageSource = bitmap;
                    labelNome3.Content = usuarioManager.BuscarNome(codAmigo);
                    posAmigo++;
                }
                else if (posAmigo == 3)
                {
                    foto4.ImageSource = bitmap;
                    labelNome4.Content = usuarioManager.BuscarNome(codAmigo);
                    posAmigo++;
                }
                else if (posAmigo == 4)
                {
                    foto5.ImageSource = bitmap;
                    labelNome5.Content = usuarioManager.BuscarNome(codAmigo);
                    posAmigo++;
                }
                else if (posAmigo == 5)
                {
                    foto6.ImageSource = bitmap;
                    labelNome6.Content = usuarioManager.BuscarNome(codAmigo);
                    posAmigo++;
                }
            }
        }

        private void BotaoBuscarAmigos_Click(object sender, RoutedEventArgs e)
        {
         
        }

        private void botaoPerfil_Click(object sender, RoutedEventArgs e)
        {
            Perfil perfil = new Perfil(codUsuario,4);
            perfil.Show();
        }
    }
}