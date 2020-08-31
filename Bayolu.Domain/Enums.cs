using System.ComponentModel;

namespace Bayolu.Domain
{
    public class Enums
    {
        public enum Role
        {
            [Description(nameof(Admin))]
            Admin = 1,
            [Description(nameof(Cacher))]
            Cacher,
            [Description(nameof(Accounter))]
            Accounter
        }

        public enum Team
        {
            [Description(nameof(Development))]
            Development = 1,
            [Description(nameof(Accounting))]
            Accounting,
            [Description(nameof(Hr))]
            Hr
        }
    }
}
