
namespace RealmsTables;

public partial class InjuryTypeRec : RealmObject
{
	[PrimaryKey]
	public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

	[Required]
	public string Title { get; set; }
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
	public int BaseMatchPerformanceEffect { get; set; }
	[Required]
	public int RandomMatchPerformanceEffect { get; set; }
	[Required]
	public int Description { get; set; }
	[Required]
	public bool CarryOff { get; set; }
}