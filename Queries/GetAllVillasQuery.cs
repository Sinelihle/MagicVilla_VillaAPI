using MagicVilla_VillaAPI.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Queries
{
    public class GetAllVillasQuery: IRequest<ActionResult<APIResponse>>
    {
        public string? _search;
        public int? _occupancy;
        public int _pageSize = 3;
        public int _pageNumber = 1;
        public GetAllVillasQuery(string? search, int? occupany,int pageSize, int pageNumber)
        {
            _search = search;
            _occupancy = occupany;
            _pageSize = pageSize;
            _pageNumber = pageNumber;
        }

        //overloading this so we can revert
        public GetAllVillasQuery(string? search, int? occupany)
        {
            _search = search;
            _occupancy = occupany;
        }
    }
}
