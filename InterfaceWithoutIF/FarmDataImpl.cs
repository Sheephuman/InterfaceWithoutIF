using InterfaceWithoutIF;

namespace SuperDataClassTest
{
    public class FarmDataImpl:IDataContainer
    {
        public string farmName { get; set; } 
        public int SheepCount { get; set; }
        public string OwnerName { get; set; } 
        public string OwnerPersonality { get; set; }
        public FarmDataImpl? FarmData { get; set; }
        public bool HasFarmData { get; set; }


        public FarmDataImpl(string _farmName, int sheepCount, string ownerName,
            string ownerPersonality, bool _hasFarmData)
        { 
            farmName = _farmName;

            SheepCount = sheepCount;
            OwnerName = ownerName;
            OwnerPersonality = ownerPersonality;
            HasFarmData = _hasFarmData;

        }

        public string GetData()
        {
            var emptyData = new EmptyDataContainer();

            string returndata = HasFarmData? $"【牧場データ】\n" +
                                 $"牧場名: {farmName}\n" +
                                 $"飼育頭数: {SheepCount} 頭\n" +
                                 $"牧場主: {OwnerName}（性格: {OwnerPersonality}）"
                                 : emptyData.GetData();

            return returndata;
        }
    }
}
