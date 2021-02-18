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
    public class EditMateriaModel : PageModel
    {
        private readonly IMateriaRepository _materiaRepository;

        public EditMateriaModel(IMateriaRepository materiaRepository)
        {
            _materiaRepository = materiaRepository;
        }

        [BindProperty]
        public Materia Materia { get; set; }

        public IActionResult OnGet(int id)
        {
            Materia = _materiaRepository.GetByID(id);
            if (Materia == null)
            {
                return NotFound();
            }
            return Page();            
        }

        public IActionResult OnPost(int id)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            var materiaToUpdate = _materiaRepository.GetByID(id);
            if(materiaToUpdate == null) 
                return NotFound();

            materiaToUpdate.Codigo = Materia.Codigo;
            materiaToUpdate.Description = Materia.Description;
            materiaToUpdate.Habilitada = Materia.Habilitada;

            _materiaRepository.Update(Materia);
            return RedirectToPage("./Materias");
        }
    }
}
