using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDotNetCoreCQRS.Application.Queries.Handlers
{
    public class GetPackingListHandler : IQueryHandler<GetPackingList, PackingListDTO>
    {
        private readonly IPackingListRepository _repository;
        public GetPackingListHandler(IPackingListRepository repository)
        {
            _repository = repository;
        }
        public async Task<PackingListDTO> HandleAsync(GetPackingList query)
        {
            //var packingList = await _repository.GetAsync(query.Id);
            //return packingList?.AsDto();
        }
    }
}
