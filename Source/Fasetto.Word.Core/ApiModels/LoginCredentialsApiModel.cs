namespace Fasetto.Word.Core
{
    /// <summary>
    /// The credentials for  an API client to log into the server and receive a token back
    /// </summary>
    public class LoginCredentialsApiModel
    {
        public string UsernameOrEmail { get; set; }

        public string Password { get; set; }
    }
}
