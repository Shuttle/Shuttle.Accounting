using System;
using Shuttle.Accounting.Events.AccountType.v1;
using Shuttle.Core.Contract;

namespace Shuttle.Accounting
{
    public class AccountType
    {
        public Guid Id { get; }

        public AccountType(Guid id)
        {
            Id = id;
        }

        public Registered Register(string name)
        {
            Guard.AgainstNullOrEmptyString(name, nameof(name));

            return On(new Registered
            {
                Name = name
            });
        }

        private Registered On(Registered registered)
        {
            return registered;
        }
    }
}