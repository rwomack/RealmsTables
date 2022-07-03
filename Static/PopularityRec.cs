
namespace RealmsTables;

public class PopularityRec : RealmObject
{
	[PrimaryKey]
	public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

	[Required]
	public int BasicAttendance { get; set; }
	[Required]
	public int MaxAttendance { get; set; }
	[Required]
	public int GoodMatchDayChance { get; set; }
	[Required]
	public int BadMatchDayChance { get; set; }
	[Required]
	public int AnnualMaximumLoanAmount { get; set; }
	[Required]
	public int BasicExpenses { get; set; }
	[Required]
	public int BasicWeeklyRunningCosts { get; set; }
	[Required]
	public int RndWeeklyRunningCosts { get; set; }
	[Required]
	public int MaxSkill { get; set; }
	[Required]
	public int GoodSkill { get; set; }
	[Required]
	public int GoodPlayer { get; set; }
	[Required]
	public int SackSkill { get; set; }
	[Required]
	public int PlayerPurchaseThreshold { get; set; }
	[Required]
	public int MaximumPlayerPurchaseValue { get; set; }
	[Required]
	public int BasicManagerWeeklyWage { get; set; }
	[Required]
	public int RndManagerWeeklyWage { get; set; }
	[Required]
	public int BasicInitialClubBalance { get; set; }
	[Required]
	public int RndInitialClubBalance { get; set; }
	[Required]
	public int BasicGeneralWeeklyWage { get; set; }
	[Required]
	public int RndGeneralWeeklyWage { get; set; }
	[Required]
	public int BasicEmployeeSkill { get; set; }
	[Required]
	public int RndEmployeeSkill { get; set; }
	[Required]
	public int MinimumClubBalance { get; set; }
	[Required]
	public int BasicWeeklySponsorship { get; set; }
	[Required]
	public int RndWeeklySponsorship { get; set; }
	[Required]
	public int WeeklyClubMerchandise { get; set; }
	[Required]
	public int BasicWeeklyTvRevenue { get; set; }
	[Required]
	public int RndWeeklyTvRevenue { get; set; }
	[Required]
	public int PlayerRndSkill { get; set; }
	[Required]
	public int OldPlayerAdjustment { get; set; }
	[Required]
	public int StarPlayerRndSkill { get; set; }
	[Required]
	public int MinimumManagerRatingToManageClub { get; set; }
}
