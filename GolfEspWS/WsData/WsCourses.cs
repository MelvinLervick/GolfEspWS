using System.Collections.Generic;
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
            var courses = Common.GetAllTableData("Courses");

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