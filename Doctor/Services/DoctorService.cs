using Doctor.Data;
using Doctor.Models;

namespace Doctor.Services
{
    public class DoctorService:IDoctorService
    {
        public List<Models.Doctor> GetDoctors()
        {
            return DoctorDataService.Doctors;
        }

        public Models.Doctor? GetDoctor(int id)
        {
            return DoctorDataService.Doctors.FirstOrDefault(x => x.Id == id);
        }

        public Models.Doctor? AddDoctor(Models.Doctor doctor)
        {
            DoctorDataService.Doctors.Add(doctor);
            return doctor;
        }

        public Models.Doctor? UpdateDoctor(Models.Doctor doctor)
        {
            Models.Doctor selectedDoctor = DoctorDataService.Doctors.FirstOrDefault(x => x.Id == doctor.Id);
            if (selectedDoctor != null)
            {
                selectedDoctor.Hospital = doctor.Hospital;
                selectedDoctor.Specialization = doctor.Specialization;
                selectedDoctor.Name = doctor.Name;
                return selectedDoctor;
            }

            return selectedDoctor;
        }

        public bool? DeleteDoctor(int id)
        {
            Models.Doctor selectedDoctor = DoctorDataService.Doctors.FirstOrDefault(x => x.Id == id);
            if (selectedDoctor != null)
            {
                DoctorDataService.Doctors.Remove(selectedDoctor);
                return true;
            }
            return false;
        }
    }
}
