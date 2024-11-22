namespace ProyectoAsistencia.Views.Asistencia
{
    public class ConfirmacionModel
    {
        public bool IsSuccess { get; private set; }

        public void OnGet()
        {
            // Método vacío para pruebas.
        }

        public void OnPost(bool confirmacion)
        {
            IsSuccess = confirmacion;
        }
    }
}
