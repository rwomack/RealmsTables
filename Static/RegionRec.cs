
namespace RealmsTables;

public partial class RegionRec : RealmObject
{
	[PrimaryKey]
	public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

	[Required]
	public int RegionClose1 { get; set; }
	[Required]
	public int RegionClose2 { get; set; }
	[Required]
	public int RegionClose3 { get; set; }
}