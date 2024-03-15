using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    public class GestorEmpleados
    {
        private IEmpleadosRepository _repository;

        public GestorEmpleados(IEmpleadosRepository repository)
        {
            _repository = repository;
        }

        public List<Empleados> ObtenerTodosLosEMpleados()
        {
            return _repository.Obtener();
        }

        public void AgregarEmpleado(Empleados empleado)
        {
            List<Empleados> empleados = _repository.Obtener();
            empleados.Add(empleado);
            _repository.GuardarTodo(empleados);
        }
    }
}
