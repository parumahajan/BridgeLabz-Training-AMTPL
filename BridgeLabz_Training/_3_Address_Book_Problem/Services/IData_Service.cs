using BridgeLabz_Training._3_Address_Book_Problem.Models;

namespace BridgeLabz_Training._3_Address_Book_Problem.Services {

    public interface IData_Service
    {
        Task SaveAsync(Dictionary<string, List<Contact>> addressBooks);
        Task<Dictionary<string, List<Contact>>> LoadAsync();
    }
}