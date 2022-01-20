using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
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
            WeakReferenceMessenger.Default.Register<NuevaPersonaMessage>(this, (r, m) =>
            {
                ListaPersonas.Add(m.Value);
            });

            WeakReferenceMessenger.Default.Register<ListadoPersonasVM, PersonaSeleccionadaMessage>(this, (r, m) =>
            {
                if (!m.HasReceivedResponse)
                    m.Reply(PersonaActual);
            });
        }

    }
}
