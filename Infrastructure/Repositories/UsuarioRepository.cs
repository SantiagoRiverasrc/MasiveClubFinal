using Domain.Interfaces;
using Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private BdmasiveContext _context;

        public UsuarioRepository(BdmasiveContext context)
        {
            _context = context;
        }


        public IEnumerable<Usuario> GetUsuario()
        {
            return _context.Usuario;
        }

        public Usuario GetUsuarioById(int idUsuario)
        {
            var UsuarioA = _context.Usuario.FirstOrDefault(x => x.IdUsuario == idUsuario);
            return UsuarioA;
        }

        public void InsertUsuario(Usuario usuario)
        {
            _context.Usuario.Add(usuario);
            _context.SaveChanges();
        }

        public void UpdateUsuario(Usuario usuario)
        {
            var UsuarioA = _context.Usuario.FirstOrDefault(x => x.IdUsuario == usuario.IdUsuario);
            UsuarioA.Nombre = usuario.Nombre;
            UsuarioA.Apellidos = usuario.Apellidos;
            UsuarioA.Email = usuario.Email;
            UsuarioA.Contraseña = usuario.Contraseña;
            _context.SaveChanges();
        }

        public void DeleteUsuario(int idUsuario)
        {
            var UsuarioA = _context.Usuario.FirstOrDefault(x => x.IdUsuario == idUsuario);
            _context.Usuario.Remove(UsuarioA);
            _context.SaveChanges();
        }
    }
}
