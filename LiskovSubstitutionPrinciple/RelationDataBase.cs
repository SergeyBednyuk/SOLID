using System;

public class RelationDataBase : DataBase
{
	public RelationDataBase()
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

    public virtual void JoinTabled(string tableAName, string tableBName) { }
}
