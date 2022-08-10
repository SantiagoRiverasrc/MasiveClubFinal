using Application.Interfaces.App;
using Application.Request.Usuario;
using Application.Responses;
using AutoMapper;
using Domain.Interfaces;
using Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _repository;
        private readonly IMapper _mapper;

        public UsuarioService(IUsuarioRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void DeleteUsuario(int idUsuario)
        {
            _repository.DeleteUsuario(idUsuario);
        }

        public UsuarioResponse GetUsuarioById(int idUsuario)
        {
            var usuario = _repository.GetUsuarioById(idUsuario);
            var usuarioResponse = _mapper.Map<UsuarioResponse>(usuario);
            return usuarioResponse;
        }

        public IEnumerable<UsuarioResponse> GetUsuario()
        {
            var usuario = _repository.GetUsuario();
            var usuarioResponse = _mapper.Map<IEnumerable<UsuarioResponse>>(usuario);
            return usuarioResponse;
        }

        public void InsertUsuario(CreateUsuarioRequest request)
        {
            var usuario = _mapper.Map<Usuario>(request);
            _repository.InsertUsuario(usuario);
        }

        public void UpdateUsuario(UpdateUsuarioRequest request)
        {
            var usuario = _mapper.Map<Usuario>(request);
            _repository.UpdateUsuario(usuario);
        }
    }
}
