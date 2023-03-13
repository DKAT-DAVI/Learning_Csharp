using System;
using System.Linq;
using System.Data.Entity;

namespace user_authentication
{
    internal class UserRepository
    {
        /// Save user in database
        public static void SaveUser(User user)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (user.Id == 0)
                    {
                        dbContext.Users.Add(user);
                    }
                    else
                    {
                        dbContext.Entry(user).State = EntityState.Modified;
                    }

                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// Select an user
        public static User FindUserByEmail(String email)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Users
                        .Include("Credential")
                        .Where(u => u.Credential.Email == email)
                        .FirstOrDefault<User>();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// Remove user
        public static void RemoveUser(User user)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Users.Attach(user);
                    dbContext.Users.Remove(user);

                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
