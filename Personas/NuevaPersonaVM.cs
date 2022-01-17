using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    class NuevaPersonaVM :ObservableObject
    {
        public ServicioNavegacion servicio;
        private ObservableCollection<string> listaNacionalidades;

        public ObservableCollection<string> ListaNacionalidades
        {
            get { return listaNacionalidades; }
            set { SetProperty(ref listaNacionalidades, value); }
        }

        public RelayCommand AbrirAñadirNacionalidadCommand { get; }
        public NuevaPersonaVM()
        {
            servicio = new ServicioNavegacion();
            AbrirAñadirNacionalidadCommand = new RelayCommand(AbrirAñadirNacionalidad);
            ListaNacionalidades = new ObservableCollection<string>();
            ListaNacionalidades.Add("Italiana");
            ListaNacionalidades.Add("Española");
            ListaNacionalidades.Add("Francesa");
        }

        private void AbrirAñadirNacionalidad()
        {
            servicio.AbrirAñadirNacionalidad();
        }
    }
}
