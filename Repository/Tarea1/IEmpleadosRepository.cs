using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    public interface IEmpleadosRepository
    {
        List<Empleados> Obtener();
        void GuardarTodo(List<Empleados> empleado );
    }
}
