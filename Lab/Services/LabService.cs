using Lab.Data;
using Lab.Models;



namespace Lab.Services
{
    public class LabService : ILabService
    {
        public List<Models.Lab> GetLabs()
        {
            return LabDataService.Labs;
        }



        public Models.Lab? GetLab(int id)
        {
            return LabDataService.Labs.FirstOrDefault(x => x.Id == id);
        }



        public Models.Lab? AddLab(Models.Lab lab)
        {
            LabDataService.Labs.Add(lab);
            return lab;
        }



        public Models.Lab? UpdateLab(Models.Lab lab)
        {
            Models.Lab selectedLab = LabDataService.Labs.FirstOrDefault(x => x.Id == lab.Id);
            if (selectedLab != null)
            {
                selectedLab.Status = lab.Status;
                selectedLab.Branch = lab.Branch;
                selectedLab.TestType = lab.TestType;
                return selectedLab;
            }



            return selectedLab;
        }



        public bool? DeleteLab(int id)
        {
            Models.Lab selectedLab = LabDataService.Labs.FirstOrDefault(x => x.Id == id);
            if (selectedLab != null)
            {
                LabDataService.Labs.Remove(selectedLab);
                return true;
            }
            return false;
        }
    }
}