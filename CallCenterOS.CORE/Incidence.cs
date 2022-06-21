using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterOS.CORE
{
    /// <summary>
    /// Entidad de dominio de inscidencias
    /// </summary>
    public class Incidence
    {
        /// <summary>
        /// Identificador de la incidencia
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Nombre del equipo
        /// </summary>
        public string Equipment { get; set; }
        /// <summary>
        /// Fecha de creación de la incidencia
        /// </summary>
        public DateTime CreatedDate { get; set; }
        /// <summary>
        /// Fecha de cierre de la incidencia
        /// </summary>
        public DateTime? ClosedDate { get; set; }
        /// <summary>
        /// Nota interna de la incidencia
        /// </summary>
        public string InternalNote { get; set; }
        /// <summary>
        /// Estado de la incidencia
        /// </summary>
        public IncidenceStatus Status { get; set; }
        /// <summary>
        /// Prioridad de la incidencia
        /// </summary>
        public IncidencePriority Priority { get; set; }
        /// <summary>
        /// Tipo de incidencia
        /// </summary>
        public IncidenceType IncidenceType { get; set; }
        /// <summary>
        /// Usuario que ha creado la incidencia
        /// </summary>
        public ApplicationUser User { get; set; }
        /// <summary>
        /// Identificador del usuario que ha creado la incidencia
        /// </summary>
        [ForeignKey("User")]
        public string User_Id { get; set; }
        /// <summary>
        /// Colección de mensajes
        /// </summary>
        public virtual List<Message> Messages { get; set; }

    }
}
