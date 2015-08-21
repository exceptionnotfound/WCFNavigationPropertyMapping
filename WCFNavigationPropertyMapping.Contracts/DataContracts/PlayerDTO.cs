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
        public int Id { get; set; }

        [DataMember]
        public int TeamId { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public DateTime DateOfBirth { get; set; }

        [DataMember]
        public TeamDTO Team { get; set; }
    }
}
