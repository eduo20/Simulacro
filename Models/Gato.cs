using static Simulacro.Models.Ave;

namespace Simulacro.Models
{
    public class Gato : Animales
    {
        public enum TipoPelaje
        {
            Corto,
            Largo,
            sinpelo
        }
        public class ProductoViewModel
        {
            // Esta propiedad guardará la opción seleccionada
            public TipoPelaje TipoPelajeSeleccionado { get; set; }
        }
       

        public bool esDomestico{ get; set;}
    }
}
