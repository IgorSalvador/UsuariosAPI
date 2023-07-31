using Microsoft.AspNetCore.Authorization;

namespace Usuarios.API.Authorization
{
    public class IdadeMinina : IAuthorizationRequirement
    {
        public int Idade { get; set; }

        public IdadeMinina(int idade)
        {
            Idade = idade;
        }
    }
}
