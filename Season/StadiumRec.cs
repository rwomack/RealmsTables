
namespace RealmsTables;


public class StadiumRec : RealmObject
{
	[PrimaryKey]
	public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

	[Required]
	public string Name { get; set; }
	[Required]
    public int Capacity { get; set; }
	[Required]
    public int RegionId { get; set; }
}