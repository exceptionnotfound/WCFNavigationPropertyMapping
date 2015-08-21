using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCFNavigationPropertyMapping.Contracts.DataContracts
{
    [DataContract]
    public class PlayerDTO : Player
    {
        [DataMember]
        public Team Team { get; set; }
    }
}
