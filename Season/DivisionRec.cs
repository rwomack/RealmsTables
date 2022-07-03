
namespace RealmsTables;


public class DivisionRec : RealmObject
{
	[PrimaryKey]
	public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

	[Required]
	public int FirstClubId { get; set; }
	[Required]
	public int NumberClubs { get; set; }
	[Required]
	public int TrophyGFX { get; set; }
	[Required]
	public int SubsSelect { get; set; }
	[Required]
	public int SubsUse { get; set; }
	[Required]
	public int TransferDeadlineSystemID { get; set; }
	[Required]
	public int TicketPrice { get; set; }
	[Required]
	public int AwayGatePercentage { get; set; }
	[Required]
	public int FAGatePercentage { get; set; }
	[Required]
	public int PointsForWin { get; set; }
	[Required]
	public int DivisionStrength  { get; set; }
	[Required]
	public int NumberPromoted { get; set; }
	[Required]
	public int NumberRelegated { get; set; }
	[Required]
	public int CountryID { get; set; }
	[Required]
	public int ChanceBuySameFed { get; set; }
	[Required]
	public int ChanceSellSameFed { get; set; }
	[Required]
	public int ShieldName { get; set; }
	[Required]
	public int TopPlayoffID { get; set; }
	[Required]
	public int NumClubsTopPlayoff { get; set; }
	[Required]
	public int BottomPlayoffID { get; set; }
	[Required]
	public int NumClubsBottomPlayoff { get; set; }
	[Required]
	public int PlayoffForTitle { get; set; }
	[Required]
	public int PrizeMoney { get; set; }
	[Required]
	public int MinimumGroundCapacity { get; set; }
}