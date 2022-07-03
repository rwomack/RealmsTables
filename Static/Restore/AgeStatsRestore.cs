namespace SQLiteTables;


public partial class AgeStatsRec
{
	/// <summary>
	///
	/// </summary>
	/// <returns></returns>
	internal CAgeStatsItem Create() => new ()
	{
		CharacteristicsAgeGroup = CharacteristicsGroup,
		RejuvenateEnergy = RejuvenateEnergy,
		WagePercentage = WagePercentage,
		TransferFeeAdjustment = TransferFeeAdjustment
	};
}


public class AgeStatsRestore
{

	/// <summary>
	///
	/// </summary>
	/// <param name="_playerStatsManager"></param>
	/// <param name="connection"></param>
	internal static void CreateAll(CPlayerStatsManager _playerStatsManager, SQLiteConnection connection)
	{
		foreach (var ageStatsRec in connection.Table<AgeStatsRec>())
		{
			_playerStatsManager.AgeStatList.ItemList.Add(ageStatsRec.Create());
		}
	}
}