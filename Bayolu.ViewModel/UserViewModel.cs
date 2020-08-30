using System;
using System.ComponentModel.DataAnnotations;

namespace Bayolu.ViewModel
{
    [Serializable]
    public class UserViewModel
    {
        public Guid Id { get; set; }    
        [Required, StringLength(50)]
        public string FullName { get; set; }
        [Required, StringLength(50)]
        public string Email { get; set; }
        [Required, StringLength(500)]
        public string Password { get; set; }
        public int Role { get; set; }
        public int Team { get; set; }
        public decimal StorageCapacity { get; set; }
        [Required, StringLength(50)]
        public string OriginalFolder { get; set; }
        [Required, StringLength(1500)]
        public string Comment { get; set; }
    }
}
