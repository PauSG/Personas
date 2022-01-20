using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    class NuevaPersonaVM : ObservableObject
    {

        public ServicioNavegacion servicio;

        private Persona nuevaPersona;

        public Persona NuevaPersona
        {
            get { return nuevaPersona; }
            set { SetProperty(ref nuevaPersona, value); }
        }

        private ObservableCollection<string> listaNacionalidades;

        public ObservableCollection<string> ListaNacionalidades
        {
            get { return listaNacionalidades; }
            set { SetProperty(ref listaNacionalidades, value); }
        }

        public RelayCommand AbrirAñadirNacionalidadCommand { get; }
        
        public RelayCommand AceptarNuevaPersonaCommand { get; }
        public NuevaPersonaVM()
        {
            servicio = new ServicioNavegacion();
            NuevaPersona = new Persona();
            AbrirAñadirNacionalidadCommand = new RelayCommand(AbrirAñadirNacionalidad);
            AceptarNuevaPersonaCommand = new RelayCommand(AñadirPersona);
            ListaNacionalidades = new ObservableCollection<string>();
            ListaNacionalidades.Add("Italiana");
            ListaNacionalidades.Add("Española");
            ListaNacionalidades.Add("Francesa");
            WeakReferenceMessenger.Default.Register<NuevaNacionalidadMessage>(this, (r, m) =>
            {
                ListaNacionalidades.Add(m.Value);
            });
        }

        private void AbrirAñadirNacionalidad()
        {
            servicio.AbrirAñadirNacionalidad();
        }
         private void AñadirPersona()
        {
            WeakReferenceMessenger.Default.Send(new NuevaPersonaMessage(NuevaPersona));
        }
    }
}
