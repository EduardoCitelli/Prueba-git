namespace Prueba_git
{
    public class Persona
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Saludar()
        {
            return $"hola mi nombre es {Nombre} y mi apellido es {Apellido}";
        }
    }
}