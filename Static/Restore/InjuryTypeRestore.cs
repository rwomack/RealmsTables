namespace SQLiteTables;

public partial class InjuryTypeRec
{
	/// <summary>
	///
	/// </summary>
	/// <returns></returns>
	internal CInjuryType Create() => new()
	{
		Description = Title,
		MaximumRandom = MaximumRandom,
		Severity = (eSeverity)Type,
		BasePeriod = BasePeriod,
		RandomPeriod = RandomPeriod,
		Plural = Plural,
		MatchPerformanceEffect = BaseMatchPerformanceEffect,
		RndMatchPerformanceEffect = RandomMatchPerformanceEffect,
		CarryOff = CarryOff
	};
}

public class InjuryTypeRestore
{


	/// <summary>
	///
	/// </summary>
	/// <param name="_playerStatsManager"></param>
	/// <param name="connection"></param>
	internal static void CreateAll(CPlayerStatsManager _playerStatsManager, SQLiteConnection connection)
	{
		foreach (var injuryTypeRec in connection.Table<InjuryTypeRec>())
		{
			_playerStatsManager.Add(injuryTypeRec.Create());
		}
	}
}