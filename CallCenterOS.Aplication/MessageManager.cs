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
    /// Manager de Message
    /// </summary>
    public class MessageManager : GenericManager<Message>
    {
        /// <summary>
        /// Constructor de message manager
        /// </summary>
        /// <param name="context"></param>
        public MessageManager(ApplicationDbContext context) : base(context)
        {
        }
    }
}
