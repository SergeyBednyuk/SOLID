using System;

public class UserLogger
{
	public UserLogger()
	{
	}

	public string UserLog(User user)
	{
		return $"Log {user.UserName} user in UserLogger class ";
	}
}
