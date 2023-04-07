using Microsoft.AspNet.Identity.EntityFramework;

using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Entidades
{
    public class AppicationUser : IdentityUser
    {
        [Column("USR_CPF")]
        public string CPF { get; set; }
    }
}
