using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperacion_4_FAOG
{

    public class Nodo
    {
        private Productos _producto;
        private Nodo _Siguiente;

        public Nodo(Productos producto)
        {
            _producto = producto;
            _Siguiente = null;
        }
        public Nodo(Productos producto, Nodo siguiente)
        {
            _producto = producto;
            _Siguiente = siguiente;
        }
        public Nodo gSiguiente
        {
            get { return _Siguiente; }
            set { _Siguiente = value; }
        }
        public Productos gProducto
        {
            get { return _producto; }
            set { _producto = value; }
        }

    }
}
