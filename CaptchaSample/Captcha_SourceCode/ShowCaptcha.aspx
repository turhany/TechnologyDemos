<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowCaptcha.aspx.cs" Inherits="Captcha_SourceCode.ShowCaptcha" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Image ID="imgCaptcha" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtCaptcha" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblMessage" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnCaptcha" runat="server" Text="Validate Cpatcha Code"
                            OnClick="btnCaptcha_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
