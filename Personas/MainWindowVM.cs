using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Personas
{
    class MainWindowVM
    {
        private UserControl opcion;

        public UserControl Opcion
        {
            get { return opcion; }
            set { opcion = value; }
        }

    }
}
