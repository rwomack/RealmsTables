
namespace RealmsTables;

public class AssociationRec : RealmObject
{
	[PrimaryKey]
	public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

	[Required]
    public int DivisionsInCountry { get; set; }
	[Required]
    public int StadiumId { get; set; }
	[Required]
    public int FedCupBerth1 { get; set; }
	[Required]
    public int NumClubsFedCup1 { get; set; }
	[Required]
    public int FedCupBerth2 { get; set; }
	[Required]
    public int NumClubsFedCup2 { get; set; }
}