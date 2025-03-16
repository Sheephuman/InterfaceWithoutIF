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

            if (HasEmployeeData)
            {
                var employee = this ?? throw new ArgumentNullException(nameof(FemaleEmployeeImpl));
                // FemaleEmployeeの場合のデータ表示
                return $"名前: {employee.EmployeeName}（身長: {employee.Height}cm）\n" +
                       $"3サイズ: B{employee.Measurements.Bust} W{employee.Measurements.Waist}" +
                       $" H{employee.Measurements.Hip}\n" +
                       $"羊種: {employee.SheepBreed}";
            }

            return "データがありません";
        }
    }

}
