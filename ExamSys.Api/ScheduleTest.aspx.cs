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
    public partial class ScheduleTest : System.Web.UI.Page
    {
        IScheduleTestService _service = new ScheduleTestService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindBatchList();
                bindGrid();
            }
        }
        protected void bindBatchList()//batch list binding
        {
            ListToDataTable lsttodt = new ListToDataTable();
            BatchService service = new BatchService();
            var lst = service.GetBatchesData().Select(x => new { x.BatchName, x.ID }).ToList();
            DataTable dt = lsttodt.ToDataTable(lst);
            if (dt != null && dt.Rows.Count > 0)
            {
                ddlBatchID.DataSource = dt;
                ddlBatchID.DataTextField = "BatchName";
                ddlBatchID.DataValueField = "ID";
                ddlBatchID.DataBind();

            }
            else
            {
                ddlBatchID.DataBind();
            }
        }
        protected void bindGrid()//gridview binding
        {
            ListToDataTable lsttodt = new ListToDataTable();
            var lst = _service.GetScheduleTestList();
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
        protected void btnSubmit_Click(object sender, EventArgs e)//Add update button
        {
            ScheduleTestModel mdl = new ScheduleTestModel();
            mdl.BatchID = Guid.Parse(ddlBatchID.SelectedValue);
            mdl.TestName = txtTestName.Text.Trim();
            mdl.TimeAllowed = Convert.ToInt32(txtTimeAllowed.Text.Trim());
            mdl.Num_of_Questions = Convert.ToInt32(txtNoofQuestions.Text.Trim());
            mdl.Language = txtLanguage.Text.Trim();
            mdl.TestStartDate = Convert.ToDateTime(txtStartDate.Text.Trim());
            mdl.TestEndDate = Convert.ToDateTime(txtTestEndDate.Text.Trim());
            mdl.MaxMarks = Convert.ToInt32(txtMaxMarks.Text.Trim());
            mdl.PassMarks = Convert.ToInt32(txtPassMarks.Text.Trim());
            mdl.NumberOfSets = Convert.ToInt32(txtNoofSets.Text.Trim());
            mdl.QuestionCount = Convert.ToInt32(txtQuestionCount.Text.Trim());
            mdl.Language = txtLanguage.Text.Trim();
            mdl.ConfirmAssessmentDate = Convert.ToDateTime(txtConfirmAssessmentDate.Text.Trim());
            mdl.Language = txtLanguage.Text.Trim();
            mdl.IsNegative = false;
            mdl.IsReattempt = false;
            mdl.NegativePercent = 0;
            if (hdnValue.Value != "")
                mdl.ID = Guid.Parse(hdnValue.Value);
            bool result = _service.InsertUpdateScheduleTestMaster(mdl);
            bindGrid();
            if (result)
            {
                Response.Write("<script>alert('Record saved successfully')</script>");
            }

        }
        protected void btnback_Click(object sender, EventArgs e)
        {
            Response.Redirect("ScheduleTest.aspx");
        }
        protected void grd_RowCommand(object sender, GridViewCommandEventArgs e)//Row command for grid functionality
        {

            int rowIndex = Convert.ToInt32(e.CommandArgument.ToString());
            string Id = this.grd.DataKeys[rowIndex]["ID"].ToString();

            if (e.CommandName == "updates")
            {
                ListToDataTable lsttodt = new ListToDataTable();
                var lst = _service.GetScheduleTestListByID(Guid.Parse(Id));
                DataTable dt = lsttodt.ToDataTable(lst);
                if (dt != null && dt.Rows.Count > 0)
                {
                    hdnValue.Value = dt.Rows[0]["ID"].ToString();
                    txtTestName.Text = dt.Rows[0]["TestName"].ToString();
                    txtTimeAllowed.Text = dt.Rows[0]["TimeAllowed"].ToString();
                    txtNoofQuestions.Text = dt.Rows[0]["Num_of_Questions"].ToString();
                    txtStartDate.Text = dt.Rows[0]["TestStartDate"].ToString();
                    txtTestEndDate.Text = dt.Rows[0]["TestEndDate"].ToString();
                    ddlBatchID.SelectedValue = dt.Rows[0]["BatchID"].ToString();
                    txtMaxMarks.Text = dt.Rows[0]["MaxMarks"].ToString();
                    txtPassMarks.Text = dt.Rows[0]["PassMarks"].ToString();
                    txtNoofSets.Text = dt.Rows[0]["NumberOfSets"].ToString();
                    txtQuestionCount.Text = dt.Rows[0]["QuestionCount"].ToString();
                    txtLanguage.Text = dt.Rows[0]["Language"].ToString();
                    txtConfirmAssessmentDate.Text = dt.Rows[0]["ConfirmAssessmentDate"].ToString();
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
                bool result = _service.DeleteScheduleTest(Guid.Parse(Id));
                if (result)
                {
                    bindGrid();

                }
            }
        }
    }
}