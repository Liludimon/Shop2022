namespace Shop2022
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public int UserID { get; set; }

        [Required]
        [StringLength(100)]
        public string UserSurname { get; set; }

        [Required]
        [StringLength(100)]
        public string UserName { get; set; }

        [Required]
        [StringLength(100)]
        public string UserPatronymic { get; set; }

        [Required]
        public string UserLogin { get; set; }

        [Required]
        public string UserPassword { get; set; }

        public int UserRole { get; set; }

        public virtual Role Role { get; set; }
    }
}
