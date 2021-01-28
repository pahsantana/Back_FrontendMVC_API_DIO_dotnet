using System.Collections.Generic;
using System.Threading.Tasks;
using curso.web.mvc.Models.Cursos;
using Refit;

namespace curso.web.mvc.Services
{
    interface ICursoService
    {
        [Post("/api/v1/cursos")]
        [Headers("Authorization: Bearer")]
        Task<CadastrarCursoViewModelOutput> Registrar(CadastrarCursoViewModelOutput cadastrarCursoViewModelOutput);

        [Get("/api/v1/cursos")]
        [Headers("Authorization: Bearer")]
        Task<IList<ListarCursoViewModelOutput>> Obter();
    }
}
