namespace Simulacro.Models
{
    public class Ave
    {
        public enum TipoPico
        {
            Curvo,
            Recto,
            Aguja
        }
        public class ProductoViewModel
        {
            // Esta propiedad guardará la opción seleccionada
            public TipoPico TipoPicoSeleccionado { get; set; }
        }
        public bool puedeVolar { get; set; }
    }
}
