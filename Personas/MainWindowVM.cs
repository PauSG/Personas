using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Personas
{
    class MainWindowVM :ObservableObject
    {
        private ServicioNavegacion servicio;

        private UserControl opcion;

        public UserControl Opcion
        {
            get { return opcion; }
            set { SetProperty(ref opcion, value); }
        }

        public RelayCommand AbrirNuevaPersonaCommand { get; }

        public RelayCommand AbrirListadoPersonasCommand { get; }

        public MainWindowVM()
        {
            AbrirListadoPersonasCommand = new RelayCommand(AbriListadoPersonas);
            AbrirNuevaPersonaCommand = new RelayCommand(AbrirNuevaPersona);
            servicio = new ServicioNavegacion();
        }

        private void AbrirNuevaPersona()
        {
            Opcion = servicio.AbrirNuevaPersona();
        }

        private void AbriListadoPersonas()
        {
            Opcion = servicio.AbrirListadoPersonas();
        }
    }
}
