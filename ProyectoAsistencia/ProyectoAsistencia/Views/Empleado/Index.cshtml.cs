using ProyectoAsistencia.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProyectoAsistencia.Views.Empleado
{
    public class IndexModel : PageModel
    {
        public List<ProyectoAsistencia.Models.Empleado> Empleados { get; set; } = new List<ProyectoAsistencia.Models.Empleado>();

        public void OnGet()
        {
            Empleados = new List<ProyectoAsistencia.Models.Empleado>
            {
                new ProyectoAsistencia.Models.Empleado { Id = 1, NombreUsuario = "Empleado1" },
                new ProyectoAsistencia.Models.Empleado { Id = 2, NombreUsuario = "Empleado2" }
            };
        }
    }
}
