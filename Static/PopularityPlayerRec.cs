
namespace RealmsTables;

public class PopularityPlayerRec : RealmObject
{
	[PrimaryKey]
	public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

	[Required]
	public int MaximumSkill { get; set; }
	[Required]
	public int GoodSkill { get; set; }
	[Required]
	public int SackSkill { get; set; }
	[Required]
	public int GoodPlayer { get; set; }
	[Required]
	public int PlayerPurchaseThreshold { get; set; }
	[Required]
	public int PlayerMaximumPurchaseValue { get; set; }
	[Required]
	public int PlayerRandomSkill { get; set; }
	[Required]
	public int StarPlayerRandomSkill { get; set; }
	[Required]
	public int OldPlayerSkillAdjustment { get; set; }
}
