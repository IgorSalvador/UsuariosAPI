using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace Usuarios.API.Authorization
{
    public class IdadeAuthorization : AuthorizationHandler<IdadeMinina>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, IdadeMinina requirement)
        {
            var dataNascimentoClaim = context.User
                .FindFirst(claim => claim.Type == ClaimTypes.DateOfBirth);

            if(dataNascimentoClaim is null)
                return Task.CompletedTask;

            DateTime dataNascimento = Convert.ToDateTime(dataNascimentoClaim.Value);

            int idadeUsuario = DateTime.Today.Year - dataNascimento.Year;

            if (dataNascimento > DateTime.Today.AddYears(-idadeUsuario))
                idadeUsuario--;

            if (idadeUsuario >= requirement.Idade)
                context.Succeed(requirement);

            return Task.CompletedTask;
        }
    }
}
