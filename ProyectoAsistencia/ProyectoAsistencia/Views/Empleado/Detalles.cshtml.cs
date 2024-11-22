using ProyectoAsistencia.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProyectoAsistencia.Views.Empleado
{
    public class DetallesModel : PageModel
    {
        public ProyectoAsistencia.Models.Empleado Empleado { get; set; } = new ProyectoAsistencia.Models.Empleado();

        public void OnGet()
        {
            Empleado = new ProyectoAsistencia.Models.Empleado { Id = 1, NombreUsuario = "Empleado1" };
        }
    }
}
