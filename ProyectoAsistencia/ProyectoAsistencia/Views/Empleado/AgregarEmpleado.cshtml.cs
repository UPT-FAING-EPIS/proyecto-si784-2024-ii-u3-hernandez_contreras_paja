using ProyectoAsistencia.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProyectoAsistencia.Views.Empleado
{
    public class AgregarEmpleadoModel : PageModel
    {
        public ProyectoAsistencia.Models.Empleado Empleado { get; set; } = new ProyectoAsistencia.Models.Empleado();
        public List<ProyectoAsistencia.Models.Empleado> Empleados { get; set; } = new List<ProyectoAsistencia.Models.Empleado>();

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (Empleado != null)
            {
                Empleados.Add(Empleado);
            }
        }
    }
}
