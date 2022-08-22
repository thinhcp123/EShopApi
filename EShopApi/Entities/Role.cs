using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace EShopApi.Entities
{
    [Table("Role")]
    public class Role : IdentityRole<int>
    {

    }
}
