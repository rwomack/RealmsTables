
namespace RealmsTables;

public partial class PositionSkillRec : RealmObject
{
	[PrimaryKey]
	public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

	[Required]
	public int HandlingBase { get; set; }
	[Required]
	public int HandlingRnd { get; set; }
	[Required]
	public int TacklingBase { get; set; }
	[Required]
	public int TacklingRnd { get; set; }
	[Required]
	public int PassingBase { get; set; }
	[Required]
	public int PassingRnd { get; set; }
	[Required]
	public int ShootingBase { get; set; }
	[Required]
	public int ShootingRnd { get; set; }
	[Required]
	public int HeadingBase { get; set; }
	[Required]
	public int HeadingRnd { get; set; }
	[Required]
	public int StrengthBase { get; set; }
	[Required]
	public int StrengthRnd { get; set; }
	[Required]
	public int PaceBase { get; set; }
	[Required]
	public int PaceRnd { get; set; }
	[Required]
	public int FlairBase { get; set; }
	[Required]
	public int FlairRnd { get; set; }
}