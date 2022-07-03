namespace SQLiteTables;

public partial class PositionFinancialRec
{

	/// <summary>
	///
	/// </summary>
	/// <returns></returns>
	internal CPositionFinancial Create() => new ()
	{
		WagePercentage = WagePercentage,
		FeePercentage = FeePercentage
	};
}


public class PositionFinancialRestore
{


	/// <summary>
	///
	/// </summary>
	/// <param name="_playerStatsManager"></param>
	/// <param name="connection"></param>
	public static void CreateAll(CPlayerStatsManager _playerStatsManager, SQLiteConnection connection)
	{
		foreach (var positionFinancialRec in connection.Table<PositionFinancialRec>())
		{
			_playerStatsManager.Add(positionFinancialRec.Create());
		}
	}
}