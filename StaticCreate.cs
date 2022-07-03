namespace SQLiteTables;

public class StaticCreate : SQLiteService
{

	public void AddAgeStats(AgeStatsRec ageStatsRec) => dbConnection.Insert(ageStatsRec);
	public void AddAggression(AggressionRec aggressionRec) => dbConnection.Insert(aggressionRec);
	public void AddCountry(CountryRec countryRec) => dbConnection.Insert(countryRec);
	public void AddDivisionStrength(DivisionStrengthRec divisionStrengthRec) => dbConnection.Insert(divisionStrengthRec);
	public void AddFormation(FormationRec formationRec) => dbConnection.Insert(formationRec);
	public void AddInjuryType(InjuryTypeRec injuryTypeRec) => dbConnection.Insert(injuryTypeRec);
	public void AddInjuryEventType(InjuryEventTypeRec injuryEventTypeRec) => dbConnection.Insert(injuryEventTypeRec);
	public void AddKit(KitRec kitRec) => dbConnection.Insert(kitRec);
	public void AddOverallSkill(OverallSkillRec overallSkillRec) => dbConnection.Insert(overallSkillRec);
	public void AddPopularity(PopularityRec popularityRec) => dbConnection.Insert(popularityRec);
	public void AddPopularityFinance(PopularityFinanceRec popularityFinanceRec) => dbConnection.Insert(popularityFinanceRec);
	public void AddPopularityPlayer(PopularityPlayerRec popularityPlayerRec) => dbConnection.Insert(popularityPlayerRec);
	public void AddPopularityDivisionStrength(PopularityDivisionStrengthRec popularityDivisionStrengthRec) => dbConnection.Insert(popularityDivisionStrengthRec);
	public void AddPositionFinancial(PositionFinancialRec positionFinancialRec) => dbConnection.Insert(positionFinancialRec);
	public void AddPositionSkill(PositionSkillRec positionSkillRec) => dbConnection.Insert(positionSkillRec);
	public void AddRegion(RegionRec regionRec) => dbConnection.Insert(regionRec);
	public void AddSkillMoneyValue(SkillMoneyValueRec skillMoneyValueRec) => dbConnection.Insert(skillMoneyValueRec);
	public void AddTransferWindowSystem(TransferWindowSystemRec transferWindowSystemRec) => dbConnection.Insert(transferWindowSystemRec);
	public void AddTransferWindow(TransferWindowRec transferWindowRec) => dbConnection.Insert(transferWindowRec);
}