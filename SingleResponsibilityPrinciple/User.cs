using System;

public class User	
{
	private HttpClient _client;

	private int _id;

	public string UserName {  get; set; }

	public string Password { get; set; }

	public User(string userName, string password)
	{
		_client = new HttpClient();

		var q = new Random();
		_id = q.Next();
		UserName = userName;
		Password = password;
	}


    #region BadPractice
    public string Log()
	{
		return ($"Log {UserName} User");
	}

	public async Task<string?> SendHttpRequestAsync(string url, HttpMethod method, string content)
	{
		try
		{
			var request = new HttpRequestMessage(method, url);

			if (string.IsNullOrEmpty(content))
			{
				request.Content = new StringContent(content, System.Text.Encoding.UTF8, "application/json");
			}

			var response = await _client.SendAsync(request);

			if (response.IsSuccessStatusCode) 
			{
				return await response.Content.ReadAsStringAsync();
			}
			else
			{
				Console.WriteLine($"HTTP resuest faild with status code: {response.StatusCode}");
				return null;
			}
		}
		catch (HttpRequestException ex)
		{
			Console.WriteLine(ex.Message);
			return null;
		}
	}

	public	void SomeMethodSaveData()
	{
		//SomeCode
	}

    #endregion
}
