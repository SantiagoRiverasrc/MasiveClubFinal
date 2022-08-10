using Application.Request.Usuario;
using Application.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.App
{
    public interface IUsuarioService
    {
        UsuarioResponse GetUsuarioById(int idUsuario);
        IEnumerable<UsuarioResponse> GetUsuario();

        void InsertUsuario(CreateUsuarioRequest usuario);

        void UpdateUsuario(UpdateUsuarioRequest usuario);

        void DeleteUsuario(int idUsuario);
    }
}
