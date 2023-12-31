using Catalog.Entities;

namespace Catalog.Repositories
{
  

    public class InMemItemRepository : IItemsRepository
    {
        private readonly List<Item> items = new()
        {
            new Item{Id = Guid.NewGuid(), Name = "Potion", Price = 9, CreatedDate = DateTimeOffset.UtcNow},
            new Item{Id = Guid.NewGuid(), Name = "Iron Sword", Price = 20, CreatedDate = DateTimeOffset.UtcNow},
            new Item{Id = Guid.NewGuid(), Name = "Bronz Shield", Price = 18, CreatedDate = DateTimeOffset.UtcNow},
        };

        public IEnumerable<Item> GetItems()
        {
            return items;
        }
        public Item GetItem(Guid id)
        {
            return items.Where(i => i.Id == id).SingleOrDefault();
        }

        public void CreateItem(Item item)
        {
            items.Add(item);
        }

        public void UpdateItem(Item item)
        {
           var index = items.FindIndex(i => i.Id == item.Id);
           items[index] = item;
        }

        public void DeleteItem(Guid id)
        {
            var index = items.FindIndex(i => i.Id == id);
            items.RemoveAt(index);
        }
    }
}