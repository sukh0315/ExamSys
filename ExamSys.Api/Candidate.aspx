<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Candidate.aspx.cs" Inherits="ExamSys.Api.Candidate" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section class="content-header">
        <h1>Candidate
       
        </h1>
        <ol class="breadcrumb">
            <li><a href="#"><i class="fa fa-dashboard"></i>Home</a></li>
            <li class="active">Candidate</li>
        </ol>
    </section>
    <div class="col-md-12">
        <!-- Horizontal Form -->
        <div class="box box-info">
            <div class="box-header with-border">
                <h3 class="box-title">Add / Update Candidate</h3>
            </div>
            <!-- /.box-header -->
            <!-- form start -->

            <div class="box-body">
                <div class="form-group col-md-6">
                    <label class="col-sm-4 control-label" for="inputEmail3">Batch Name <span style="color: red">*</span></label>
                    <div class="col-sm-8">
                        <asp:DropDownList ID="ddlBatchId" runat="server" class="form-control"
                            EnableViewState="True">
                        </asp:DropDownList>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator8" ValidationGroup="save" ControlToValidate="ddlBatchId" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group col-md-6">
                    <label class="col-sm-4 control-label" for="inputPassword3">Registration No<span style="color: red">*</span></label>

                    <div class="col-sm-8">
                        <asp:TextBox ID="txtRegistrationNumber" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="save" ControlToValidate="txtRegistrationNumber" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group col-md-6">
                    <label class="col-sm-4 control-label" for="inputPassword3">Candidate Name<span style="color: red">*</span></label>

                    <div class="col-sm-8">
                        <asp:TextBox ID="txtCandidateName" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ValidationGroup="save" ControlToValidate="txtCandidateName" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group col-md-6">
                    <label class="col-sm-4 control-label" for="inputPassword3">Father Name<span style="color: red">*</span></label>

                    <div class="col-sm-8">
                        <asp:TextBox ID="txtFatherName" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ValidationGroup="save" ControlToValidate="txtFatherName" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group col-md-6">
                    <label class="col-sm-4 control-label" for="inputPassword3">Mother Name<span style="color: red">*</span></label>

                    <div class="col-sm-8">
                        <asp:TextBox ID="txtMotherName" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ValidationGroup="save" ControlToValidate="txtMotherName" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group col-md-6">
                    <label class="col-sm-4 control-label" for="inputPassword3">Date of Birth<span style="color: red">*</span></label>

                    <div class="col-sm-8">
                        <asp:TextBox ID="txtDOBs" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ValidationGroup="save" ControlToValidate="txtDOBs" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group col-md-6">
                    <label class="col-sm-4 control-label" for="inputPassword3">Gender<span style="color: red">*</span></label>

                    <div class="col-sm-8">
                        <asp:DropDownList ClientIDMode="Static" ID="ddlGender" CssClass="form-control" runat="server">
                            <asp:ListItem Value="Male"> Male </asp:ListItem>
                            <asp:ListItem Value="Female">Female</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <asp:HiddenField ID="hdnID" runat="server" />
            </div>
            <!-- /.box-body -->
            <div class="box-footer">
                <asp:Button ID="btnSubmit" runat="server" CssClass="btn btn-primary" Text="Save" ValidationGroup="save" OnClick="btnSubmit_Click" />
                <asp:Button ID="btnback" runat="server" class="btn btn-danger" Text="Reset" OnClick="btnback_Click" />
            </div>
        </div>

        <!-- /.box-footer -->
    </div>
    <!-- /.box -->
    <div class="box-body">
        <div id="datatable-responsive_wrapper" class="dataTables_wrapper form-inline dt-bootstrap no-footer">
            <asp:GridView ID="grd" runat="server" CssClass="table table-striped table-bordered table-hover"
                AutoGenerateColumns="false" EmptyDataText="No Record Found" DataKeyNames="ID"  OnRowCommand="grd_RowCommand"
                AllowPaging="false" PageSize="10">
                <Columns>
                    <asp:TemplateField HeaderText="S.No.">
                        <ItemTemplate>
                            <%# Container.DataItemIndex + 1 %>
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField>
                        <HeaderTemplate>
                          Candidate Name
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:LinkButton ID="butType" runat="server" CommandName="updates" Text='<%# Eval("CandidateName") %>' CommandArgument="<%#((GridViewRow)Container).RowIndex%>"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="BatchName" HeaderText="Batch Name" />
                    <asp:BoundField DataField="CandidateName" HeaderText="CandidateName" />
                    <asp:BoundField DataField="MotherName" HeaderText="Mother Name" />
                    <asp:BoundField DataField="Gender" HeaderText="Gender" />
                    <asp:BoundField DataField="DOB" HeaderText="DOB" />
                     <asp:TemplateField HeaderText="Action">
                        <ItemTemplate>
                            <asp:LinkButton ID="butEnable" runat="server" class="btn btn-warning btn-xs" CommandName="enable" CommandArgument="<%#((GridViewRow)Container).RowIndex%>" Text="Delete"></asp:LinkButton>
                        </ItemTemplate>
                        </asp:TemplateField>

                </Columns>
            </asp:GridView>

        </div>
    </div>
</asp:Content>
