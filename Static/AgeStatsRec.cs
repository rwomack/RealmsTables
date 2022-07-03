global using Realms;
global using MongoDB.Bson;

namespace RealmsTables;

public partial class AgeStatsRealmRec : RealmObject
{
	[PrimaryKey]
	public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

	[Required]
	public int Age { get; set; }
    [Required]
    public int CharacteristicsGroup { get; set; }
    [Required]
    public int RejuvenateEnergy { get; set; }
    [Required]
    public int TransferFeeAdjustment { get; set; }
    [Required]
    public int WagePercentage { get; set; }
}