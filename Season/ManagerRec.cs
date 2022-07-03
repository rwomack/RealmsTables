
namespace RealmsTables;


public class ManagerRec : RealmObject
{
	[PrimaryKey]
	public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

	[Required]
	public string Forename { get; set; }
	[Required]
	public string Surname { get; set; }
	[Required]
	public int DateOfBirth { get; set; } // JulianDate
	[Required]
	public short NationalityID { get; set; }
}