using Bayolu.SharedKernel;
using System;
using static Bayolu.Domain.Enums;

namespace Bayolu.AppService.Dto
{
    public class UserDto : BaseDto<Guid>
    {

        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public Team Team { get; set; }
        public decimal StorageCapacity { get; set; }
        public string OriginalFolder { get; set; }
        public string Comment { get; set; }
        public Guid UserReviews { get; set; }
    }
}
