<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Batch.aspx.cs" Inherits="ExamSys.Api.Batch" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section class="content-header">
        <h1>Batch
       
        </h1>
        <ol class="breadcrumb">
            <li><a href="#"><i class="fa fa-dashboard"></i>Home</a></li>
            <li class="active">Batch</li>
        </ol>
    </section>
    <div class="col-md-12">
        <!-- Horizontal Form -->
        <div class="box box-info">
            <div class="box-header with-border">
                <h3 class="box-title">Add / Update Batch</h3>
            </div>
            <!-- /.box-header -->
            <!-- form start -->

            <div class="box-body">
                <div class="form-group col-md-6">
                    <label class="col-sm-4 control-label" for="inputEmail3">Batch Name <span style="color: red">*</span></label>
                    <div class="col-sm-8">
                        <asp:TextBox ID="txtBatchName" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" ValidationGroup="save" ControlToValidate="txtBatchName" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group col-md-6">
                    <label class="col-sm-4 control-label" for="inputPassword3">Batch Code<span style="color: red">*</span></label>

                    <div class="col-sm-8">
                        <asp:TextBox ID="txtBatchCode" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ValidationGroup="save" ControlToValidate="txtBatchCode" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group col-md-6">
                    <label class="col-sm-4 control-label" for="inputPassword3">Assessment Date<span style="color: red">*</span></label>

                    <div class="col-sm-8">
                        <asp:TextBox ID="txtAssessmentDate" runat="server" CssClass="form-control" ToolTip="MM/dd/yyyy"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="save" ControlToValidate="txtAssessmentDate" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group col-md-6">
                    <label class="col-sm-4 control-label" for="inputPassword3">Course<span style="color: red">*</span></label>

                    <div class="col-sm-8">
                        <asp:TextBox ID="txtCourse" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ValidationGroup="save" ControlToValidate="txtCourse" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group col-md-6">
                    <label class="col-sm-4 control-label" for="inputPassword3">Language<span style="color: red">*</span></label>

                    <div class="col-sm-8">
                        <asp:TextBox ID="txtLanguage" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ValidationGroup="save" ControlToValidate="txtLanguage" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group col-md-6">
                    <label class="col-sm-4 control-label" for="inputPassword3">No Of Candidates<span style="color: red">*</span></label>

                    <div class="col-sm-8">
                        <asp:TextBox ID="txtNoOfCandidates" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ValidationGroup="save" ControlToValidate="txtNoOfCandidates" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator>

                    </div>
                </div>
                <asp:HiddenField ID="hdnbatchid" runat="server" />
            </div>
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
                            Batch Id
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:LinkButton ID="butType" runat="server" CommandName="updates" Text='<%# Eval("BatchName") %>' CommandArgument="<%#((GridViewRow)Container).RowIndex%>"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="BatchCode" HeaderText="Batch Code" />
                    <asp:BoundField DataField="AssessmentDate" HeaderText="Assessment Date" />
                    <asp:BoundField DataField="NoOfCandidate" HeaderText="No of Candidates" />
                    <asp:TemplateField HeaderText="Delete">
                        <ItemTemplate>
                            <asp:LinkButton ID="butEnable" runat="server" class="btn btn-warning btn-xs" CommandName="enable" CommandArgument="<%#((GridViewRow)Container).RowIndex%>" Text="Delete"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>

        </div>
    </div>
</asp:Content>
