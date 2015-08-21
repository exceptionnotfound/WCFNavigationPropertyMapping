namespace WCFNavigationPropertyMapping.Lib.EntityFrameworkModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Player")]
    public partial class Player
    {
        public int Id { get; set; }

        public int TeamId { get; set; }

        [Required]
        [StringLength(200)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(200)]
        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public virtual Team Team { get; set; }
    }
}
