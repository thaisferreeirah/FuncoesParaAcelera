using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Amigos
{
    public class Usuario
    {
        public int CodUsuario { get; set; }
        public string Nome { get; set; }
        public string Foto { get; set; }
        public ArrayList Amigos { get; set; } = new ArrayList();
    }

    public class UsuarioManager
    {
        private static List<Usuario> usuario = new List<Usuario>();

        public void AmazenarUsuario(int codUsuario, string nome, string foto)
        {
            Usuario novoUsuario = new Usuario()
            {
                CodUsuario = codUsuario,
                Nome = nome,
                Foto = foto
            };

            usuario.Add(novoUsuario);
            
        }
        public void AdicionarAmigo(int codUsuario, int codAmigo)
        {

            usuario[codUsuario].Amigos.Add(codAmigo);

            
        }
        public int BuscarCodAmigo(int codUsuario, int i) 
        {
            return (int)usuario[codUsuario].Amigos[i];
        }

        public string BuscarNome(int codAmigo)
        {
            return usuario[codAmigo].Nome;
        } 
        public string BuscarFoto(int codAmigo)
        {
            return usuario[codAmigo].Foto;
        }
        public Boolean VerificarAmigo(int codUsuario, int i)
        {
            if (usuario[codUsuario].Amigos[i]!= null)
            {
                return true;
            }
            return false;
        }
        public int QuantAmigos(int codUsuario) 
        {
            return usuario[codUsuario].Amigos.Count;
        }
       
    }
}