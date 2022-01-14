using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Personas
{
    class ServicioNavegacion
    {

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
