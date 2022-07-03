namespace SQLiteTables;

public partial class RegionRec
{

	/// <summary>
	///
	/// </summary>
	/// <returns></returns>
	internal CRegion Create() => new ()
	{
		ID = Id,
		CloseRegion =
		{
			[0] = RegionClose1,
			[1] = RegionClose2,
			[2] = RegionClose3
		}
	};
}


public class RegionRestore
{

	/// <summary>
	///
	/// </summary>
	/// <param name="_regionList"></param>
	public static void CreateAll(CRegionList _regionList, SQLiteConnection connection)
	{
		foreach (var regionRec in connection.Table<RegionRec>())
		{
			_regionList.Add(regionRec.Create());
		}
	}
}