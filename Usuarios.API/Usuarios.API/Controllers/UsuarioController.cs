using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Usuarios.API.Data.Dtos;
using Usuarios.API.Models;
using Usuarios.API.Services;

namespace Usuarios.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private UsuarioService _usuarioService;

        public UsuarioController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost("Cadastro")]
        public async Task<IActionResult> CadastraUsuario(CreateUsuarioDto dto)
        {
            await _usuarioService.Cadastro(dto);

            return Ok("Usuário Cadastrado!");
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginUsuarioDto dto)
        {
            string token = await _usuarioService.Login(dto);

            return Ok(token);
        }
    }
}
