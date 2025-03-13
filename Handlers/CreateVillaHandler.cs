using Azure;
using System.Net;
using MagicVilla_VillaAPI.Commands;
using MagicVilla_VillaAPI.Models;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using AutoMapper;
using MagicVilla_VillaAPI.Repository.IRepository;
using System.Web.Http.ModelBinding;
using Microsoft.AspNetCore.Mvc;
using MagicVilla_VillaAPI.Models.Dto;

namespace MagicVilla_VillaAPI.Handlers
{
    public class CreateVillaHandler : IRequestHandler<CreateVillaRequest, ActionResult<APIResponse>>
    {

        protected APIResponse _response;
        private readonly IVillaRepository _dbVilla;
        private readonly IMapper _mapper;

        public CreateVillaHandler(IVillaRepository dbVilla, IMapper mapper)
        {
            _mapper = mapper;
            _dbVilla = dbVilla;
            this._response = new();
        }

        public async Task<ActionResult<APIResponse>> Handle(CreateVillaRequest request, CancellationToken cancellationToken)
        {
            try
            {
                Villa model = _mapper.Map<Villa>(request._createDTO);

                await _dbVilla.CreateAsync(model);
                _response.Result = _mapper.Map<VillaDTO>(model);
                _response.isSuccess = true;
                _response.StatusCode = HttpStatusCode.Created;

                return _response;
            }
            catch (Exception ex)
            {
                _response.ErrorMessages.Add(ex.Message);
                _response.isSuccess = false;
                _response.StatusCode = HttpStatusCode.BadRequest;
            }

            return _response;

        }
    }
}
