using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;

namespace WebApplicationExamen1.Pages.Puesto
{
    public class EditModel : PageModel
    {
        private readonly IPuestoService puestoService;
        public EditModel(IPuestoService puestoService)
        {
            this.puestoService = puestoService;
        }
        [BindProperty]
        public PuestoEntity Entity { get; set; } = new PuestoEntity();
        [BindProperty(SupportsGet = true)]
        public int? id { get; set; }
        public async Task<IActionResult> OnGet()
        {
            try
            {
                if (id.HasValue)
                {
                    Entity = await puestoService.GetById(new() { Id_Puesto = id });
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
                if (Entity.Id_Puesto.HasValue)
                {
                    //Actualizar 
                    var result = await puestoService.Update(Entity);
                    if (result.CodeError != 0) throw new Exception(result.MsgError);
                    TempData["Msg"] = "Se actualizó correctamente";
                }
                else
                {
                    //Nuevo 
                    var result = await puestoService.Create(Entity);
                    if (result.CodeError != 0) throw new Exception(result.MsgError);
                    TempData["Msg"] = "Se agregó correctamente";
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
