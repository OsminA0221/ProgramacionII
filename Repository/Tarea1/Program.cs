using Tarea1;
string archivoEmpleados = "empleados.txt";

IEmpleadosRepository empleadoRepository = new EmpleadosRepositoryA(archivoEmpleados);
GestorEmpleados gestorEmpleados = new GestorEmpleados(empleadoRepository);

//Agregar algunos empleados
gestorEmpleados.AgregarEmpleado(new Empleados { Nombre = "Juan", Edad = 27, Puesto = "Gerente" });
gestorEmpleados.AgregarEmpleado(new Empleados { Nombre = "Jose", Edad = 30, Puesto = "Supervisor" });

Console.WriteLine("Todos los Empleados");
foreach (var empleado in gestorEmpleados.ObtenerTodosLosEMpleados())
    Console.WriteLine($"Nombre: {empleado.Nombre}, Edad: {empleado.Edad}, Puesto: {empleado.Puesto}");