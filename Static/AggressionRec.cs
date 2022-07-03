
namespace RealmsTables;


public class AggressionRec : RealmObject
{
	[PrimaryKey]
	public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

	[Required]
	public int MinimumYellowCards { get; set; }
	[Required]
	public int MaximumYellowCards { get; set; }
	[Required]
	public int MinimumRedCards { get; set; }
	[Required]
	public int MaximumRedCards { get; set; }
	[Required]
	public int MinimumInjuries { get; set; }
	[Required]
	public int MaximumInjuries { get; set; }
	[Required]
	public int SkillCompensator { get; set; }
	[Required]
	public int MinimumEnergyUsed { get; set; }
	[Required]
	public int RandomEnergyUsed { get; set; }
}
