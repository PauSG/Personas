using Microsoft.Toolkit.Mvvm.ComponentModel;
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
        private ObservableCollection<string> listaNacionalidades;

        public ObservableCollection<string> ListaNacionalidades
        {
            get { return listaNacionalidades; }
            set { SetProperty(ref listaNacionalidades, value); }
        }

        public NuevaPersonaVM()
        {
            ListaNacionalidades = new ObservableCollection<string>();
            ListaNacionalidades.Add("Italiana");
            ListaNacionalidades.Add("Española");
            ListaNacionalidades.Add("Francesa");
        }
    }
}
