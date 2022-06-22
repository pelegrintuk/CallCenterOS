using CallCenterOS.CORE;
using CallCenterOS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterOS.Aplication
{
    /// <summary>
    /// Manager de incidences
    /// </summary>
    public class IncidenceManager : GenericManager<Incidence>
    {
        /// <summary>
        /// Constructor del manager de incidences
        /// </summary>
        /// <param name="context"></param>
        public IncidenceManager(ApplicationDbContext context) : base(context)
        {
        }
        /// <summary>
        /// Metodo que retorna todas las incidencias de un usuario
        /// </summary>
        /// <param name="userId">Identificador de usuario</param>
        /// <returns>Todas las incidencias del usuario</returns>
        public IQueryable<Incidence>GetByUserId(string userId)
        {
            return Context.Set<Incidence>().Where(e => e.User_Id == userId);
        }
        /// <summary>
        /// Obtiene una incidencia con sus mensajes
        /// </summary>
        /// <param name="id">Identificador de la incidencia</param>
        /// <returns>Incidencia con sus mensajes o null en caso de no existir</returns>
        public Incidence GetByIdAndMessages(int id)
        {
            return Context.Set<Incidence>().Include("Messages").Where(i => i.Id == id).SingleOrDefault();
        }
    }
}
