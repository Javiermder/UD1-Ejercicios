using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace UD1_Ej9_Gimnasio
{
    internal class Program
    {
        static List<Cliente> listaClientes = new List<Cliente>();
        private static int CodigoCliente = 1;
        private static String Contraseña = "1234";
        static void Main(string[] args)
        {
            bool salir = true;
            while (salir)
            {

                Console.WriteLine("Menú del Gimnasio");
                Console.WriteLine("1.Dar de alta un cliente");
                Console.WriteLine("2.Mostrar clientes");
                Console.WriteLine("3.Modificar clientes");
                Console.WriteLine("4.Eliminar clientes");
                Console.WriteLine("5.Borrar todos los clientes (administrador)");
                Console.WriteLine("6.Guardar los clientes en un archivo JSON");
                Console.WriteLine("7.Cargar los clentes en un archivo JSON");
                Console.WriteLine("8.Salir");
                Console.WriteLine("Seleccione una opción:");


                int opcion = Convert.ToInt32(Console.ReadLine());



                switch (opcion)
                {
                    case 1:
                        DarDeAltaCliente();
                        break;
                    case 2:
                        MostrarCliente();
                        break;

                    case 3:
                        ModificarCliente();
                        break;

                    case 4:
                        EliminarCliente();
                        break;

                    case 5:
                        BorrarTodosLosCLientes();
                        break;

                    case 6:
                        GuardaClientesJSON();
                        break;

                    case 7:
                        CargarClientesDeJSON();
                        break;

                    case 8:
                        salir = false;
                        break;

                    default:

                        break;
                }

            }



            void DarDeAltaCliente()
            {
                Console.WriteLine("Introduce el nombre del cliente");
                String nombre = Console.ReadLine();

                Console.WriteLine("Introduce el apellido del cliente");
                String apellido = Console.ReadLine();

                int codigo = CodigoCliente++;
                Cliente cliente = new Cliente(nombre, apellido, codigo);

                listaClientes.Add(cliente);


            }

            void MostrarCliente()
            {
                foreach (Cliente cliente in listaClientes)
                {
                    Console.WriteLine(cliente.CodigoCliente);
                    Console.WriteLine(cliente.Nombre);
                }
            }

            void ModificarCliente()
            {

                MostrarCliente();

                Console.WriteLine("Que cliente quieres modificar");
                int id = Convert.ToInt32(Console.ReadLine());

                foreach (Cliente cliente in listaClientes)
                {
                    if (cliente.CodigoCliente == id)
                    {
                        Console.WriteLine("Que nombre le quiere poner al cliente?");
                        String nombre = Console.ReadLine();
                        cliente.Nombre = nombre;
                        Console.WriteLine("Que apellido le quiere poner al cliente?");
                        String apellido = Console.ReadLine();
                        cliente.Apellidos = apellido;

                    }
                    else
                    {

                        Console.WriteLine("Ese cliente no existe");

                    }
                }
            }

            void EliminarCliente()
            {
                MostrarCliente();
                Console.WriteLine("Que cliente quieres borrar?");
                int id = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < listaClientes.Count; i++)
                {
                    if (listaClientes[i].CodigoCliente == id)
                    {
                        listaClientes.RemoveAt(i);
                        Console.WriteLine("Cliente eliminado.");
                        return;
                    }
                }
                Console.WriteLine("Ese cliente no existe.");
            }

            void BorrarTodosLosCLientes() {

                Console.WriteLine("Introduzca la contraseña de admin para eliminar todos los clientes");
                String pass = Console.ReadLine();

                if (pass.Equals(Contraseña))
                {
                    listaClientes.Clear();
                }
            
            }

            void GuardaClientesJSON()
            {
                try
                {
                    string jsonString = JsonSerializer.Serialize(listaClientes);
                    File.WriteAllText("clientes.json", jsonString);
                    Console.WriteLine("Clientes guardados en clientes.json con éxito.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al guardar los clientes: " + ex.Message);
                }
            }

            void CargarClientesDeJSON() {
            
                
            }

        }
    }
}
