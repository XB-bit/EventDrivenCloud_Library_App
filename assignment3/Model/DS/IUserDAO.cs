namespace Model
{
    public  interface IUserDAO
    {
        User getUserByUserNameAndPassword(string userName, string password);
    }
}
