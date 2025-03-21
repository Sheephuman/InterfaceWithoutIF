using InterfaceWithoutIF;

namespace SuperDataClassTest
{
    public class FemaleEmployeeImpl: IDataContainer
    {
        public string EmployeeName { get; set; }
        public int Height { get; set; }
        public (int Bust, int Waist, int Hip) Measurements { get; set; }
        public string? SheepBreed { get; set; }

        public bool HasEmployeeData { get; set; }


        // コンストラクタ
        public FemaleEmployeeImpl(string employeeName, int height, 
            (int Bust, int Waist, int Hip) measurements, string sheepBreed
            ,bool _hasEmployee)
        {
            HasEmployeeData = _hasEmployee;
            
            EmployeeName = employeeName ;

            Height = height;
            Measurements = measurements;
            SheepBreed = sheepBreed;
        }

   
            public string GetData()
        {

            var emptyData = new EmptyDataContainer();   

            var returnData = HasEmployeeData ? // FemaleEmployeeの場合のデータ表示
            $"名前: {EmployeeName}（身長: {Height}cm）\n" +
                   $"3サイズ: B{Measurements.Bust} W{Measurements.Waist}" +
                   $" H{Measurements.Hip}\n" +
                   $"羊種: {SheepBreed}" : emptyData.GetData() ;


            return returnData;





        }
    }

}
