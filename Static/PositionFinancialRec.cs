
namespace RealmsTables;

public partial class PositionFinancialRec : RealmObject
{
	[PrimaryKey]
	public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

	[Required]
	public int WagePercentage { get; set; }
	[Required]
	public int FeePercentage { get; set; }
}