
namespace RealmsTables;

public class ClubRec : RealmObject
{
	[PrimaryKey]
	public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

	[Required]
	public string Name { get; set; }

	[Required]
	public string CodeName { get; set; }
	[Required]
	public ushort StadiumId { get; set; }
	[Required]
	public byte PopularityId { get; set; }
	[Required]
	public byte RegionId { get; set; }
	[Required]
	public byte DivisionId { get; set; }
	[Required]
	public short YearFounded { get; set; }
	[Required]
	public short ManagerId { get; set; }
	[Required]
	public byte HomeKitId { get; set; }
	[Required]
	public int StartingCash { get; set; }
}
