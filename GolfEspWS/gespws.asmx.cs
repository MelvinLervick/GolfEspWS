using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;
using GolfEspWS.WsData;

namespace GolfEspWS
{
    /// <summary>
    /// Summary description for gespws
    /// http://golfesp.com/GolfEspWS/
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/GolfEspWS/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class gespws : System.Web.Services.WebService
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

        //[WebMethod(Description = "Get all Course Names.")]
        //[ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        //public string Courses()
        //{
        //    var database = new AccessDatabase(ConfigurationManager.AppSettings["PROVIDER"], ConfigurationManager.AppSettings["DSN"]);
        //    database.LoadAllTableData( "Tees" );
        //    var courses = database.DbDataSet.Tables["Tees"];
        //    var courseNames = (from c in courses.AsEnumerable() select c.Field<string>("Name")).ToList();

        //    JavaScriptSerializer js = new JavaScriptSerializer();
        //    string strJSON = js.Serialize(courseNames);

        //    return strJSON;
        //    //return courseNames;
        //}

        //[WebMethod]
        //public List<string> Tees()
        //{
        //    var database = new AccessDatabase(ConfigurationManager.AppSettings["PROVIDER"], ConfigurationManager.AppSettings["DSN"]);
        //    database.LoadAllTableData("Tees");
        //    var tees = database.DbDataSet.Tables["Tees"];
        //    var teeNames = (from t in tees.AsEnumerable() select t.Field<string>("TeeName")).ToList();

        //    return teeNames;
        //}
    }
}
