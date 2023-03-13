using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data.Entity;

namespace user_authentication
{
    internal class Repository : DbContext
    {
        // Singleton for Database Connection
        private static MySqlConnection _dbConnection;

        public DbSet<User> Users { get; set; }

        // Constructor()
        public Repository() : base(GetDBConnection(), false)
        {
            /// If the database not exists, create it.
            if (Database.CreateIfNotExists())
            {
                Repository repository = this;

                /// Add a Root user
                User userRoot = new User("Admin");
                Credential credentialRoot = new Credential("admin@email.com", "admin", true, userRoot);
                userRoot.Credential = credentialRoot;

                User dkat = new User("dkat");
                Credential credentialDkat = new Credential("dkat@email.com", "dkat", true, dkat);
                dkat.Credential = credentialDkat;

                /// Add usage Users
                User u1 = new User("Ana Zaira");
                Credential c3 = new Credential("ana@mail.com", "123456", false, u1);
                u1.Credential = c3;

                User u2 = new User("Cristiana Xolmes");
                Credential c4 = new Credential("cristiana@mail.com", "123456", false, u2);
                u2.Credential = c4;

                /// Save changes in database
                repository.Users.Add(userRoot);
                repository.Users.Add(dkat);
                repository.Users.Add(u1);
                repository.Users.Add(u2);
                repository.SaveChanges();

                //UserRepository.Save(u1);
                //UserRepository.Save(u2);
            }
        }

        // Singleton for Database Connection
        public static MySqlConnection GetDBConnection()
        {
            if (_dbConnection == null)
            {
                String connectionString = ConfigurationManager.ConnectionStrings["UserAuthentication"].ConnectionString;
                _dbConnection = new MySqlConnection(connectionString);
            }

            return _dbConnection;
        }

    }
}
