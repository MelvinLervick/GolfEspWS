using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Serialization;

namespace GolfEspWS.WsData
{
    [DataContract]
    public class WsPDADataIn
    {
        [DataMember]
        public List<PdaData> PDADataIn { get; set; }

        public WsPDADataIn()
        {
            const string tableName = "PDADataIn";

            var pdaDataIn = Common.GetAllTableData(tableName);

            PDADataIn = new List<PdaData>();
            foreach (var pdaData in pdaDataIn.AsEnumerable())
            {
                PDADataIn.Add(new PdaData
                {
                    PdaDataInId = pdaData.Field<int>("PDADataInID"),
                    CourseId = pdaData.Field<int>("CourseId"),
                    InDate = pdaData.Field<DateTime>("InDate"),
                    InTime = pdaData.Field<string>("InTime"),
                    StartHole = pdaData.Field<byte>("StartHole"),
                    HHUnit = pdaData.Field<string>("HHUnit"),
                    InTimeMilitary = pdaData.Field<string>("InTimeMilitary"),
                    RoundId = pdaData.Field<int>("RoundId"),
                    DisplayListName = pdaData.Field<string>("DisplayListName")
                });
            }
        }
    }

    [DataContract]
    public class PdaData
    {
        [DataMember]
        public int PdaDataInId { get; set; }

        [DataMember]
        public int CourseId { get; set; }

        [DataMember]
        public DateTime InDate { get; set; }

        [DataMember]
        public string InTime { get; set; }

        [DataMember]
        public byte StartHole { get; set; }

        [DataMember]
        public string HHUnit { get; set; }

        [DataMember]
        public string InTimeMilitary { get; set; }

        [DataMember]
        public int RoundId { get; set; }

        [DataMember]
        public string DisplayListName { get; set; }
    }
}