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
    public partial class IncidenceCreate : System.Web.UI.Page
    {
        IncidenceManager incidenceManager = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            ApplicationDbContext context = new ApplicationDbContext();
            incidenceManager = new IncidenceManager(context);
            ddltype.DataSource = Enum.GetValues(typeof(IncidenceType));
            ddltype.DataBind();
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {

                Incidence incidence = new Incidence
                {
                    CreatedDate = DateTime.Now,
                    Equipment = txtEquipment.Text,
                    IncidenceType = (IncidenceType)Enum.Parse(typeof(IncidenceType), ddltype.SelectedValue),
                    Priority = IncidencePriority.Low,
                    Status = IncidenceStatus.Open,
                    User_Id = User.Identity.GetUserId(),
                    Messages = new List<Message>
                    {
                        new Message
                        {
                            Date = DateTime.Now,
                            Text = TxtIncidence.Text,
                            User_Id = User.Identity.GetUserId()
                        }
                    }


                };
                throw new Exception("Error");
                incidenceManager.Add(incidence);
                incidenceManager.Context.SaveChanges();
                Response.Redirect("Inciodences");
            }
            catch (Exception ex)
            {
                //TODO: Escribir el error en un log
                var err = new CustomValidator
                {
                    ErrorMessage = "Se ha producido un error",
                    IsValid = false
                };
                Page.Validators.Add(err);
            }
        }
    }
}