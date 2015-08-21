using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCFNavigationPropertyMapping.Contracts.DataContracts
{
    [DataContract]
    public class LeagueDTO : League
    {
        [DataMember]
        public List<Team> Teams { get; set; }
    }
}
