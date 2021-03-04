using Core.Entities;

namespace Entities.DTOs
{
    public class UserDetailDto :IDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
    }
}