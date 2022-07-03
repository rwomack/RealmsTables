

namespace SQLiteDataBuilder;

/*public class DataServiceTbl
{
    internal RealmConnection dbConnection { get; set; }
}*/

public class RealmsService : RealmsServiceBase
{
//    public static SQLiteService instance { get; set; } = new ();


    /*-----------------------------------------------------------------------------------------------------
	    Method:		SQLiteDataBuilder.SQLiteService.Start
	    Access:		internal
	    Returns:	void
	    Purpose:
    ------------------------------------------------------------------------------------------------------*/
    internal new void Start()
    {
	    dbName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\FDStaticData.Realm";
	    base.Start();

	    CreateDB();
    }


    /*-----------------------------------------------------------------------------------------------------
    	Method:		SQLiteDataBuilder.SQLiteService.CreateDB
    	Access:		private
    	Returns:	void
    	Purpose:
    ------------------------------------------------------------------------------------------------------*/
    private void CreateDB()
    {
/*        dbConnection.CreateTable<AgeStatsRec>();
        dbConnection.CreateTable<AggressionRec>();
        dbConnection.CreateTable<CountryRec>();
        dbConnection.CreateTable<DivisionStrengthRec>();
        dbConnection.CreateTable<FormationRec>();
        dbConnection.CreateTable<InjuryTypeRec>();
        dbConnection.CreateTable<InjuryEventTypeRec>();
        dbConnection.CreateTable<KitRec>();
        dbConnection.CreateTable<OverallSkillRec>();

        dbConnection.CreateTable<PopularityRec>();
        dbConnection.CreateTable<PopularityFinanceRec>();
        dbConnection.CreateTable<PopularityPlayerRec>();
        dbConnection.CreateTable<PopularityDivisionStrengthRec>();
        dbConnection.CreateTable<PositionFinancialRec>();
        dbConnection.CreateTable<PositionSkillRec>();

        dbConnection.CreateTable<RegionRec>();
        dbConnection.CreateTable<SkillMoneyValueRec>();
        dbConnection.CreateTable<TransferWindowRec>();
        dbConnection.CreateTable<TransferWindowSystemRec>();*/
    }

}
