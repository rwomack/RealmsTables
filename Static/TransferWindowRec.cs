
namespace RealmsTables;

public class TransferWindowRec : RealmObject
{
	[PrimaryKey]
	public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

	[Required]
	public string Description { get; set; }
	[Required]
	public int Type { get; set; }
	[Required]
	public int OpenWeekId { get; set; }
	[Required]
	public int CloseWeekId { get; set; }
}