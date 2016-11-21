using SaveLinks.DataLayer.Entities.Core;

namespace SaveLinks.DataLayer.Entities
{
    public class Person : Entity
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}