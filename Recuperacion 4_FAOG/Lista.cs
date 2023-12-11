using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperacion_4_FAOG
{
    public class Lista
    {

        private Nodo primero;
        private Nodo ultimo;
        public Lista()
        {
            primero = ultimo = null;
        }
        public bool Esnulo()
        {
            return primero == null;
        }
        public void Insertar(Productos producto)
        {
            if (Esnulo())
            {
                primero = ultimo = new Nodo(producto);
            }
            else
            {
                Nodo actual = primero;
                while (actual != null)
                {
                    if (actual.gSiguiente == null)
                    {
                        actual = actual.gSiguiente = new Nodo(producto);
                        break;
                    }
                    else
                    {
                        actual = actual.gSiguiente;
                    }
                }
            }
        }
        public void OrdenarPorPrecio()
        {
            if (Esnulo() || primero.gSiguiente == null)
            {
                Console.WriteLine("La lista está vacía o solo tiene un elemento, no es necesario ordenar.");
                return;
            }

            bool intercambio;
            do
            {
                intercambio = false;
                Nodo actual = primero;
                Nodo anterior = null;

                while (actual.gSiguiente != null)
                {
                    if (actual.gProducto.Precio > actual.gSiguiente.gProducto.Precio)
                    {
                        Nodo temp = actual.gSiguiente;
                        actual.gSiguiente = temp.gSiguiente;
                        temp.gSiguiente = actual;

                        if (anterior != null)
                        {
                            anterior.gSiguiente = temp;
                        }
                        else
                        {
                            primero = temp;
                        }

                        intercambio = true;
                    }

                    anterior = actual;
                    actual = actual.gSiguiente;
                }
            } while (intercambio);
        }

        // Método para mostrar los Productos ya ordenados
        public void MostrarElementosOrdenados()
        {
            OrdenarPorPrecio();
            MostrarElementos();
        }
        public void MostrarElementos()
        {
            if (Esnulo())
            {
                Console.WriteLine("La lista está vacía, no hay elementos para mostrar.");
                return;
            }

            Nodo actual = primero;

            while (actual != null)
            {
                Console.WriteLine($"Nombre: {actual.gProducto.Nombre}, Precio: {actual.gProducto.Precio}");
                actual = actual.gSiguiente;
            }
        }
        public void Buscar(int Precio)
        {
            if (Esnulo())
            {
                Console.WriteLine("No tiene valores la lista");
                return;
            }
            else
            {
                Nodo actual = primero;
                bool Encontrar = false;
                while (actual != null)
                {
                    if (actual.gProducto.Precio == Precio)
                    {
                        Console.WriteLine($"El Nombre {actual.gProducto.Nombre} se encuentra");


                        Console.WriteLine($"Nombre: {actual.gProducto.Nombre}, Precio: {actual.gProducto.Precio}");

                        Encontrar = true;
                    }

                    actual = actual.gSiguiente;
                }

                if (!Encontrar)
                {
                    Console.WriteLine("La Marca no se encuentra en la lista");
                }
            }
        }
    }
}
