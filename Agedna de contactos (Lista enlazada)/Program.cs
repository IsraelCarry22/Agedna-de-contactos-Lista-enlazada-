using Agedna_de_contactos__Lista_enlazada_.Clases;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agedna_de_contactos__Lista_enlazada_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool sal = false;
            LinkedList<Agenda> Contactos = new LinkedList<Agenda>();
            while (!sal)
            {
                string Nombre, NumTel;
                Console.Clear();
                Console.WriteLine("== Mi Agenda == \n[1]Añadir\n[2]Eliminar\n[3]Buscar\n[4]Ver agenda\n[5]Salir");
                Console.Write("Elige una opcion: ");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Ingresa su nombre: ");
                        Nombre = Console.ReadLine();
                        Console.Write("Ingresa su numero de telefono: ");
                        NumTel = Console.ReadLine();
                        Contactos.AddLast(new Agenda { Nombre = Nombre, NumTelefono = NumTel });
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Inresa el nombre del contacto a eliminar: ");
                        Nombre = Console.ReadLine();
                        Agenda Eliminar = null;
                        foreach (var item in Contactos)
                        {
                            if (item.Nombre == Nombre)
                            {
                                Eliminar = item;
                                break;
                            }
                        }
                        if (Eliminar != null)
                        {
                            Contactos.Remove(Eliminar);
                            Console.WriteLine($"Se elimino a {Nombre} de la agenda");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"{Nombre} no existe en la agenda");
                        }
                        Console.Write("Pulsa enter para continuar..");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Ingresa el nombre para buscarlo: ");
                        Nombre = Console.ReadLine();
                        Agenda Buscar = null;
                        foreach (var item in Contactos)
                        {
                            if (item.Nombre == Nombre)
                            {
                                Buscar = item;
                                break;
                            }
                        }
                        if (Buscar != null)
                        {
                            Console.WriteLine($"Nombre: {Buscar.Nombre}");
                            Console.WriteLine($"Numero de telefono: {Buscar.NumTelefono}\n");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"{Nombre} no existe en la agenda");
                        }
                        Console.Write("Pulsa enter para continuar..");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("== Mi Agenda ==\n");
                        foreach (var item in Contactos)
                        {
                            Console.WriteLine($"Nombre: {item.Nombre}");
                            Console.WriteLine($"Numero de telefono: {item.NumTelefono}\n");
                        }
                        Console.Write("Pulsa enter para continuar..");
                        Console.ReadKey();
                        break;
                    case 5:
                        sal = true;
                        break;
                    default:
                        break;
                }
            }
            Console.Clear();
            Console.WriteLine("Adios :)");
            Console.ReadKey();
        }
    }
}