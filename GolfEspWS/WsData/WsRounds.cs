using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Serialization;

namespace GolfEspWS.WsData
{
    [DataContract]
    public class WsRounds
    {
        [DataMember]
        public List<Round> Rounds { get; set; }

        public WsRounds()
        {
            var rounds = Common.GetAllTableData("Rounds");

            Rounds = new List<Round>();
            foreach (var round in rounds.AsEnumerable())
            {
                Rounds.Add( new Round( round ) );
            }
        }
    }

    [DataContract]
    public class Round
    {
        public Round( DataRow row )
        {
            RoundId = row.Field<int>( "RoundId" );
            CourseId = row.Field<int>( "CourseId" );
            RoundDate = row.Field<DateTime>( "RoundDate" );
            RoundTime = row.Field<string>( "RoundTime" );
            MilitaryTime = row.Field<string>( "MilitaryTime" );
            StartHole = row.Field<byte>( "StartHole" );
            HHUnit = row.Field<string>( "HHUnit" );
            CourseStart = row.Field<string>( "CourseStart" );
        }

        [DataMember]
        public int RoundId { get; set; }

        [DataMember]
        public int CourseId { get; set; }
        [DataMember]
        public DateTime RoundDate { get; set; }

        [DataMember]
        public string RoundTime { get; set; }

        [DataMember]
        public string MilitaryTime { get; set; }
        [DataMember]
        public byte StartHole { get; set; }

        [DataMember]
        public string HHUnit { get; set; }

        [DataMember]
        public string CourseStart { get; set; }
    }
}