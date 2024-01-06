namespace Lab.Services
{
    public interface ILabService
    {
        List<Models.Lab> GetLabs();
        Models.Lab? GetLab(int id);
        Models.Lab? AddLab(Models.Lab lab);
        Models.Lab? UpdateLab(Models.Lab lab);
        bool? DeleteLab(int id);
    }
}
