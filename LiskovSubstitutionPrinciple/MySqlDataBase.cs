using System;

public class MySqlDataBase : RelationDataBase /* DataBase*/
{
	public MySqlDataBase()
	{
	}

    public override void Connect()
    {
        base.Connect();
    }

    public override void Disconnect()
    {
        base.Disconnect();
    }

    public override void JoinTabled(string tableAName, string tableBName)
    {
        base.JoinTabled(tableAName, tableBName);
    }
}
