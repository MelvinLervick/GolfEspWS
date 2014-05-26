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
                    ClubNumber = course.Field<string>( "ClubNumber" ),
                    Name = course.Field<string>( "Name" ),
                    ShortCourseName = course.Field<string>("ShortCourseName"),
                    CourseName = course.Field<string>("CourseName"),
                    NumberOfTees = course.Field<byte>("NumberOfTees"),
                    DefaultHandicapType = course.Field<byte>("DefaultHandicapType"),
                    MaxPlayers = course.Field<byte>("MaxPlayers"),
                    NumberOfPoints = course.Field<byte>("NumberOfPoints"),
                    Address1 = course.Field<string>("Address1"),
                    Address2 = course.Field<string>("Address2"),
                    City = course.Field<string>("City"),
                    State = course.Field<string>("State"),
                    PostalCode = course.Field<string>("PostalCode"),
                    Country = course.Field<string>("Country"),
                    Primary = course.Field<byte>("Primary")
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
        public string ClubNumber { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string ShortCourseName { get; set; }

        [DataMember]
        public string CourseName { get; set; }

        [DataMember]
        public byte NumberOfTees { get; set; }

        [DataMember]
        public byte DefaultHandicapType { get; set; }

        [DataMember]
        public byte MaxPlayers { get; set; }

        [DataMember]
        public byte NumberOfPoints { get; set; }

        [DataMember]
        public string Address1 { get; set; }

        [DataMember]
        public string Address2 { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string State { get; set; }

        [DataMember]
        public string PostalCode { get; set; }

        [DataMember]
        public string Country { get; set; }

        [DataMember]
        public byte Primary { get; set; }
    }
}