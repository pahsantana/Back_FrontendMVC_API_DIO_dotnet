using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso.api.Models.Usuarios
{
    public class UsuarioViewModelInput
    {
        public int Codigo { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
