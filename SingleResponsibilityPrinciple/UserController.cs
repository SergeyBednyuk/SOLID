using System;

public class UserController
{
	private HttpClient _client;
	public UserController()
	{
		_client = new HttpClient();
	}

	public	async Task<string> SendHttpResuestAsync(string url, HttpMethod method, string content)
	{
		await Task.Delay(500);

		return "Http request sent successfully";
	}
}
