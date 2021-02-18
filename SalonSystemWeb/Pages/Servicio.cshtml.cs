using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EscuelaSystemData.Interface;
using EscuelaSystemModules;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EscuelaSystemWeb.Pages
{
    public class MateriasModel : PageModel
    {
        private readonly IServicioRepository _materiaRepository;

        public MateriasModel(IServicioRepository materiaRepository)
        {
            _materiaRepository = materiaRepository;
        }

        [BindProperty]
        public IEnumerable<Servicio> Materias { get; set; }

        public IActionResult OnGet()
        {
            Materias = _materiaRepository.List();
            return Page();
        }
    }
}
