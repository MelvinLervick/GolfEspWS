using System.Collections.Generic;
using System.Data;
using System.Runtime.Serialization;

namespace GolfEspWS.WsData
{
    [DataContract]
    public class WsUnprintedRounds
    {
        [DataMember]
        public List<Round> UnprintedRounds { get; set; }

        public WsUnprintedRounds()
        {
            var unprintedRounds = Common.GetAllTableData("Rounds");

            UnprintedRounds = new List<Round>();
            foreach (var round in unprintedRounds.AsEnumerable())
            {
                UnprintedRounds.Add( new Round( round ) );
            }
        }
    }
}