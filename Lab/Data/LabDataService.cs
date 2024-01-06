namespace Lab.Data
{
    public  static class LabDataService
    {
        public static List<Models.Lab> Labs = new List<Models.Lab>()
        {
            new Models.Lab { Id = 1, TestType = "Blood", Status = "Pending", Branch = "Colombo" },
            new Models.Lab  { Id = 2, TestType = "Urine", Status = "In Progress", Branch = "Gampaha" },
            new Models.Lab  { Id = 3, TestType = "Diabetics", Status = "Completed", Branch = "Kalutara" },
            new Models.Lab  { Id = 4, TestType = "Pressure", Status = "Pending", Branch = "Maharagama" },
            new Models.Lab  { Id = 5, TestType = "cholestrol", Status = "In Progress", Branch = "Piliyandala" }
        };
    }
}
