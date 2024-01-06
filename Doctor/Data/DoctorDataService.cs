namespace Doctor.Data
{
    public static class DoctorDataService
    {
        public static List<Models.Doctor> Doctors = new List<Models.Doctor>()
        {
            new Models.Doctor { Id = 1, Name = "Amal", Hospital = "Colombo", Specialization = "Neurology"  },
            new Models.Doctor { Id = 2, Name = "Kamal", Hospital = "Kalutara", Specialization = "Nuclear medicine" },
            new Models.Doctor { Id = 3, Name = "Nimal",  Hospital= "Jayawardenepura", Specialization = "Ophthalmology"  },
            new Models.Doctor { Id = 4, Name = "Sunil", Hospital = "Kalubowila", Specialization = "Pediatrics" },
            new Models.Doctor { Id = 5, Name = "Ruwan", Hospital = "Panadura", Specialization = "Pediatrics" }
        };
    }
}
