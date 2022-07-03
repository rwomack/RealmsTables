

namespace SQLiteDataBuilder;

public class RealmsServiceBase
{
	internal Realm realm { get; set; }
    protected string dbName { get; set; }


	/*-----------------------------------------------------------------------------------------------------
		Method:		SQLiteDataBuilder.RealmService.Start
		Access:		internal
		Returns:	void
		Purpose:
	------------------------------------------------------------------------------------------------------*/
	internal void Start() => OpenRealm(dbName);
	

	/*-----------------------------------------------------------------------------------------------------
		Method:		SQLiteDataBuilder.RealmService.OpenRealm
		Access:		internal
		Parameter:	string databaseName
		Returns:	void
		Purpose:
	------------------------------------------------------------------------------------------------------*/
	private bool OpenRealm(string databaseName)
	{
		try
		{
			realm = Realm.GetInstance();
		}
		catch (Exception ex)
		{
			if (ex is not null && string.IsNullOrEmpty(ex.Message) == false)
			{
			}
			return false;
		}
		return true;
	}


	/*-----------------------------------------------------------------------------------------------------
		Method:		SQLiteDataBuilder.RealmService.CloseConnection
		Access:		internal
		Returns:	void
		Purpose:
	------------------------------------------------------------------------------------------------------*/
	internal void CloseConnection()
	{
/*		if (dbConnection is not null)
		{
			dbConnection.Close();
			dbConnection = null;
		}*/
	}


	/*-----------------------------------------------------------------------------------------------------
		Method:		SQLiteDataBuilder.SQLiteService.BeginTransaction
		Access:		internal
		Returns:	void
		Purpose:
	------------------------------------------------------------------------------------------------------*/
	//internal void BeginTransaction() => dbConnection.BeginTransaction();


	/*-----------------------------------------------------------------------------------------------------
		Method:		SQLiteDataBuilder.SQLiteService.EndTransaction
		Access:		internal
		Returns:	void
		Purpose:
	------------------------------------------------------------------------------------------------------*/
	internal void EndTransaction()
	{
//		dbConnection.Commit();

		// Clear caches etc
	//	CloseConnection();
	}
}