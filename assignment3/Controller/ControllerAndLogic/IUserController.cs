namespace Controller
{
    public interface IUserController
    {
        UserLoginDTO validateUserLogin(string userName, string password);
    }
}
