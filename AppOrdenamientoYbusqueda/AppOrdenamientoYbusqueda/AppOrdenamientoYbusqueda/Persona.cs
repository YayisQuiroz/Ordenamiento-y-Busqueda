using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOrdenamientoYbusqueda
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string apellido;
        private int edad; 
        private string carrera;

            public Persona(string nombre, string apellido, int id, int edad, string carrera)
            {
                Nombre = nombre;
                Apellido = apellido;
                Id = id;
                Edad = edad;
                Carrera = carrera;
            }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Carrera { get => carrera; set => carrera = value; }
    }

}
