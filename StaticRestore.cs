namespace SQLiteTables;

public class StaticRestore : SQLiteService
{

	/// <summary>
	///
	/// </summary>
	/// <param name="world"></param>
	public void Restore(CWorld world)
	{
		Debug.Assert(world != null);

		RestoreKits(world.KitSystem);
		RestoreDivisionStrengths(world.DivisionStrengthList);
		RestorePlayerStats(world.PlayerStatsManager);
		RestoreRegions(world.RegionList);
	}



	/// <summary>
	///
	/// </summary>
	/// <param name="_kitSystem"></param>
	public void RestoreKits(CKitSystem _kitSystem)
	{
		foreach (var kitRec in DbConnection.Table<KitRec>())
		{
			_kitSystem.List.Add(new CKit()
			{
				Id = kitRec.Id,
				PrimaryColour = kitRec.PrimaryColour,
				SecondaryColour = kitRec.SecondaryColour,
				Style = kitRec.Style
			});
		}
	}


	/// <summary>
	///
	/// </summary>
	/// <param name="_divisionStrengthList"></param>
	public void RestoreDivisionStrengths(CDivisionStrengthList _divisionStrengthList)
	{
		foreach (var divisionStrengthRec in DbConnection.Table<DivisionStrengthRec>())
		{
			CDivisionStrength divisionStrength = new CDivisionStrength
			{
				ManagerMatchPoints = new CManagerMatchPoints
				{
					PointsWin = divisionStrengthRec.ManagerPointsForWin,
					PointsDraw = divisionStrengthRec.ManagerPointsForDraw,
					PointsManagerOfMonth = divisionStrengthRec.ManagerPointsForManagerOfMonth,
					PointsGoodWinAway = divisionStrengthRec.ManagerPointsForGoodWinAway,
					PointsGoodWinHome = divisionStrengthRec.ManagerPointsForGoodWinHome,
					PointsTopWin = divisionStrengthRec.ManagerPointsForTopWin
				},
				SeasonSponsorship = new CSeasonSponsorship
				{
					ShirtSponsorshipAmount = divisionStrengthRec.SeasonShirtSponsorshipAmount,
					KitSponsorshipAmount = divisionStrengthRec.SeasonKitSponsorshipAmount
				},
				SeasonTvIncome = divisionStrengthRec.SeasonTVIncome,
				FinancialPercentage = divisionStrengthRec.FinancialPercentage,
				YouthInitialSkillDecrease = divisionStrengthRec.YouthInitialSkillDecrease,
				MinimumContractValueToAutoSack = divisionStrengthRec.MinContractValueToAutoSack
			};
			_divisionStrengthList.Add(divisionStrength);
		}
	}


	/// <summary>
	///
	/// </summary>
	/// <param name="_playerStatsManager"></param>
	public void RestorePlayerStats(CPlayerStatsManager _playerStatsManager)
	{
		foreach (var ageStatsRec in dbConnection.Table<AgeStatsRec>())
		{
			_playerStatsManager.AgeStatList.ItemList.Add(new CAgeStatsItem
			{
				CharacteristicsAgeGroup = ageStatsRec.CharacteristicsGroup,
				RejuvenateEnergy = ageStatsRec.RejuvenateEnergy,
				WagePercentage = ageStatsRec.WagePercentage,
				TransferFeeAdjustment = ageStatsRec.TransferFeeAdjustment
			});
		}
		foreach (var skillMoneyValueRec in dbConnection.Table<SkillMoneyValueRec>())
		{
			_playerStatsManager.Add(new CSkillMoneyValue
			{
				PlayerValue = new CRangedInt
				{
					BasicValue = skillMoneyValueRec.PlayerValue,
					RandomValue = skillMoneyValueRec.RandomPlayerValue
				},
				PlayerWage = new CRangedInt
				{
					BasicValue = skillMoneyValueRec.PlayerWage,
					RandomValue = skillMoneyValueRec.RandomPlayerWage
				},
				EmployeeWage = new CRangedInt
				{
					BasicValue = skillMoneyValueRec.EmployeeWage,
					RandomValue = skillMoneyValueRec.RandomEmployeeWage
				}
			});
		}
		foreach (var positionFinancialRec in dbConnection.Table<PositionFinancialRec>())
		{
			_playerStatsManager.Add(new CPositionFinancial()
			{
				WagePercentage = positionFinancialRec.WagePercentage,
				FeePercentage = positionFinancialRec.FeePercentage
			});
		}
		foreach (var positionSkillRec in dbConnection.Table<PositionSkillRec>())
		{
			_playerStatsManager.Add(new CPositionSkill()
			{
				m_Handling = new CRangedInt
				{
					BasicValue = positionSkillRec.HandlingBase,
					RandomValue = positionSkillRec.HandlingRnd
				},
				m_Tackling = new CRangedInt
				{
					BasicValue = positionSkillRec.TacklingBase,
					RandomValue = positionSkillRec.TacklingRnd
				},
				m_Passing = new CRangedInt
				{
					BasicValue = positionSkillRec.PassingBase,
					RandomValue = positionSkillRec.PassingRnd
				},
				m_Shooting = new CRangedInt
				{
					BasicValue = positionSkillRec.ShootingBase,
					RandomValue = positionSkillRec.ShootingRnd
				},
				m_Heading = new CRangedInt
				{
					BasicValue = positionSkillRec.HeadingBase,
					RandomValue = positionSkillRec.HeadingRnd
				},
				m_Strength = new CRangedInt
				{
					BasicValue = positionSkillRec.StrengthBase,
					RandomValue = positionSkillRec.StrengthRnd
				},
				m_Pace = new CRangedInt
				{
					BasicValue = positionSkillRec.PaceBase,
					RandomValue = positionSkillRec.PaceRnd
				},
				m_Flair = new CRangedInt
				{
					BasicValue = positionSkillRec.FlairBase,
					RandomValue = positionSkillRec.FlairRnd
				},
			});
		}
		foreach (var injuryTypeRec in dbConnection.Table<InjuryTypeRec>())
		{
			_playerStatsManager.Add(new CInjuryType()
			{

			});
		}
		foreach (var injuryEventTypeRec in dbConnection.Table<InjuryEventTypeRec>())
		{
			_playerStatsManager.Add(new CInjuryEventType()
			{

			});
		}
	}


	public void RestoreRegions(CRegionList _regionList)
	{
		foreach (var regionRec in dbConnection.Table<RegionRec>())
		{
			_regionList.Add(new CRegion()
			{

			});
		}
	}
	
}