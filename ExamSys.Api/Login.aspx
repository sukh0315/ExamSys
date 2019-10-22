<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ExamSys.Api.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>Examiation System | Log in</title>
    <!-- Tell the browser to be responsive to screen width -->
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">
    <!-- Bootstrap 3.3.7 -->
    <link href="Content/AdminLTE-master/bower_components/bootstrap/dist/css/bootstrap.min.css" rel="stylesheet" />
    <!-- Font Awesome -->
    <link rel="stylesheet" href="Content/AdminLTE-master/bower_components/font-awesome/css/font-awesome.min.css">
    <!-- Ionicons -->
    <link rel="stylesheet" href="Content/AdminLTE-master/bower_components/Ionicons/css/ionicons.min.css">
    <!-- Theme style -->
    <link href="Content/AdminLTE-master/dist/css/AdminLTE.min.css" rel="stylesheet" />
    <!-- iCheck -->
    <link href="Content/AdminLTE-master/plugins/iCheck/square/blue.css" rel="stylesheet" />

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
  <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
  <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
  <![endif]-->

    <!-- Google Font -->
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,600,700,300italic,400italic,600italic">
</head>
<body class="hold-transition login-page">
    <div class="login-box">
        <div class="login-logo">
            <b>Examination System</b>
        </div>
        <!-- /.login-logo -->
        <div class="login-box-body">
            <p class="login-box-msg">Sign in to start</p>

            <form id="form1" runat="server">
                <div class="form-group has-feedback">
                    <asp:TextBox ID="Email" runat="server" class="form-control" placeholder="Email" ValidationGroup="LoginFrame"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="Email" ValidationGroup="LoginFrame" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    <span class="glyphicon glyphicon-envelope form-control-feedback"></span>
                </div>
                <div class="form-group has-feedback">
                    <asp:TextBox ID="Password" runat="server" class="form-control" placeholder="Password" TextMode="Password" ValidationGroup="PwdFrame"></asp:TextBox>
                    <span class="glyphicon glyphicon-lock form-control-feedback"></span>
                      <asp:RequiredFieldValidator ID="reqName" ControlToValidate="Password" ValidationGroup="PwdFrame" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                </div>
                <asp:Label ID="lblMsg" Text="" runat="server" Style="color: #FF0000; font-weight: 700"></asp:Label>
                <div class="row">
                    <div class="col-xs-8">
                    </div>
                    <!-- /.col -->
                    <div class="col-xs-4">
                        <asp:Button ID="btnLogin" runat="server" CssClass="btn btn-primary btn-block btn-flat" Text="Sign In" OnClick="btnLogin_Click" />
                    </div>
                    <!-- /.col -->
                </div>
            </form>
        </div>
        <!-- /.login-box-body -->
    </div>
    <!-- /.login-box -->

    <!-- jQuery 3 -->
    <script src="Content/AdminLTE-master/bower_components/jquery/dist/jquery.min.js"></script>
    <!-- Bootstrap 3.3.7 -->
    <script src="../../bower_components/bootstrap/dist/js/bootstrap.min.js"></script>
    <script src="Content/AdminLTE-master/bower_components/bootstrap/dist/js/bootstrap.min.js"></script>
    <!-- iCheck -->
    <script src="Content/AdminLTE-master/plugins/iCheck/icheck.min.js"></script>
    <script>
        $(function () {
            $('input').iCheck({
                checkboxClass: 'icheckbox_square-blue',
                radioClass: 'iradio_square-blue',
                increaseArea: '20%' /* optional */
            });
        });
</script>
</body>
</html>
