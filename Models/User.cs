namespace BolascoInfass.Models
{
    public class User
    {
        public string _sql(string username, string email, string password, string confPassword)
        {
           return "From Model: " + username + " " + email + " " + password + " " + confPassword;
        }
    }
}
