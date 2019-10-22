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
    public partial class Batch : System.Web.UI.Page
    {
        IBatchService _service = new BatchService();//Service class instance
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindGrid();
            }
        }
        protected void bindGrid()//binding gridview
        {
            ListToDataTable lsttodt = new ListToDataTable();
            var lst = _service.GetBatchesData();
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
        protected void btnSubmit_Click(object sender, EventArgs e)//add update button
        {
            BatchModel mdl = new BatchModel();
            mdl.BatchName = txtBatchName.Text.Trim();
            mdl.BatchCode = txtBatchCode.Text.Trim();
            mdl.AssessmentDate = Convert.ToDateTime(txtAssessmentDate.Text.Trim());
            mdl.Course = txtCourse.Text.Trim();
            mdl.Language = txtLanguage.Text.Trim();
            mdl.NoOfCandidate = Convert.ToInt32(txtNoOfCandidates.Text.Trim());
            if(hdnbatchid.Value !="")
            mdl.ID = Guid.Parse(hdnbatchid.Value);
            bool result = _service.InsertUpdateBatchData(mdl);
            if (result)
            {
                Response.Write("<script>alert('Record saved successfully')</script>");
            }
            bindGrid();

        }
        protected void btnback_Click(object sender, EventArgs e)
        {
            Response.Redirect("Batch.aspx");
        }
        protected void grd_RowCommand(object sender, GridViewCommandEventArgs e)//Row command function for grid functionality
        {

            int rowIndex = Convert.ToInt32(e.CommandArgument.ToString());
            string batchid = this.grd.DataKeys[rowIndex]["ID"].ToString();

            if (e.CommandName == "updates")
            {
                ListToDataTable lsttodt = new ListToDataTable();
                var lst = _service.GetBatchDataByID(Guid.Parse(batchid));
                DataTable dt = lsttodt.ToDataTable(lst);
                if (dt != null && dt.Rows.Count > 0)
                {
                    hdnbatchid.Value = dt.Rows[0]["ID"].ToString();
                    txtBatchName.Text = dt.Rows[0]["BatchName"].ToString();
                    txtBatchCode.Text = dt.Rows[0]["BatchCode"].ToString();
                    txtAssessmentDate.Text = dt.Rows[0]["AssessmentDate"].ToString();
                    txtCourse.Text = dt.Rows[0]["Course"].ToString();
                    txtLanguage.Text = dt.Rows[0]["Language"].ToString();
                    txtNoOfCandidates.Text = dt.Rows[0]["NoOfCandidate"].ToString();
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
                bool result = _service.DeletesBatchData(Guid.Parse(batchid));
                if (result)
                {
                    bindGrid();

                }
            }
               
        }
    }
}