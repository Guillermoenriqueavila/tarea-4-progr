using System;
using System.Collections.Generic;
using System.Linq;

namespace tarea4prg
{
    class Program
    {
        static void Main(string[] args)
        {

            int Id, operacion, BuscarId;
            String Código, BuscarCodigo, seguir = "si";
            String Nombre, BuscarNombre;
            String Facultad, BuscarFacultad;
            int Edad, Cantidad, BuscarEdad;


            Console.WriteLine("Ingrese la cantidad de estudiantes a guardar");
            Cantidad = int.Parse(Console.ReadLine());
            Estudiantes[] arregloestudiantes = new Estudiantes[Cantidad];
            for (int i = 0; i < Cantidad; i++)
            {
                Console.WriteLine("Ingrese los siguientes datos:");

                Id = i + 1;
                Console.WriteLine("Ingrese el Código:");
                Código = Console.ReadLine();
                Console.WriteLine("Ingrese el Nombre:");
                Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la Edad:");
                Edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la Facultad:");
                Facultad = Console.ReadLine();
                Console.WriteLine("----------------------------------------------------------------------\n");
                arregloestudiantes[i] = new Estudiantes(Id, Código, Nombre, Edad, Facultad);

            };

            while (seguir == "si")
            {
                Console.WriteLine("Digite 1 para buscar por Id \nDigite 2 para buscar por Codigo");
                Console.WriteLine("Digite 3 para buscar por Nombre \nDigite 4 para buscar por Edad \nDigite 5 para buscar por Facultad");
                operacion = int.Parse(Console.ReadLine());
                if (operacion == 1)
                {
                    Console.WriteLine("Buscar registros por ID");
                    BuscarId = int.Parse(Console.ReadLine());
                    IEnumerable<Estudiantes> ConsultaId = from estudiante in arregloestudiantes
                                                          where estudiante.Id == BuscarId
                                                          select estudiante;
                    Console.WriteLine("Resultado de la busqueda por ID");
                    foreach (Estudiantes consulta in ConsultaId)
                    {
                        Console.WriteLine(consulta.mostrar());

                    }

                }
                else if (operacion == 2)
                {
                    Console.WriteLine("Buscar registros por Codigo");
                    BuscarCodigo = Console.ReadLine();
                    IEnumerable<Estudiantes> ConsultaCodigo = from estudiante in arregloestudiantes
                                                              where estudiante.Código == BuscarCodigo
                                                              select estudiante;
                    Console.WriteLine("Resultado de la busqueda por Codigo");
                    foreach (Estudiantes consulta in ConsultaCodigo)
                    {
                        Console.WriteLine(consulta.mostrar());

                    }

                }
                else if (operacion == 3)
                {
                    Console.WriteLine("Buscar registros por Nombre");
                    BuscarNombre = Console.ReadLine();
                    IEnumerable<Estudiantes> ConsultaNombre = from estudiante in arregloestudiantes
                                                              where estudiante.Nombre == BuscarNombre
                                                              select estudiante;
                    Console.WriteLine("Resultado de la busqueda por Nombre");
                    foreach (Estudiantes consulta in ConsultaNombre)
                    {
                        Console.WriteLine(consulta.mostrar());

                    }

                }
                else if (operacion == 4)
                {
                    Console.WriteLine("Buscar registros por Edad");
                    BuscarEdad = int.Parse(Console.ReadLine());
                    IEnumerable<Estudiantes> ConsultaEdad = from estudiante in arregloestudiantes
                                                            where estudiante.Edad == BuscarEdad
                                                            select estudiante;
                    Console.WriteLine("Resultado de la busqueda por Edad");
                    foreach (Estudiantes consulta in ConsultaEdad)
                    {
                        Console.WriteLine(consulta.mostrar());

                    }

                }
                else if (operacion == 5)
                {
                    Console.WriteLine("Buscar registros por Facultad");
                    BuscarFacultad = Console.ReadLine();
                    IEnumerable<Estudiantes> ConsultaFacultad = from estudiante in arregloestudiantes
                                                                where estudiante.Facultad == BuscarFacultad
                                                                select estudiante;
                    Console.WriteLine("Resultado de la busqueda por Facultad");
                    foreach (Estudiantes consulta in ConsultaFacultad)
                    {
                        Console.WriteLine(consulta.mostrar());

                    }

                }
                Console.WriteLine("----------------------------------------------------------------------\n");
                Console.WriteLine("¿Desea realizar otra busqueda? (si/no)");
                seguir = Console.ReadLine();

            }

        }

        


    }
}
