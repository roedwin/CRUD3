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
    public class CrearMateriaModel : PageModel
    {
        private readonly IServicioRepository _materiaRepository;

        public CrearMateriaModel(IServicioRepository materiaRepository)
        {
            _materiaRepository = materiaRepository;
        }
        [BindProperty]
        public Servicio Materia { get; set; }

        public void OnGet()
        {
            
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _materiaRepository.Insert(Materia);
            return RedirectToPage("./Materias");
        }
    }
}
