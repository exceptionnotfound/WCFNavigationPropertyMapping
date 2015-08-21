namespace WCFNavigationPropertyMapping.Lib.EntityFrameworkModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("League")]
    public partial class League
    {
        public League()
        {
            Teams = new HashSet<Team>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public DateTime FoundingDate { get; set; }

        public virtual ICollection<Team> Teams { get; set; }
    }
}
