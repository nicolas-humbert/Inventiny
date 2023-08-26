using Inventiny.CoreBusiness;
using Inventiny.UseCases.PluginInterfaces;

namespace Inventiny.UseCases.Inventories.Interfaces
{
    public class ViewInventoryByIdUseCase : IViewInventoryByIdUseCase
    {
        private readonly IInventoryRepository _inventoryRepository;

        public ViewInventoryByIdUseCase(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
        }

        public async Task<Inventory> ExecuteAsync(int id)
        {
            return await _inventoryRepository.GetInventoryByIdAsync(id);
        }
    }
}
