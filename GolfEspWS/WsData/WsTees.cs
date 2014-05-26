using System.Collections.Generic;
using System.Data;
using System.Runtime.Serialization;

namespace GolfEspWS.WsData
{
    [DataContract]
    public class WsTees
    {
        [DataMember]
        public List<Tee> Tees { get; set; }

        public WsTees()
        {
            var courses = Common.GetAllTableData( "Tees" );

            Tees = new List<Tee>();
            foreach ( var course in courses.AsEnumerable() )
            {
                Tees.Add( new Tee
                {
                    TeeId = course.Field<int>( "TeeId" ),
                    CourseId = course.Field<int>( "CourseId" ),
                    TeeName = course.Field<string>( "TeeName" )
                } );
            }
        }
    }

    [DataContract]
    public class Tee
    {
        [DataMember]
        public int TeeId { get; set; }

        [DataMember]
        public int CourseId { get; set; }

        [DataMember]
        public string TeeName { get; set; }
    }
}