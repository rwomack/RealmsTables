
namespace RealmsTables;


public class CupRec : RealmObject
{
	[PrimaryKey]
	public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

	[Required]
	public string NameEnglish { get; set; }
	[Required]
	public string NameFrench { get; set; }
	[Required]
	public string NameItalian { get; set; }
	[Required]
	public string NameGerman { get; set; }
	[Required]
	public string NameSpanish { get; set; }
	[Required]
	public int CupType { get; set; }
	[Required]
	public int FederationId { get; set; }
	[Required]
	public int CountryId { get; set; }
	[Required]
	public int AwayGatePercentage { get; set; }
	[Required]
	public int AssociationGatePercentage { get; set; }
	[Required]
	public int TransferDeadlineSystemId { get; set; }
	[Required]
	public int NumberFromGroupsInNextRound { get; set; }
	[Required]
	public int NumberfromGroupsInNextCup { get; set; }
	[Required]
	public int ShieldId { get; set; }
///	FEDCUP1QUAL { get; set; }
	//RUNNERUPQUALIFIESFOR { get; set; }
	[Required]
	public int SPECIALCASEID { get; set; }
	[Required]
	public int BYEROUND { get; set; }
	[Required]
	public int WINNERS { get; set; }
	[Required]
	public int RUNNERSUP { get; set; }
	[Required]
	public int SUBSSELECT { get; set; }
	[Required]
	public int SUBSUSE { get; set; }
	[Required]
	public int StadiumId { get; set; }
	[Required]
	public int TROPHYGFX { get; set; }
/*	PERCENTAGEPOINTSFORPLAYOFFS { get; set; }
	NUMBERPROMOTED { get; set; }
	ADDTOLEAGUETABLES { get; set; }
	ISLEAGUESPLITTOP { get; set; }
	ISLEAGUESPLITBOTTOM { get; set; }*/
}