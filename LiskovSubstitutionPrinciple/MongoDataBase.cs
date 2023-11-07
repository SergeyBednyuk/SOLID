using System;

public class MongoDataBase : NonRelationDataBase /*DataBase*/
{
	public MongoDataBase()
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

    public override void CreateIndex()
    {
        base.CreateIndex();
    }

    //public override void JoinTabled(string tableAName, string tableBName)
    //{
    //    Console.WriteLine("Mongo DB doesn't use tables error");
    //}
}
