using CallCenterOS.Aplication;
using CallCenterOS.CORE;
using CallCenterOS.DAL;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CallCenterOS.Web.Client
{
    public partial class IncidenceEdit : System.Web.UI.Page
    {
        IncidenceManager incidenceManager = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            ApplicationDbContext context = new ApplicationDbContext();
            incidenceManager = new IncidenceManager(context);
            int id = 0;
            if(Request.QueryString["id"]!=null)
            {
                if(int.TryParse(Request.QueryString["id"],out id))
                {
                    var incidence = incidenceManager.GetById(id);
                    if(incidence!=null)
                    {
                        if(incidence.User_Id == User.Identity.GetUserId())
                        {
                            LoadIncidence(incidence);
                        }
                    }
                }
            }
        }
        private void LoadIncidence (Incidence incidence)
        {
            txtId.Value = incidence.Id.ToString();
            txtEquipment.Text = incidence.Equipment;
            ddlType.Text = incidence.IncidenceType.ToString();
        }
    }
}