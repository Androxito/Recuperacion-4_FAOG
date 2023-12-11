using System.Collections.Generic;

namespace Recuperacion_4_FAOG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();
            Productos producto = new Productos();
            int opcion = 0;
            string opcionS = "";
            string nombre = "";
            int precio = 0;
            while (opcion != 4)
            {
                Console.WriteLine("Seleccione una opcion");
                Console.WriteLine("----\n" +
                    "1 Insertar Nodo al inicio\n" +
                    "3 Buscar\n" +
                    "4 Mostrar\n" +
                    "5 Ordenar\n" + 
                    "6 Exit"
                    );
                opcionS = Console.ReadLine();
                if (opcionS == "")
                {
                    Console.WriteLine("Ingrese un valor, intente de nuevo");
                }
                else
                {
                    switch (opcionS)
                    {
                        case "1":
                            Console.WriteLine("Ingresa un Nombre");
                            nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese la Precio");
                            precio = Convert.ToInt32(Console.ReadLine());
                             producto= new Productos
                            {
                                Nombre = nombre,
                                Precio = precio
                            };
                            lista.Insertar(producto);
                            break;
                        case "2":
                            Console.WriteLine("Ingresa un Nombre");
                            nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese la Precio");
                            precio = Convert.ToInt32(Console.ReadLine());
                            producto = new Productos
                            {
                                Nombre = nombre,
                                Precio = precio
                            };
                            lista.Insertar(producto);
                            break;
                        case "3":
                            Console.WriteLine("Ingrese el nombre que busca mediante el precio es:");
                            precio = Convert.ToInt32(Console.ReadLine());
                            lista.Buscar(precio);
                            break;
                        case "4":
                            lista.MostrarElementos();
                            break;
                        case "5":
                            lista.OrdenarPorPrecio();
                            Console.WriteLine("Lista ordenada por precio de forma creciente:");
                            lista.MostrarElementos();
                            break;
                            case "6":
                            opcion = Convert.ToInt32(opcionS);

                            break;
                        default:
                            Console.WriteLine("No contemplado");
                            break;
                    }
                }
            }

        }






























    }
    
}