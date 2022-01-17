﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Personas
{
    class ServicioNavegacion
    {
        public void AbrirAñadirNacionalidad()
        {
            AñadirNacionalidad windowHija = new AñadirNacionalidad();
            windowHija.ShowDialog();
        }
        public UserControl AbrirNuevaPersona()
        {
            return new NuevaPersona();
        }

        public UserControl AbrirListadoPersonas()
        {
            return new ListadoPersonas();
        }
    }
}
