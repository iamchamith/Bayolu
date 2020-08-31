using Bayolu.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Bayolu.Domain.Enums;

namespace Bayolu.Domain
{
    [Table(nameof(User), Schema = "Bayolu")]
    public class User : BaseEntity<Guid>
    {
        [Required, StringLength(50)]
        public virtual string FullName { get; private set; }
        [Required, StringLength(50)]
        public virtual string Email { get; private set; }
        [Required, StringLength(500)]
        public virtual string Password { get; private set; }
        public virtual Role Role { get; private set; }
        public virtual Team Team { get; private set; }
        public virtual decimal StorageCapacity { get; private set; }
        [Required, StringLength(50)]
        public virtual string OriginalFolder { get; private set; }
        [Required, StringLength(1500)]
        public virtual string Comment { get; private set; }
        public virtual Guid? UserReviews { get; private set; }

        [ForeignKey(nameof(UserReviews))]
        public virtual User UserReviewsBy { get; set; }

        public User()
        {
        }
        public User(Guid id, string name, string email, Role role, Team team, decimal capacity, string folder,
            string comment,Guid reviewBy) : this()
        {
            Id = id;
            FullName = name;
            Email = email;
            Role = role;
            Team = team;
            StorageCapacity = capacity;
            OriginalFolder = folder;
            Comment = comment;
            UserReviews = reviewBy;
        }

        public User SetPassword(string password)
        {
            Password = Cryptography.EncryptString(password);
            return this;
        }
    }
}
