
namespace RealmsTables;


public class CountryRec : RealmObject
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
    public string NationalityEnglish { get; set; }
	[Required]
    public string NationalityFrench { get; set; }
	[Required]
    public string NationalityItalian { get; set; }
	[Required]
    public string NationalityGerman { get; set; }
	[Required]
    public string NationalitySpanish { get; set; }
	[Required]
    public int Federation { get; set; }
	[Required]
    public int Rating { get; set; }
	[Required]
    public int WageRatio { get; set; }
 	[Required]
   public int Currency { get; set; }
	[Required]
    public int ChanceBuyDifferentFederation { get; set; }
	[Required]
    public int ChanceSellDifferentFederation { get; set; }
	[Required]
    public int FederationRanking { get; set; }
}