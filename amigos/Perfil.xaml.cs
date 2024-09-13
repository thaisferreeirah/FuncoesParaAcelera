
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Amigos
{
    /// <summary>
    /// Lógica interna para Perfil.xaml
    /// </summary>
    public partial class Perfil : Window
    {
        private UsuarioManager usuarioManager = new UsuarioManager();

        public Perfil(int codUsuario, int codPerfil)
        {
            InitializeComponent();
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(usuarioManager.BuscarFoto(codPerfil), UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            fotoPerfil.Source = bitmap;
            nomePerfil.Content = usuarioManager.BuscarNome(codPerfil);



        }
    }
}
