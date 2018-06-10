namespace Domain.Entities
{
    using Microsoft.AspNet.Identity.EntityFramework;

    public class Role : IdentityRole<string, UserRole>
    {
        public string Description { get; set; }
        public int TypeId { get; set; }

    }
}
