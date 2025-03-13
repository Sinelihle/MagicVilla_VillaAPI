using System.Linq;
using System.Net;
using AutoMapper;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.Dto;
using MagicVilla_VillaAPI.Queries;
using MagicVilla_VillaAPI.Repository.IRepository;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Handlers
{
    public class GetAllVillasHandler : IRequestHandler<GetAllVillasQuery, ActionResult<APIResponse>>
    {

        protected APIResponse _response;
        private readonly IVillaRepository _dbVilla;
        private readonly IMapper _mapper;
        public GetAllVillasHandler(IVillaRepository dbVilla, IMapper mapper)
        {
            _mapper = mapper;
            _dbVilla = dbVilla;
            this._response = new();
        }

        public async Task<ActionResult<APIResponse>> Handle(GetAllVillasQuery request, CancellationToken cancellationToken)
        {

            IEnumerable<Villa> villaList;
            if (request._occupancy > 0)
            {
               villaList = await _dbVilla.GetAllAsync(x => x.Occupancy == request._occupancy, pageSize: request._pageSize, pageNumber:request._pageNumber);
                _response.Result = villaList;
                _response.StatusCode = HttpStatusCode.OK;

            }
            else
            {
                villaList = await _dbVilla.GetAllAsync(pageSize: request._pageSize, pageNumber: request._pageNumber);
                _response.Result = villaList;
                _response.StatusCode = HttpStatusCode.OK;

            }
            if (!string.IsNullOrEmpty(request._search))
            {
                _response.Result = villaList.Where(x => x.Amenity.ToLower().Contains(request._search.ToLower()) || x.Name.ToLower().Contains(request._search.ToLower()));
                _response.StatusCode = HttpStatusCode.OK;

            }
            return _response;
        }
    }
}
