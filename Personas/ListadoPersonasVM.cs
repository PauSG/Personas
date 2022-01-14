using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Personas
{
    class ListadoPersonasVM : ObservableObject
    {
        private ObservableCollection<Persona> listaPersonas;

        public ObservableCollection<Persona> ListaPersonas
        {
            get { return listaPersonas; }
            set { SetProperty(ref listaPersonas, value); }
        }

        private Persona personaActual;

        public Persona PersonaActual
        {
            get { return personaActual; }
            set { SetProperty(ref personaActual, value); }
        }

        public ListadoPersonasVM()
        {
            ListaPersonas = Persona.ObtenerListadoPersonas();
        }

    }
}
