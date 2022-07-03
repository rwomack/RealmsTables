
namespace RealmsTables;

public partial class KitRec : RealmObject
{
	[PrimaryKey]
	public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

	[Required]
	public int PrimaryColour { get; set; }
	[Required]
	public int SecondaryColour { get; set; }
	[Required]
	public int Style { get; set; }
}