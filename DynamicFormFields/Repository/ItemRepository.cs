using DynamicFormFields.Models;

namespace DynamicFormFields.Repository
{
    public class ItemRepository
    {
        public static readonly Item Secure = new Item {Id = 1, Name = "Secure"};
        public static readonly Item Guru = new Item {Id = 2, Name = "Guru"};

        public Item[] GetItems()
        {
            return new[]
            {
                Secure,
                Guru
            };
        }

    }
}
