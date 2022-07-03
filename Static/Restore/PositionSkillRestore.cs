namespace SQLiteTables;

public partial class PositionSkillRec
{

	/// <summary>
	///
	/// </summary>
	/// <returns></returns>
	internal CPositionSkill Create() => new ()
	{
		m_Handling = new CRangedInt
		{
			BasicValue = HandlingBase,
			RandomValue = HandlingRnd
		},
		m_Tackling = new CRangedInt
		{
			BasicValue = TacklingBase,
			RandomValue = TacklingRnd
		},
		m_Passing = new CRangedInt
		{
			BasicValue = PassingBase,
			RandomValue = PassingRnd
		},
		m_Shooting = new CRangedInt
		{
			BasicValue = ShootingBase,
			RandomValue = ShootingRnd
		},
		m_Heading = new CRangedInt
		{
			BasicValue = HeadingBase,
			RandomValue = HeadingRnd
		},
		m_Strength = new CRangedInt
		{
			BasicValue = StrengthBase,
			RandomValue = StrengthRnd
		},
		m_Pace = new CRangedInt
		{
			BasicValue = PaceBase,
			RandomValue = PaceRnd
		},
		m_Flair = new CRangedInt
		{
			BasicValue = FlairBase,
			RandomValue = FlairRnd
		}
	};
}


public class PositionSkillRestore
{


	/// <summary>
	///
	/// </summary>
	/// <param name="_playerStatsManager"></param>
	/// <param name="connection"></param>
	internal static void CreateAll(CPlayerStatsManager _playerStatsManager, SQLiteConnection connection)
	{
		foreach (var positionSkillRec in connection.Table<PositionSkillRec>())
		{
			_playerStatsManager.Add(positionSkillRec.Create());
		}
	}
}