using System;

public class UserService
{
	public UserService()	{	}

    public void GetUser(int id)
    {
        Console.WriteLine($"Get user with id - {id}");
    }

    public void GetAllUsers()
    {
        Console.WriteLine("Get all user from DB");
    }

    public void Post(User user)
    {
        Console.WriteLine($"{user.UserName} user was saved");
    }
}
