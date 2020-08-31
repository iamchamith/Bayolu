using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bayolu.ViewModel
{
    [Serializable]
    public class UserViewModel
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Name required."), StringLength(50)]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Email required."), EmailAddress(ErrorMessage = "Invalid Email."), StringLength(50)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password required."), StringLength(500)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Password required."), StringLength(500), Compare(nameof(Password), ErrorMessage = "Must have same password.")]
        public string ConfirmPassword { get; set; }
        public int Role { get; set; }
        public int Team { get; set; }
        public decimal StorageCapacity { get; set; }
        [Required(ErrorMessage = "Folder required."), StringLength(50)]
        public string OriginalFolder { get; set; }
        [Required(ErrorMessage = "Comment required."), StringLength(1500)]
        public string Comment { get; set; }
        public Guid UserReviews { get; set; }
        public UserViewModel()
        {
            Id = Guid.NewGuid();
            Role = 1;
            Team = 1;
            StorageCapacity = 1;
        }
    }
}
