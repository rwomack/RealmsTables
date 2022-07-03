
namespace RealmsTables;

public class TransferWindowSystemRec : RealmObject
{
	[PrimaryKey]
	public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

	[Required]
	public string Name { get; set; }
	[Required]
	public int Window1Id { get; set; }
	[Required]
	public int Window2Id { get; set; }
	[Required]
	public int Window3Id { get; set; }
	[Required]
	public int Window4Id { get; set; }
}