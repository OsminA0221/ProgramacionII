using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    public class EmpleadosRepositoryA : IEmpleadosRepository
    {
        private string _archivo;

        public EmpleadosRepositoryA (string NombreArchivo)
        {
            _archivo = NombreArchivo;
        }

        public void GuardarTodo(List<Empleados> empleado)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(_archivo))
                {
                    foreach (Empleados empleados in empleado)
                    {
                        sw.WriteLine($"{empleados.Nombre},{empleados.Edad},{empleados.Puesto}");
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error al escribir en el archivo" + $"{e.Message}");
            }
        }
        public List<Empleados> Obtener()
        {
            List<Empleados> empleados = new List<Empleados>();
            try
            {
                using (StreamReader sr = new StreamReader(_archivo))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] datos = linea.Split(',');
                        Empleados empleado = new Empleados();
                        {
                            empleado.Nombre = datos[0];
                            empleado.Edad = Convert.ToInt32(datos[1]);
                            empleado.Puesto = datos[2];


                        }
                        empleados.Add(empleado);

                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error al leer el Archivo" + e.Message);
            }

            return empleados;
        }
    }

}
