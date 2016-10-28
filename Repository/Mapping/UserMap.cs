using Dapper.FluentMap.Dommel.Mapping;
using Domain.Models;

namespace Repository.Mapping
{
    public class UserMap : DommelEntityMap<User>
    {
        public UserMap()
        {
            ToTable("Users");
            //Map(p => p.Id).IsKey();
            Map(p => p.Name).ToColumn("Name");
            Map(p => p.Email).ToColumn("Email");
            Map(p => p.Password).ToColumn("Password");
            Map(p => p.Type).ToColumn("Type");
        }
    }
}
