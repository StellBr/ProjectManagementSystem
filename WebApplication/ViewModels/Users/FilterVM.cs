using Common.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace WebApplication.ViewModels.Users
{
    public class FilterVM
    {
        public string Username { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        public string Address  { get; set; }

        public Expression<Func<User,bool>> GetFilter()
        {
            return i =>
                        (string.IsNullOrEmpty(Username)  || i.Username.Contains(Username)) &&
                        (string.IsNullOrEmpty(FirstName) || i.FirstName.Contains(FirstName)) &&
                        (string.IsNullOrEmpty(LastName) || i.LastName.Contains(LastName)) &&
                        (string.IsNullOrEmpty(Address)   || i.Address.Contains(Address));
        }
    }
}
