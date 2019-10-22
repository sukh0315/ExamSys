<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ScheduleTest.aspx.cs" Inherits="ExamSys.Api.ScheduleTest" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section class="content-header">
        <h1>Schedule Test
       
        </h1>
        <ol class="breadcrumb">
            <li><a href="#"><i class="fa fa-dashboard"></i>Home</a></li>
            <li class="active">Schedule Test</li>
        </ol>
    </section>
    <div class="col-md-12">
        <!-- Horizontal Form -->
        <div class="box box-info">
            <div class="box-header with-border">
                <h3 class="box-title">Add / Update Schedule Test</h3>
            </div>
            <!-- /.box-header -->
            <!-- form start -->

            <div class="box-body">
                <div class="form-group col-md-6">
                    <label class="col-sm-4 control-label" for="inputEmail3">Test Name <span style="color: red">*</span></label>
                    <div class="col-sm-8">
                        <asp:TextBox ID="txtTestName" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" ValidationGroup="save" ControlToValidate="txtTestName" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group col-md-6">
                    <label class="col-sm-4 control-label" for="inputEmail3">Batch Name <span style="color: red">*</span></label>
                    <div class="col-sm-8">
                        <asp:DropDownList ID="ddlBatchID" runat="server" CssClass="form-control"></asp:DropDownList>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="save" ControlToValidate="ddlBatchID" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group col-md-6">
                    <label class="col-sm-4 control-label" for="inputEmail3">Time Allowed <span style="color: red">*</span></label>
                    <div class="col-sm-8">
                        <asp:TextBox ID="txtTimeAllowed" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ValidationGroup="save" ControlToValidate="txtTimeAllowed" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group col-md-6">
                    <label class="col-sm-4 control-label" for="inputEmail3">No of Questions <span style="color: red">*</span></label>
                    <div class="col-sm-8">
                        <asp:TextBox ID="txtNoofQuestions" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ValidationGroup="save" ControlToValidate="txtNoofQuestions" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator>
                    </div>
                </div>

                <div class="form-group col-md-6">
                    <label class="col-sm-4 control-label" for="inputPassword3">Test Start Date<span style="color: red">*</span></label>

                    <div class="col-sm-8">
                        <asp:TextBox ID="txtStartDate" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ValidationGroup="save" ControlToValidate="txtStartDate" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group col-md-6">
                    <label class="col-sm-4 control-label" for="inputPassword3">Test End Date<span style="color: red">*</span></label>

                    <div class="col-sm-8">
                        <asp:TextBox ID="txtTestEndDate" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ValidationGroup="save" ControlToValidate="txtTestEndDate" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group col-md-6">
                    <label class="col-sm-4 control-label" for="inputPassword3">Max Marks<span style="color: red">*</span></label>

                    <div class="col-sm-8">
                        <asp:TextBox ID="txtMaxMarks" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ValidationGroup="save" ControlToValidate="txtMaxMarks" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group col-md-6">
                    <label class="col-sm-4 control-label" for="inputPassword3">Pass Marks<span style="color: red">*</span></label>

                    <div class="col-sm-8">
                        <asp:TextBox ID="txtPassMarks" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ValidationGroup="save" ControlToValidate="txtPassMarks" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group col-md-6">
                    <label class="col-sm-4 control-label" for="inputPassword3">No Of Sets<span style="color: red">*</span></label>

                    <div class="col-sm-8">
                        <asp:TextBox ID="txtNoofSets" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" ValidationGroup="save" ControlToValidate="txtNoofSets" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group col-md-6">
                    <label class="col-sm-4 control-label" for="inputEmail3">Question Count <span style="color: red">*</span></label>
                    <div class="col-sm-8">
                        <asp:TextBox ID="txtQuestionCount" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" ValidationGroup="save" ControlToValidate="txtQuestionCount" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group col-md-6">
                    <label class="col-sm-4 control-label" for="inputEmail3">Language <span style="color: red">*</span></label>
                    <div class="col-sm-8">
                        <asp:TextBox ID="txtLanguage" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator11" ValidationGroup="save" ControlToValidate="txtLanguage" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group col-md-6">
                    <label class="col-sm-4 control-label" for="inputEmail3">Confirm Assessment Date <span style="color: red">*</span></label>
                    <div class="col-sm-8">
                        <asp:TextBox ID="txtConfirmAssessmentDate" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator12" ValidationGroup="save" ControlToValidate="txtConfirmAssessmentDate" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator>
                    </div>
                </div>
            </div>
            <asp:HiddenField ID="hdnValue" runat="server" />
            <!-- /.box-body -->
            <div class="box-footer">
                <asp:Button ID="btnSubmit" runat="server" CssClass="btn btn-primary" Text="Save" ValidationGroup="save" OnClick="btnSubmit_Click" />
                <asp:Button ID="btnback" runat="server" class="btn btn-danger" Text="Reset" OnClick="btnback_Click" />
            </div>
            <!-- /.box-footer -->
        </div>
        <!-- /.box -->
    </div>
    <div class="box-body">
        <div id="datatable-responsive_wrapper" class="dataTables_wrapper form-inline dt-bootstrap no-footer">

            <asp:GridView ID="grd" runat="server" CssClass="table table-striped table-bordered table-hover"
                AutoGenerateColumns="false" EmptyDataText="No Record Found" DataKeyNames="ID"
                AllowPaging="false" PageSize="10" OnRowCommand="grd_RowCommand">
                <Columns>
                    <asp:TemplateField HeaderText="S.No.">
                        <ItemTemplate>
                            <%# Container.DataItemIndex + 1 %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <HeaderTemplate>
                            Batch Name
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:LinkButton ID="butType" runat="server" CommandName="updates" Text='<%# Eval("BatchName") %>' CommandArgument="<%#((GridViewRow)Container).RowIndex%>"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:BoundField DataField="TestName" HeaderText="Test Name" />
                    <asp:BoundField DataField="TimeAllowed" HeaderText="Time Allowed" />
                    <asp:BoundField DataField="Num_of_Questions" HeaderText="Num of Questions" />
                    <asp:BoundField DataField="Language" HeaderText="Language" />
                    <asp:BoundField DataField="TestStartDate" HeaderText="Test Start Date" />
                    <asp:BoundField DataField="TestEndDate" HeaderText="Test End Date" />
                    <asp:BoundField DataField="MaxMarks" HeaderText="Max Marks" />
                    <asp:BoundField DataField="PassMarks" HeaderText="Pass Marks" />
                    <asp:TemplateField HeaderText="Delete">
                        <ItemTemplate>
                            <asp:LinkButton Text="Delete" ID="butEnable" runat="server" class="btn btn-warning btn-xs" CommandName="enable" CommandArgument="<%#((GridViewRow)Container).RowIndex%>"></asp:LinkButton>
                        </ItemTemplate>
                        </asp:TemplateField>
                </Columns>
            </asp:GridView>

        </div>
    </div>
</asp:Content>
