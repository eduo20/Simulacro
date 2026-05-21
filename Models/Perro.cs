namespace Simulacro.Models
{
    // Colocamos el enum afuera para que cualquier clase lo pueda usar fácilmente
    public enum TamañoAnimal
    {
        Pequeño,
        Mediano,
        Grande
    }

    public class Perro : Animales
    {
        public string raza { get; set; } = string.Empty;

        // Esta propiedad guardará la opción elegida en el select y se irá al JSON
        public TamañoAnimal TamañoSeleccionado { get; set; } = TamañoAnimal.Mediano;
    }
}