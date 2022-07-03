
namespace RealmsTables;

public class OverallSkillRec : RealmObject
{
	[PrimaryKey]
	public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

	[Required]
	public int Handling { get; set; }
	[Required]
	public int Tackling { get; set; }
	[Required]
	public int Passing { get; set; }
	[Required]
	public int Shooting { get; set; }
	[Required]
	public int Heading { get; set; }
	[Required]
	public int Pace { get; set; }
	[Required]
	public int Strength { get; set; }
	[Required]
	public int Flair { get; set; }
}