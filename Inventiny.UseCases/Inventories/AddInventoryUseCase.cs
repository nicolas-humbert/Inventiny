using Inventiny.CoreBusiness;
using Inventiny.UseCases.Inventories.Interfaces;
using Inventiny.UseCases.PluginInterfaces;

namespace Inventiny.UseCases.Inventories
{
    public class AddInventoryUseCase : IAddInventoryUseCase
    {
        private readonly IInventoryRepository inventoryRepository;

        public AddInventoryUseCase(IInventoryRepository inventoryepository)
        {
            inventoryRepository = inventoryepository;
        }


        public async Task ExecuteAsync(Inventory inventory)
        {
            if (!await inventoryRepository.ExistsAsync(inventory))
                await inventoryRepository.AddInventoryAsync(inventory);
        }
    }
}
