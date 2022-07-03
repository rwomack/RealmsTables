
namespace RealmsTables;

public class FormationRec : RealmObject
{
	[PrimaryKey]
	public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

	[Required]
	public string Name { get; set; }
	[Required]
	public int PosX01 { get; set; }
	[Required]
	public int PosY01 { get; set; }
	[Required]
	public int PosX02 { get; set; }
	[Required]
	public int PosY02 { get; set; }
	[Required]
	public int PosX03 { get; set; }
	[Required]
	public int PosY03 { get; set; }
	[Required]
	public int PosX04 { get; set; }
	[Required]
	public int PosY04 { get; set; }
	[Required]
	public int PosX05 { get; set; }
	[Required]
	public int PosY05 { get; set; }
	[Required]
	public int PosX06 { get; set; }
	[Required]
	public int PosY06 { get; set; }
	[Required]
	public int PosX07 { get; set; }
	[Required]
	public int PosY07 { get; set; }
	[Required]
	public int PosX08 { get; set; }
	[Required]
	public int PosY08 { get; set; }
	[Required]
	public int PosX09 { get; set; }
	[Required]
	public int PosY09 { get; set; }
	[Required]
	public int PosX10 { get; set; }
	[Required]
	public int PosY10 { get; set; }
}

