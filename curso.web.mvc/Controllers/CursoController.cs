using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using curso.web.mvc.Models.Cursos;
using curso.web.mvc.Services;
using Microsoft.AspNetCore.Mvc;
using Refit;

namespace curso.web.mvc.Controllers
{

    [Microsoft.AspNetCore.Authorization.Authorize]
    public class CursoController : Controller
    {
        private readonly ICursoService _cursoService;

        public CursoController(ICursoService cursoService)
        {
            _cursoService = cursoService;
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [Microsoft.AspNetCore.Authorization.Authorize]
        [HttpPost]
        public async Task<IActionResult> Cadastrar(CadastrarCursoViewModelInput cadastrarCursoViewModelInput)
        {
            try
            {
                var curso = await _cursoService.Registrar(cadastrarCursoViewModelInput);
                ModelState.AddModelError("", $"O curso foi cadastrado com sucesso para o login {curso.Nome}");
            }
            catch (ApiException ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        [Microsoft.AspNetCore.Authorization.Authorize]
        public async Task<IActionResult>  Listar()
        {
            //var cursos = new List<ListarCursoViewModelOutput>();

            var cursos = await _cursoService.Obter();

            //new ListarCursoViewModelOutput()
            //{
            //    Nome = "Curso A",
            //    Descricao = "Descricao Curso A",
            //    Login = "palomasantana",
            //};

            //new ListarCursoViewModelOutput()
            //{
            //    Nome = "Curso B",
            //    Descricao = "Descricao Curso B",
            //    Login = "palomasantana",
            //};


            return View(cursos);
        }
    }
}

