using System.Collections.Generic;
using System.Threading.Tasks;
using Masit.Components.Models;
using Microsoft.AspNetCore.Components;

using Syncfusion.Blazor;
using Syncfusion.Blazor.Data;

namespace Masit.Components
{
    public class QueryDataAdapterBase: DataAdaptor
    {
        [Parameter]
        public BaseQuery Query { get; set; }

        public override async Task<object> ReadAsync(DataManagerRequest dataManagerRequest, string key = null)
        {
            if (dataManagerRequest.RequiresCounts)
            {
                return new DataResult {Result = GetData(dataManagerRequest.Skip,dataManagerRequest.Take), Count = 100};
            }

            return GetData(0, 10);
        }

        private List<ItemSummaryViewModel> GetData(int skip, int take)
        {
            var data = new List<ItemSummaryViewModel>();

            for (int index = skip; index < skip + take; index++)
            {
                data.Add(new ItemSummaryViewModel
                {
                    Id = index,
                    Name = $"Item {index}"
                });
            }

            return data;
        }
    }
}
