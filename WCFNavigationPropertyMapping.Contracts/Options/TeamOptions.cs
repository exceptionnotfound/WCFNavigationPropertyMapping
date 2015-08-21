using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WCFNavigationPropertyMapping.Contracts.Attributes;

namespace WCFNavigationPropertyMapping.Contracts.Options
{
    [DataContract]
    public class TeamOptions : OptionsBase
    {
        [DataMember]
        [NavigationProperty("Players")]
        public bool IncludePlayers { get; set; }

        [DataMember]
        [NavigationProperty("League")]
        public bool IncludeLeague { get; set; }
    }
}
