
namespace RealmsTables;

public class PopularityDivisionStrengthRec : RealmObject
{
	[PrimaryKey]
	public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

	[Required]
	public int DivisionStrengthId { get; set; }
	[Required]
	public int NumStarPlayers { get; set; }
	[Required]
	public int BaseRating { get; set; }
	[Required]
	public int BaseStarRating { get; set; }
}
