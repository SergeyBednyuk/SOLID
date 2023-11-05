using System;

public class UserRepository
{
	public UserRepository()
	{
	}


	public void Save(User user)
	{
		Console.WriteLine($"User {user.UserName} was saved to DB");
	}
}
