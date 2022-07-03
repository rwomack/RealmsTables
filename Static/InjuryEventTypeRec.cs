
namespace RealmsTables;

public partial class InjuryEventTypeRec : RealmObject
{
	[PrimaryKey]
	public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

	[Required]
	public int MaximumRandom { get; set; }
	[Required]
	public int Type { get; set; }
	[Required]
	public int BasePeriod { get; set; }
	[Required]
	public int RandomPeriod { get; set; }
	[Required]
	public bool Plural { get; set; }
	[Required]
	public int ReoccurrenceChance { get; set; }
	[Required]
	public int WeeksToSurgery { get; set; }
	[Required]
	public int MatchPerformanceEffect { get; set; }
	[Required]
	public int RndMatchPerformanceEffect { get; set; }
	[Required]
	public int Description { get; set; }
	[Required]
	public int PluralDescription { get; set; }
	[Required]
	public bool CarryOff { get; set; }
	[Required]
	public int GenerateNewspaperHeadlines { get; set; }
	[Required]
	public int PhysioActive { get; set; }
}