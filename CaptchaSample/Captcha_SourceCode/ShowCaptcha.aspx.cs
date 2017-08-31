using System;
using System.Drawing;

namespace Captcha_SourceCode
{
    public partial class ShowCaptcha : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                imgCaptcha.ImageUrl = "~/CreateCaptcha.aspx?New=1";
        }

        protected void btnCaptcha_Click(object sender, EventArgs e)
        {
            imgCaptcha.ImageUrl = "~/CreateCaptcha.aspx?New=0";
            if (Session["CaptchaCode"] != null && txtCaptcha.Text == Session["CaptchaCode"].ToString())
            {
                lblMessage.ForeColor = Color.Green;
                lblMessage.Text = "Captcha code validated successfully!!";
            }
            else
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "Captcha code is wrong!!";
            }
        }
    }
}