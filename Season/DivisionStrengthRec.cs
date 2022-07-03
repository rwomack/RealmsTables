
namespace RealmsTables;

public class DivisionStrengthRec : RealmObject
{
	[PrimaryKey]
	public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

	[Required]
	public int ManagerPointsForWin { get; set; }
	[Required]
	public int ManagerPointsForDraw { get; set; }
	[Required]
	public int ManagerPointsForManagerOfMonth { get; set; }
	[Required]
	public int ManagerPointsForGoodWinAway { get; set; }
	[Required]
	public int ManagerPointsForGoodWinHome { get; set; }
	[Required]
	public int ManagerPointsForTopWin { get; set; }
	[Required]
	public int SeasonShirtSponsorshipAmount { get; set; }
	[Required]
	public int SeasonTVIncome { get; set; }
	[Required]
	public int SeasonKitSponsorshipAmount { get; set; }
	[Required]
	public int FinancialPercentage { get; set; }
	[Required]
	public int YouthInitialSkillDecrease { get; set; }
	[Required]
	public int MinContractValueToAutoSack { get; set; }
}
