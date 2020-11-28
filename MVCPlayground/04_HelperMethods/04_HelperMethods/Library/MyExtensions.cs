using System;
using System.Web.Mvc;

namespace _04_HelperMethods.Library

{
    public static class MyExtensions
    {
        public static MvcHtmlString Button(this HtmlHelper helper, string id = "", ButtonType type = ButtonType.button, string text = "")
        {
            string html = string.Format("<button id='{0}' name='{0}' type='{1}'>{2}</button>", id, type.ToString(), text);
            return MvcHtmlString.Create(html);
        }


        public static MvcHtmlString ButtonWithTagBuilder(this HtmlHelper helper, string id = "", string cssClass = "", ButtonType type = ButtonType.button, string text = "")
        {
            TagBuilder tag = new TagBuilder("button");
            tag.AddCssClass(cssClass);
            tag.GenerateId(id);
            tag.Attributes.Add("type", type.ToString());
            tag.Attributes.Add("name", id);
            tag.SetInnerText(text);

            return MvcHtmlString.Create(tag.ToString());
        }


        public static MvcHtmlString Paragraph(this HtmlHelper helper, string id = "", int borderSize = 3, string borderType = "solid", Func<object, System.Web.WebPages.HelperResult> template = null)
        {
            string html = string.Format("<p id='{0}' name='{0}' style='border-width:{1}px;border-style:{2}'>{3}</p>", id, borderSize.ToString(), borderType, template.Invoke(null));
            return MvcHtmlString.Create(html);
        }
    }

    public enum ButtonType
    {
        button,
        submit,
        reset
    }
}