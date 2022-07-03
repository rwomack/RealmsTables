
namespace RealmsTables;

public class PopularityFinanceRec : RealmObject
{
	[PrimaryKey]
	public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

	[Required]
	public int BasicManagerWeeklyWage { get; set; }
	[Required]
	public int RandomManagerWeeklyWage { get; set; }
	[Required]
	public int MinimumClubBalance { get; set; }
	[Required]
	public int BasicInitialClubBalance { get; set; }
	[Required]
	public int RandomInitialClubBalance { get; set; }
	[Required]
	public int BasicGeneralWeeklyWage { get; set; }
	[Required]
	public int RandomGeneralWeeklyWage { get; set; }
	[Required]
	public int BasicExpenses { get; set; }
	[Required]
	public int BasicWeeklyRunningCosts { get; set; }
	[Required]
	public int RandomWeeklyRunningCosts { get; set; }
	[Required]
	public int BasicWeeklyTvRevenue { get; set; }
	[Required]
	public int RandomWeeklyTvRevenue { get; set; }
	[Required]
	public int BasicWeeklySponsorship { get; set; }
	[Required]
	public int RandomWeeklySponsorship { get; set; }
	[Required]
	public int WeeklyClubMerchandise { get; set; }
}
