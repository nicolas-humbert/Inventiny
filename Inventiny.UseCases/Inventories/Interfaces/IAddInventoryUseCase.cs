using Inventiny.CoreBusiness;

namespace Inventiny.UseCases.Inventories.Interfaces
{
    public interface IAddInventoryUseCase
    {
        Task ExecuteAsync(Inventory inventory);
    }
}