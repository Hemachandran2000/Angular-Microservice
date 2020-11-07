using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ShoppingCartEntity
{ 
    public class UserModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserRole { get; set; } 
    }
}
