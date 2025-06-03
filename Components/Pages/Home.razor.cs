using Microsoft.AspNetCore.Components;
using BlazorAppTrial1.Models;

namespace BlazorAppTrial1.Components.Pages
{
    public partial class Home : ComponentBase
    {
        protected List<InventoryItem> items = new();
        protected InventoryItem newItem = new();
        protected int nextId = 1;

        protected void AddItem()
        {
            if (!string.IsNullOrWhiteSpace(newItem.Name) && newItem.Quantity > 0)
            {
                newItem.Id = nextId++;
                items.Add(new InventoryItem
                {
                    Id = newItem.Id,
                    Name = newItem.Name,
                    Quantity = newItem.Quantity
                });
                newItem = new InventoryItem();
            }
        }

        protected void RemoveItem(int id)
        {
            var item = items.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                items.Remove(item);
            }
        }
    }
}
