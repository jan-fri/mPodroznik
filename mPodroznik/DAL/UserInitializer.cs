using mPodroznik.Models.User;
using System.Collections.Generic;
using System.Data.Entity;

namespace mPodroznik.DAL
{
    public class UserInitializer : DropCreateDatabaseIfModelChanges<UserContext>
    {
        protected override void Seed(UserContext context)
        {
            //base.Seed(context);
            var users = new List<User>
            {
                new User {UserName="jk", FirstName="Jan", LastName="Kowalski", Email="jk@g.com", Password="aaaaaaaaa"},
                new User {UserName="mn", FirstName="Marian", LastName="Nowak", Email="mn@vv.com", Password="bbbbbbbbbb"},
                new User {UserName="lp", FirstName="Lucjan", LastName="Pawlik", Email="llp@ww.com", Password="ccccccccc"},
                new User {UserName="mr", FirstName="Michal", LastName="Ruski", Email="mr@ee.com", Password="ddddddddd"},
                new User {UserName="kw", FirstName="Kuba", LastName="Wolski", Email="kw@aa.com", Password="eeeeeeee"}

            };

            users.ForEach(x => context.Users.Add(x));
            context.SaveChanges();
        }
    }
}