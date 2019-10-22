using ExamSys.Biz.Interfaces;
using ExamSys.Biz.Models;
using ExamSys.Biz.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamSys.Api
{
    public partial class Candidate : System.Web.UI.Page
    {
        ICandidateService _service = new CandidateService();//Service instance
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindBatchList();
                bindGrid();
            }
        }
        protected void bindBatchList()//binding batches
        {
            ListToDataTable lsttodt = new ListToDataTable();
            BatchService service = new BatchService();
            var lst = service.GetBatchesData().Select(x=> new { x.BatchName, x.ID}).ToList();
            DataTable dt = lsttodt.ToDataTable(lst);
            if (dt != null && dt.Rows.Count > 0)
            {
                ddlBatchId.DataSource = dt;
                ddlBatchId.DataTextField = "BatchName";
                ddlBatchId.DataValueField = "ID";
                ddlBatchId.DataBind();

            }
            else
            {
                ddlBatchId.DataBind();
            }
        }
        protected void bindGrid()//binding grid view
        {
            ListToDataTable lsttodt = new ListToDataTable();
            var lst = _service.GetCandidateList();
            DataTable dt = lsttodt.ToDataTable(lst);
            if (dt != null && dt.Rows.Count > 0)
            {
                grd.DataSource = dt;
                grd.DataBind();
            }
            else
            {
                grd.DataBind();
            }
        }
        protected void btnSubmit_Click(object sender, EventArgs e)//Save method
        {
            CandidateModel mdl = new CandidateModel();
            mdl.CandidateName = txtCandidateName .Text.Trim();
            mdl.BatchID = Guid.Parse(ddlBatchId.SelectedValue);
            mdl.RegistrationNo = txtRegistrationNumber.Text.Trim();
            mdl.DOB =txtDOBs.Text.Trim();
            mdl.FatherName = txtFatherName.Text.Trim();
            mdl.MotherName = txtMotherName.Text.Trim();
            mdl.Gender = ddlGender.SelectedValue;
            if (hdnID.Value != "")
                mdl.ID = Guid.Parse(hdnID.Value);
            bool result = _service.InsertUpdateCandidate(mdl);
            bindGrid();
            if (result)
            {
                Response.Write("<script>alert('Record saved successfully')</script>");
            }
         
        }
        protected void btnback_Click(object sender, EventArgs e)//backbutton
        {
            Response.Redirect("Candidate.aspx");
        }
        protected void grd_RowCommand(object sender, GridViewCommandEventArgs e)//row command function
        {

            int rowIndex = Convert.ToInt32(e.CommandArgument.ToString());
            string candidateId = this.grd.DataKeys[rowIndex]["ID"].ToString();

            if (e.CommandName == "updates")
            {
                ListToDataTable lsttodt = new ListToDataTable();
                var lst = _service.CandidateListById(Guid.Parse(candidateId));
                DataTable dt = lsttodt.ToDataTable(lst);
                if (dt != null && dt.Rows.Count > 0)
                {
                    hdnID.Value = dt.Rows[0]["ID"].ToString();
                    txtRegistrationNumber.Text = dt.Rows[0]["RegistrationNo"].ToString();
                    txtCandidateName.Text = dt.Rows[0]["CandidateName"].ToString();
                    txtFatherName.Text = dt.Rows[0]["FatherName"].ToString();
                    txtMotherName.Text = dt.Rows[0]["MotherName"].ToString();
                    txtDOBs.Text = dt.Rows[0]["DOB"].ToString();
                    ddlBatchId.SelectedValue = dt.Rows[0]["BatchID"].ToString();
                    ddlGender.SelectedValue = dt.Rows[0]["Gender"].ToString();
                    btnSubmit.Text = "Update";
                }
                else
                {
                    //do nothing
                    btnSubmit.Text = "Save";
                }
            }
            else
            {
                DataTable dt = new DataTable();
                bool result = _service.DeleteCandidate(Guid.Parse(candidateId));
                if (result)
                {
                    bindGrid();

                }
            }
        }

    }
}