using Inventiny.CoreBusiness;

namespace Inventiny.UseCases.Inventories
{
    public interface IViewInventoryByIdUseCase
    {
        Task<Inventory> ExecuteAsync(int id);
    }
}