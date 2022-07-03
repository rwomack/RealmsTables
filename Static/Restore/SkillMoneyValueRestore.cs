namespace SQLiteTables;

public partial class SkillMoneyValueRec
{

	/// <summary>
	///
	/// </summary>
	/// <returns></returns>
	internal CSkillMoneyValue Create() => new ()
	{
		PlayerValue = new CRangedInt
		{
			BasicValue = PlayerValue,
			RandomValue = RandomPlayerValue
		},
		PlayerWage = new CRangedInt
		{
			BasicValue = PlayerWage,
			RandomValue = RandomPlayerWage
		},
		EmployeeWage = new CRangedInt
		{
			BasicValue = EmployeeWage,
			RandomValue = RandomEmployeeWage
		}
	};
}


public class SkillMoneyValueRestore
{


	/// <summary>
	///
	/// </summary>
	/// <param name="_playerStatsManager"></param>
	/// <param name="connection"></param>
	public static void CreateAll(CPlayerStatsManager _playerStatsManager, SQLiteConnection connection)
	{
		foreach (var skillMoneyValueRec in connection.Table<SkillMoneyValueRec>())
		{
			_playerStatsManager.Add(skillMoneyValueRec.Create());
		}

	}
}