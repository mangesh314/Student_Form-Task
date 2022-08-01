using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace StudentFrom
{
    public partial class StudentFrom : System.Web.UI.Page
    {
        DataAccessObject.StudentDAL oStudentDAL = new DataAccessObject.StudentDAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
                FillClousedData();
                ddllanguage.Items.Insert(0, "--Select--");
            }
            btnsave.Click += Btnsave_Click;
            btnclear.Click += Btnclear_Click;
        }

        private void Btnclear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        protected void Clear()
        {
            txtname.Text = String.Empty;
            txtemail.Text = String.Empty;
            txtdbo.Text = String.Empty;
            rbtn.Text = String.Empty;
           // ddllanguage.Items = string.Empty;

        }

        protected void LoadData()
        {
            DataSet ds = oStudentDAL.GetAllDetails();
            if (ds.Tables[0].Rows.Count > 0)
            {
                grdstudent.DataSource = ds;
                grdstudent.DataBind();

            }


        }

        private void Btnsave_Click(object sender, EventArgs e)
        {

            BeanRespository.User objunit = new BeanRespository.User();

            try
            {
                // objunit.Id = Convert.ToInt32(txtid.Text);
                objunit.Name = txtname.Text;
                objunit.DOB = Convert.ToDateTime(txtdbo.Text);
                objunit.Email = txtemail.Text;
                objunit.Gender = rbtn.SelectedValue;
                objunit.Language =ddllanguage.SelectedValue.Trim();

                bool result = oStudentDAL.SaveData(objunit);
                if (result)
                {
                    lblmsg.Text = "Record Save Successfully";
                    lblmsg.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblmsg.Text = "Record Save Failed";
                    lblmsg.ForeColor = System.Drawing.Color.Red;
                }
                LoadData();
                Clear();
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        private DataTable GetLanguage()
        {
            DataTable dt = new DataTable();
            try
            {

                dt = oStudentDAL.GetLanguage();
                if (dt.Rows.Count > 0)
                {
                    ddllanguage.DataSource = dt;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
        }
        private void FillClousedData()
        {
            ddllanguage.DataSource = GetLanguage();
            ddllanguage.DataTextField = "Language";
            ddllanguage.DataValueField = "Lang_ID";
            ddllanguage.DataBind();
        }
    }
}