using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;

namespace WebApplicationExamen1.Pages.Departamento
{
    public class EditModel : PageModel
    {
        private readonly IDepartamentoService departamentoService;
        public EditModel(IDepartamentoService departamentoService)
        {
            this.departamentoService = departamentoService;
        }
        [BindProperty]
        public DepartamentoEntity Entity { get; set; } = new DepartamentoEntity();
        [BindProperty(SupportsGet = true)]
        public int? id { get; set; }
        public async Task<IActionResult> OnGet()
        {
            try
            {
                if (id.HasValue)
                {
                    Entity = await departamentoService.GetById(new() { Id_Departamento = id });
                }
                return Page();
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }
        public async Task<IActionResult> OnPostAsync()
        {
            try
            {
                if (Entity.Id_Departamento.HasValue)
                {
                    //Actualizar 
                    var result = await departamentoService.Update(Entity);
                    if (result.CodeError != 0) throw new Exception(result.MsgError);
                    TempData["Msg"] = "Se actualiz� correctamente";
                }
                else
                {
                    //Nuevo 
                    var result = await departamentoService.Create(Entity);
                    if (result.CodeError != 0) throw new Exception(result.MsgError);
                    TempData["Msg"] = "Se agreg� correctamente";
                }
                return RedirectToPage("Grid");
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }
    }
}
