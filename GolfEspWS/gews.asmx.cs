using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.ServiceModel.Web;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;
using GolfEspWS.WsData;

namespace GolfEspWS
{
    /// <summary>
    /// Summary description for gews
    /// http://rylinks.com/
    /// </summary>
    [WebService(Description = "Web Service to mange GolfESP data requests.", Namespace = "http://tempuri.org/GolfEspWS/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class gews : System.Web.Services.WebService
    {
        [WebMethod(Description = "Get all Tees.")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string GetCourses()
        {
            var js = new JavaScriptSerializer();
            string courses = js.Serialize(new WsCourses());

            return courses;
        }

        [WebMethod(Description = "Get all course Tees.")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string GetTees()
        {
            var js = new JavaScriptSerializer();
            string tees = js.Serialize(new WsTees());

            return tees;
        }

    }
}
