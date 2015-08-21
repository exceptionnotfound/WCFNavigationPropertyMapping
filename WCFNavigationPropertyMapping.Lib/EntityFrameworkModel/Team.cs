namespace WCFNavigationPropertyMapping.Lib.EntityFrameworkModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Team")]
    public partial class Team
    {
        public Team()
        {
            Players = new HashSet<Player>();
        }

        public int Id { get; set; }

        public int LeagueID { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public DateTime FoundingDate { get; set; }

        public virtual League League { get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }
}
