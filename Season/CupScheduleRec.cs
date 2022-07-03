
namespace RealmsTables;


public class CupScheduleRec : RealmObject
{
	[PrimaryKey]
	public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

	[Required]
	public int RoundType { get; set; }
	[Required]
	public int DrawTitle { get; set; }
	//public int RoundOrder { get; set; }
	[Required]
	public int NumberInRound { get; set; }
	[Required]
	public int QualifyMoney { get; set; }
	[Required]
	public int WinMoney { get; set; }
	[Required]
	public int DrawMoney { get; set; }
	//public int ExcludeFedQual { get; set; }
	//public int FirstToAdd { get; set; }
	//public int NumberToAdd { get; set; }
	//public int MatchType { get; set; }
	//public int VenueId { get; set; }
	[Required]
	public int DrawDate { get; set; }
	[Required]
	public int MatchDate { get; set; }
	[Required]
	public int ReplayDate { get; set; }
	[Required]
	public int NumberInGroups { get; set; }
	//public int NumberOfGroupMatches { get; set; }
	//public int RoundStatus { get; set; }
	//public int LoserQualifiesFor { get; set; }
	[Required]
	public int RoundTitle { get; set; }
	[Required]
	public int ReplayType { get; set; }
}