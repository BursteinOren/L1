using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.IO;


namespace L1
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Calendar1.BackColor = Color.BlueViolet;
            }

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            lblCalendar1.Text = Calendar1.SelectedDate.ToShortDateString();
            if (Calendar1.BackColor == Color.Yellow)
                Calendar1.BackColor = Color.Green;
            else Calendar1.BackColor = Color.Yellow;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Guid guid = Guid.NewGuid();
            //FileUpload1.SaveAs(MapPath("MyFiles") + "/" + guid + "_" + FileUpload1.FileName);   
            FileUpload1.SaveAs(MapPath("MyFiles") + "/" + guid + Path.GetExtension(FileUpload1.FileName));
        }
    }
}