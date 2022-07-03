namespace SQLiteTables;

public partial class KitRec
{

	/// <summary>
	///
	/// </summary>
	/// <returns></returns>
	internal CKit Create() => new ()
	{
		Id = Id,
		PrimaryColour = PrimaryColour,
		SecondaryColour = SecondaryColour,
		Style = Style,
	};
}


public class KitRestore
{

	/// <summary>
	///
	/// </summary>
	/// <param name="_kitList"></param>
	/// <param name="connection"></param>
	public static void CreateAll(CKitSystem _kitList, SQLiteConnection connection)
	{
		foreach (var kitRec in connection.Table<KitRec>())
		{
			_kitList.List.Add(kitRec.Create());
		}
	}
}