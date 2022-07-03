
namespace RealmsTables;

public partial class SkillMoneyValueRec : RealmObject
{
	[PrimaryKey]
	public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

	[Required]
	public int PlayerValue { get; set; }
	[Required]
	public int RandomPlayerValue;
	[Required]
	public int PlayerWage { get; set; }
	[Required]
	public int RandomPlayerWage { get; set; }
	[Required]
	public int EmployeeWage { get; set; }
	[Required]
	public int RandomEmployeeWage { get; set; }
}