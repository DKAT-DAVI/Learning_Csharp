using System;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace user_authentication
{
    [Table("tbl_credential")]
    internal class Credential
    {
        [Key]
        public Int64 CredentialId { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [StringLength(250)]
        public String Email { get; set; }

        //-- Password encrypted

        /// String to salt password.
        public const String SALT = "RtgrMcbelsHerj";

        private String _password;

        [Required]
        [StringLength(64)]
        public String Password
        {
            get 
            { 
                return _password; 
            }
            set
            {
                ///Password encryption
                _password = ComputeSHA256(value, SALT);
            }
        }

        //--

        /// Is administrador user?
        public Boolean Administrator { get; set; }

        /// Atribut for relation with tbl_user [ FOREIGN KEY ]
        [Required]
        public User User { get; set; }

        /// Constructors()
        public Credential()
        {
        }

        public Credential(string email, string senha, bool administrator, User user)
        {
            Email = email;
            Password = senha;
            Administrator = administrator;
            User = user;
        }

        #region Hashing SHA256

        public static String ComputeSHA256(String input)
        {
            return ComputeSHA256(input, SALT);
        }

        public static String ComputeSHA256(String input, String salt)
        {
            string hash = String.Empty;

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashValue = sha256.ComputeHash(Encoding.UTF8.GetBytes( salt + input));

                foreach (byte b in hashValue)
                {
                    hash += $"{b:X2}";
                }
            }

            return hash;
        }


        #endregion

        /// Method to authenticate user login
        public static Boolean AuthenticateUser(String email, String password)
        {
            User user = UserRepository.FindUserByEmail(email);

            /// If email exists in database...
            if (user != null)
            {
                /// ... autheticate the password.
                String passwordInDatabase = user.Credential.Password;
                password = ComputeSHA256(password, SALT);

                if (passwordInDatabase == ComputeSHA256(password, SALT))
                {
                    return true;
                }
                else
                {   
                    /// Return a error Message to the user
                    MessageBox.Show("The password you entered is wrong, please try again", "PASSWORD WRONG", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            else {
                /// Return a error Message to the user
                MessageBox.Show("The email you entered is wrong, please try again", "EMAIL WRONG", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        public override String ToString()
        {
            return CredentialId
                + ", " + Email
                + ", " + Password
                + ", " + (Administrator? "Administrador" : "Usuário comum")
                + ", Usuário: " + User?.Id;
        }
    }
}
