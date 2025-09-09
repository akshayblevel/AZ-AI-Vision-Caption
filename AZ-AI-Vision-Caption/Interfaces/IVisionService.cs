namespace AZ_AI_Vision_Caption.Interfaces
{
    public interface IVisionService
    {
        Task<string> GetCaptionAsync(string imageUrl);
    }
}
