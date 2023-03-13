using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace user_authentication
{
    [Table("tbl_user")]
    internal class User
    {
        public Int64 Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public Credential Credential { get; set; }

        /// Contructors()
        public User()
        {
        }

        public User(string name)
        {
            Name = name;   
        }

        public override string ToString()
        {
            return Id
                + ", " + Name
                + ", Credential: " + Credential;
        }

    }
}
