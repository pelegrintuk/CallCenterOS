using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CallCenterOS.CORE
{
    /// <summary>
    /// Clase de dominio mensaje
    /// </summary>
    public class Message
    {
        /// <summary>
        /// Identificador del mensaje
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Fecha de creación del mensaje
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Contenido del mensaje
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// Usuario que escribe el mensaje
        /// </summary>
        public ApplicationException User { get; set; }
        /// <summary>
        /// Identificador de el usuario que escribe el mensaje
        /// </summary>
        [ForeignKey("User")]
        public string User_Id { get; set; }
        /// <summary>
        /// Incidencia a la que pertenece el mensaje
        /// </summary>
        public Incidence Incidence { get; set; }
        /// <summary>
        /// Identificador de la incidencia a la que pertenece el mensaje
        /// </summary>
        [ForeignKey("Incidence")]
        public int Incidence_Id { get; set; }
    }
}