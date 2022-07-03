
namespace RealmsTables;

public class CharityShieldRec : RealmObject
{
	[PrimaryKey]
	public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

	[Required]
	public string Name { get; set; }
		[Required]
public int Capacity { get; set; }
}

