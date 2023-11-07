using System;

public class DataBase
{
	public DataBase()
	{
	}

	public virtual void Connect() { }

	public virtual void Disconnect() { }

	//Bad practice
	//public virtual void JoinTabled(string tableAName, string tableBName) { }
}
