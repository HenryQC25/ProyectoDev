using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevProjectLocal.Repositorios.Interfaces
{
    internal interface IGenericRepository<T> where T : class
    {
        Task<List<T>> Lista(string estatus);
        Task<bool> Guardar(T modelo);
        Task<bool> Editar(T modelo);
        Task<bool> Eliminar(int id);


        ///////////////
    }
}
