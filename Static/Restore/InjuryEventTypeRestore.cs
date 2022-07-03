namespace SQLiteTables;

public partial class InjuryEventTypeRec
{
	internal CInjuryEventType Create() => new ()
	{
		Severity = (eSeverity)Type,
		BasePeriod = BasePeriod,
		RandomPeriod = MaximumRandom,
		Plural = Plural,
		ReoccurrenceChance = ReoccurrenceChance,
		WeeksToSurgery = WeeksToSurgery,
		MatchPerformanceEffect = MatchPerformanceEffect,
		RndMatchPerformanceEffect = RndMatchPerformanceEffect,
		CarryOff = CarryOff
	};

}

public class InjuryEventTypeRestore
{
	/// <summary>
	///
	/// </summary>
	/// <returns></returns>


	/// <summary>
	///
	/// </summary>
	/// <param name="_playerStatsManager"></param>
	/// <param name="connection"></param>
	internal static void CreateAll(CPlayerStatsManager _playerStatsManager, SQLiteConnection connection)
	{
		foreach (var injuryEventTypeRec in connection.Table<InjuryEventTypeRec>())
		{
			_playerStatsManager.Add(injuryEventTypeRec.Create());
		}
	}
}