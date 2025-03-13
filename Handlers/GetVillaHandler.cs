using Azure;
using System.Net;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.Dto;
using MagicVilla_VillaAPI.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using MagicVilla_VillaAPI.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;


namespace MagicVilla_VillaAPI.Handlers
{
    public class GetVillaHandler : IRequestHandler<GetVillaQuery, ActionResult<APIResponse>>
    {

        protected APIResponse _response;
        private readonly IVillaRepository _dbVilla;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public GetVillaHandler(IVillaRepository dbVilla, IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _dbVilla = dbVilla;
            this._response = new();
            _mediator = mediator;

        }

        public async Task<ActionResult<APIResponse>> Handle(GetVillaQuery request, CancellationToken cancellationToken)
        {
            var villa = await _dbVilla.GetAsync(u => u.Id == request._id);
         
            _response.Result = _mapper.Map<VillaDTO>(villa);
            _response.StatusCode = HttpStatusCode.OK;
            return _response;
        }

    }
}
