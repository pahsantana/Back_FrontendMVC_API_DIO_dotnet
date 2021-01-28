using System.Threading.Tasks;
using curso.web.mvc.Models.Usuarios;
using curso.web.mvc.Views.Usuario;
using Refit;

namespace curso.web.mvc.Services
{
    interface IUsuarioService
    {
        [Post("/api/v1/usuario/registrar")]
        Task<RegistrarUsuarioViewModelInput> Registrar(RegistrarUsuarioViewModelInput registrarUsuarioViewModelInput);

        [Post("/api/v1/usuario/logar")]
        Task<LoginViewModelOutput> Logar(LoginViewModelInput loginViewModelInput);
    }
}
