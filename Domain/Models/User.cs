using System.Collections;
using System.Collections.Generic;

namespace Domain.Models
{
    public enum UserType : byte
    {
        Admin = 1,
        Customer = 2
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserType Type { get; set; }
        public IEnumerable<Profile> Profiles { get { return _profiles; } }

        private IList<Profile> _profiles;

        public User()
        {

        }

        public User(string name, string email, string password, UserType type)
        {
            Name = name;
            Email = email;
            Password = password;
            Type = type;
            _profiles = new List<Profile>();
        }

        public void AddProfile(Profile profile)
        {
            _profiles.Add(profile);
        }

        public override string ToString()
        {
            return $"{Email} - {Name}";
        }
    }
}
