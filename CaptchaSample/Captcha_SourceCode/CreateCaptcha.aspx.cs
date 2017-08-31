using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;

namespace Captcha_SourceCode
{
    public partial class CreateCaptcha : System.Web.UI.Page
    {
        private readonly Random _rand = new Random();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                CreateCaptchaImage();
        }

        private void CreateCaptchaImage()
        {
            string code = string.Empty;
            if (Request.QueryString["New"] == "1")
                code = GetRandomText();
            else
                code = Session["CaptchaCode"].ToString();

            Bitmap bitmap = new Bitmap(200, 60, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bitmap);
            Pen pen = new Pen(Color.Yellow);
            Rectangle rect = new Rectangle(0, 0, 200, 60);

            SolidBrush blue = new SolidBrush(Color.CornflowerBlue);
            SolidBrush black = new SolidBrush(Color.Black);

            int counter = 0;

            g.DrawRectangle(pen, rect);
            g.FillRectangle(blue, rect);

            foreach (char charItem in code)
            {
                g.DrawString(charItem.ToString(), new Font("Comic Sans", 10 + _rand.Next(15, 20), FontStyle.Italic), black, new PointF(10 + counter, 10));
                counter += 28;
            }

            DrawRandomLines(g);
            bitmap.Save(Response.OutputStream, ImageFormat.Gif);

            g.Dispose();
            bitmap.Dispose();
        }

        private void DrawRandomLines(Graphics g)
        {
            SolidBrush yellow = new SolidBrush(Color.Yellow);
            for (var i = 0; i < 20; i++)
                g.DrawLines(new Pen(yellow, 1), GetRandomPoints());
        }

        private Point[] GetRandomPoints()
        {
            Point[] points = { new Point(_rand.Next(0, 150), _rand.Next(1, 150)), new Point(_rand.Next(0, 200), _rand.Next(1, 190)) };
            return points;
        }

        private string GetRandomText()
        {
            StringBuilder randomText = new StringBuilder();
            string alphabets = "012345679ACEFGHKLMNPRSWXZabcdefghijkhlmnopqrstuvwxyz";
            Random r = new Random();
            for (var j = 0; j <= 5; j++)
                randomText.Append(alphabets[r.Next(alphabets.Length)]);

            Session["CaptchaCode"] = randomText.ToString();
            return (string) Session["CaptchaCode"];
        }
    }
}