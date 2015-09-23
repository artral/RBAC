namespace RBAC
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Role
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Role_Id { get; set; }

        [StringLength(50)]
        public string RoleName { get; set; }

        public bool? IsSysAdmin { get; set; }
    }
}
