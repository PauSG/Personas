using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    class Persona :ObservableObject
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { SetProperty(ref nombre, value); }
        }

        private int edad;

        public int Edad
        {
            get { return edad; }
            set { SetProperty(ref edad, value); }
        }

        private string nacionalidad;

        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { SetProperty(ref nacionalidad, value); }
        }

        public Persona(string nombre, int edad, string nacionalidad)
        {
            Nombre = nombre;
            Edad = edad;
            Nacionalidad = nacionalidad;
        }

        public static ObservableCollection<Persona> ObtenerListadoPersonas()
        {
            ObservableCollection<Persona> lista = new ObservableCollection<Persona>();
            lista.Add(new Persona("Pau", 23, "Española"));
            lista.Add(new Persona("Josekar", 21, "Francesa"));
            lista.Add(new Persona("Deluxazo", 19, "Italiana"));

            return lista;
        }
    }
}
