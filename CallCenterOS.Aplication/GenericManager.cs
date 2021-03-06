using CallCenterOS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterOS.Aplication
{
    /// <summary>
    /// Clase generica de Manager
    /// </summary>
    public class GenericManager<T>
        where T:class
    {
        /// <summary>
        /// Contexto de datos del manager
        /// </summary>
        public ApplicationDbContext Context { get; private set; }
        /// <summary>
        /// Constructor del manager
        /// </summary>
        /// <param name="context"></param>
        public GenericManager(ApplicationDbContext context)
        {
            Context = context;
        }
        /// <summary>
        /// Añade una entidad al contexto de datos
        /// </summary>
        /// <param name="entity">Entidad a añadir</param>
        /// <returns>Entidad añadida</returns>
        public T Add(T entity)
        {
            return Context.Set<T>().Add(entity);
        }
        /// <summary>
        /// Elimina entidad del contexto de datos
        /// </summary>
        /// <param name="entity">Entidad a eliminar</param>
        /// <returns>Entidad eliminada</returns>
        public T Remove(T entity)
        {
            return Context.Set<T>().Remove(entity);
        }
        /// <summary>
        /// Obtiene una entidad por sus posibles claves
        /// </summary>
        /// <param name="Key">Claves del objeto</param>
        /// <returns>Entidad si es encontrada</returns>
        public T GetById(object[] Key)
        {
            return Context.Set<T>().Find(Key);
        }
        /// <summary>
        /// Obtiene una entidad por su clave int
        /// </summary>
        /// <param name="id">identificador</param>
        /// <returns>Entidad si es encontrada</returns>
        public T GetById(int id)
        {
            return GetById(new object[] { id });
        }
    }
}
