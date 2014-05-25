using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace GolfEspWS.WsData
{
    [DataContract]
    public class WsTees
    {
        [DataMember]
        public List<Tee> Tees { get; set; }

        public WsTees()
        {
            var database = new AccessDatabase( ConfigurationManager.AppSettings["PROVIDER"],
                ConfigurationManager.AppSettings["DSN"] );
            database.LoadAllTableData( "Tees" );
            var courses = database.DbDataSet.Tables["Tees"];

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