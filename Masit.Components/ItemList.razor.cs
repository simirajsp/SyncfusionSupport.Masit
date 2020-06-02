using Masit.Components.Models;
using Microsoft.AspNetCore.Components;

namespace Masit.Components
{
    public class ItemListBase: ComponentBase
    {
        public ItemQuery Query { get; set; }

        protected override void OnInitialized()
        {
            Query = new ItemQuery
            {
                ItemType = "Category"
            };
        }

    }
}
