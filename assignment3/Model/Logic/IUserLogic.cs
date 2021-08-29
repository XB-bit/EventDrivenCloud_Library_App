namespace Model
{
    public interface IUserLogic
    {
        User validateUserLogin(string userName, string password);
    }
}
