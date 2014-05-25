using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Runtime.Serialization;

namespace GolfEspWS.WsData
{
    [DataContract]
    public class WsCourses
    {
        [DataMember]
        public List<Course> Courses { get; set; }

        public WsCourses()
        {
            var database = new AccessDatabase( ConfigurationManager.AppSettings["PROVIDER"],
                ConfigurationManager.AppSettings["DSN"] );
            database.LoadAllTableData("Tees");
            var courses = database.DbDataSet.Tables["Tees"];

            Courses = new List<Course>();
            foreach ( var course in courses.AsEnumerable() )
            {
                Courses.Add( new Course
                {
                    CourseId = course.Field<int>( "CourseId" ),
                    Name = course.Field<string>( "Name" )
                } );
            }
        }
    }

    [DataContract]
    public class Course
    {
        [DataMember]
        public int CourseId { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}