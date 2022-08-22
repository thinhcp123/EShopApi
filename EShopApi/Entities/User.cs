using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace EShopApi.Entities
{
    [Table("User")]

    public class User : IdentityUser<int>
    {
        public UserAddress Address { get; set; }
    }
}
