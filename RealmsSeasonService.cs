
namespace SQLiteDataBuilder;

public class SQLiteSeasonService
{
	    public static SQLiteSeasonService instance { get; set; } = new ();

        private SQLiteConnection DbConnection { get; set; }
        private string DbName { get; } =   "../../../Data/FDData20.db";


        public void AddAssociation(AssociationRec associationRec) => DbConnection.Insert(associationRec);


        /*-----------------------------------------------------------------------------------------------------
        	Method:		SQLiteDataBuilder.SQLiteSeasonService.CreateDB
        	Access:		private
        	Returns:	void
        	Purpose:
        ------------------------------------------------------------------------------------------------------*/
        private void CreateDB()
        {
	        DbConnection.CreateTable<AssociationRec>();
	        DbConnection.CreateTable<CupRec>();
	        DbConnection.CreateTable<CupScheduleRec>();
	        DbConnection.CreateTable<DivisionRec>();
	        DbConnection.CreateTable<FederationRec>();

	        DbConnection.CreateTable<ManagerRec>();

            DbConnection.CreateTable<StadiumRec>();
        }


        /*-----------------------------------------------------------------------------------------------------
        	Method:		SQLiteDataBuilder.SQLiteSeasonService.Persist
        	Access:		internal
        	Returns:	void
        	Purpose:
        ------------------------------------------------------------------------------------------------------*/
        internal void Persist()
        {
            try
            {
                OpenConnection();
                BeginTransaction();




                EndTransaction();

            }
            catch (Exception ex)
            {
                if (ex is not null && string.IsNullOrEmpty(ex.Message) == false)
                {
                    Debug.Fail("SQLiteSeasonService.Persist() failed. " + ex.Message);
                }

                throw ex;
            }
        }


        /*-----------------------------------------------------------------------------------------------------
        	Method:		SQLiteDataBuilder.SQLiteSeasonService.Start
        	Access:		internal
        	Returns:	void
        	Purpose:
        ------------------------------------------------------------------------------------------------------*/
        internal void Start()
        {
            if (OpenSQLite(DbName) == false)
            {
                Debug.Fail("SQLiteSeasonService Creating DB ");
                CreateDB();
            }
            CreateDB();
        }


        /*-----------------------------------------------------------------------------------------------------
        	Method:		SQLiteDataBuilder.SQLiteSeasonService.OpenConnection
        	Access:		internal
        	Returns:	void
        	Purpose:
        ------------------------------------------------------------------------------------------------------*/
        internal void OpenConnection()
        {
            if (OpenSQLite(DbName) == false)
            {
                Debug.Fail("SQLiteSeasonService OpenConnection Failed for fileName: ");
            }
        }


        /*-----------------------------------------------------------------------------------------------------
        	Method:		SQLiteDataBuilder.SQLiteSeasonService.OpenSQLite
        	Access:		internal
        	Parameter:	string databaseName
        	Returns:	void
        	Purpose:
        ------------------------------------------------------------------------------------------------------*/
        private bool OpenSQLite(string databaseName)
        {
            try
            {
                DbConnection = new SQLiteConnection(databaseName, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create, false);
            }
            catch (Exception ex)
            {
                if (ex is not null && string.IsNullOrEmpty(ex.Message) == false)
                {
                }
            }
            return true;
        }


        /*-----------------------------------------------------------------------------------------------------
        	Method:		SQLiteDataBuilder.SQLiteSeasonService.CloseConnection
        	Access:		internal
        	Returns:	void
        	Purpose:
        ------------------------------------------------------------------------------------------------------*/
        internal void CloseConnection()
        {
            if (DbConnection is not null)
            {
                DbConnection.Close();
                DbConnection = null;
            }
        }


        /*-----------------------------------------------------------------------------------------------------
        	Method:		SQLiteDataBuilder.SQLiteSeasonService.BeginTransaction
        	Access:		internal
        	Returns:	void
        	Purpose:
        ------------------------------------------------------------------------------------------------------*/
        internal void BeginTransaction() => DbConnection.BeginTransaction();


        /*-----------------------------------------------------------------------------------------------------
        	Method:		SQLiteDataBuilder.SQLiteSeasonService.EndTransaction
        	Access:		internal
        	Returns:	void
        	Purpose:
        ------------------------------------------------------------------------------------------------------*/
        internal void EndTransaction()
        {
            DbConnection.Commit();

            // Clear caches etc
            CloseConnection();
        }
}