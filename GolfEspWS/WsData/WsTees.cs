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
            var tees = Common.GetAllTableData( "Tees" );

            Tees = new List<Tee>();
            foreach ( var tee in tees.AsEnumerable() )
            {
                Tees.Add( new Tee
                {
                    TeeId = tee.Field<int>( "TeeId" ),
                    CourseId = tee.Field<int>( "CourseId" ),
                    TeeOrder = tee.Field<byte>("TeeOrder"),
                    TeeName = tee.Field<string>("TeeName"),
                    ShortName = tee.Field<string>("ShortName"),
                    Mens = tee.Field<bool>("Mens"),
                    MCourseRating = tee.Field<double>("MCourseRating"),
                    MSlope = tee.Field<short>("MSlope"),
                    MPrint = tee.Field<bool>("MPrint"),
                    FCourseRating = tee.Field<double>("FCourseRating"),
                    FSlope = tee.Field<short>("FSlope"),
                    FPrint = tee.Field<bool>("FPrint"),
                    PinLocation = tee.Field<string>("PinLocation")
                });
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
        public byte TeeOrder { get; set; }

        [DataMember]
        public string TeeName { get; set; }

        [DataMember]
        public string ShortName { get; set; }

        [DataMember]
        public bool Mens { get; set; }

        [DataMember]
        public double MCourseRating { get; set; }

        [DataMember]
        public short MSlope { get; set; }

        [DataMember]
        public bool MPrint { get; set; }

        [DataMember]
        public double FCourseRating { get; set; }

        [DataMember]
        public short FSlope { get; set; }

        [DataMember]
        public bool FPrint { get; set; }

        [DataMember]
        public string PinLocation { get; set; }
    }
}