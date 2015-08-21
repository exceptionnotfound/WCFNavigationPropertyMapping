using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCFNavigationPropertyMapping.Contracts.DataContracts
{
    [DataContract]
    public class TeamDTO : Team
    {
        [DataMember]
        public League League { get; set; }

        [DataMember]
        public List<Player> Players { get; set; }
    }
}
