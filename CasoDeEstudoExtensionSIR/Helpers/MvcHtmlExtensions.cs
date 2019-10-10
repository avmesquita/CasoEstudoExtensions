using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;

namespace CasoDeEstudoExtensionSIR.Helpers
{
    public struct FieldTypeSIR
    {
        public string name;
        public string size;
        public string unit;
    }

    public enum SIRDatatype 
    { 
        Default,
        CodigoPostal,
        Telemovel,
        NICP,
        NIC,
        CIN
    }


    public static class MvcHtmlExtensions
    {
        public static MvcHtmlString TextBoxSIRFor<TModel, TValue>(this HtmlHelper<TModel> htmlHelper,
           Expression<Func<TModel, TValue>> expression, object htmlAttributes, SIRDatatype sirdt = SIRDatatype.Default)
        {
            RouteValueDictionary routeValues = new RouteValueDictionary(htmlAttributes);

            switch (sirdt)
            {
                case SIRDatatype.CodigoPostal: 
                    routeValues.Add("style", "max-width:8em;");
                    break;
                case SIRDatatype.Telemovel:
                    routeValues.Add("style", "max-width:9em;");
                    break;
                case SIRDatatype.NICP:
                    routeValues.Add("style", "max-width:9em;");
                    break;
                case SIRDatatype.NIC:
                    routeValues.Add("style", "max-width:9em;");
                    break;
            }

            return System.Web.Mvc.Html.InputExtensions.TextBoxFor(htmlHelper, expression, routeValues);
        }

        public static MvcHtmlString TextBoxSIR(this HtmlHelper htmlHelper,
           string name, string value, string format, object htmlAttributes, SIRDatatype sirdt = SIRDatatype.Default)
        {
            RouteValueDictionary routeValues = new RouteValueDictionary(htmlAttributes);

            switch (sirdt)
            {
                case SIRDatatype.CodigoPostal:
                    routeValues.Add("style", "max-width:25%;");
                    break;
                case SIRDatatype.Telemovel:
                    routeValues.Add("style", "max-width:9em;");
                    break;
                case SIRDatatype.NICP:
                    routeValues.Add("style", "max-width:10em;");
                    break;
                case SIRDatatype.NIC:
                    routeValues.Add("style", "max-width:75%;");
                    break;
                case SIRDatatype.CIN:
                    routeValues.Add("style", "max-width:70px;");
                    break;
            }

            return System.Web.Mvc.Html.InputExtensions.TextBox(htmlHelper, name, value, format, routeValues);
        }
    }
}