namespace Simulacro.Models
{
    public class Perro : Animales
    {
        public string raza { get; set; } = string.Empty;
        public enum Tamaño
        {
            Pequeño,
            Mediano,
            Grande
        }
        public class ProductoViewModel
        {
            // Esta propiedad guardará la opción seleccionada
            public Tamaño TamanioSeleccionado { get; set; }
        }

    }

}
