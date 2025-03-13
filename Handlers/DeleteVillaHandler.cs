using Azure;
using System.Net;
using MagicVilla_VillaAPI.Commands;
using MagicVilla_VillaAPI.Models;
using MediatR;
using MagicVilla_VillaAPI.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Azure.Core;

namespace MagicVilla_VillaAPI.Handlers
{
    public class DeleteVillaHandler : IRequestHandler<DeleteVillaRequest, ActionResult<APIResponse>>
    {
        private readonly IVillaRepository _dbVilla;
        private readonly APIResponse _response;

        public DeleteVillaHandler(IVillaRepository dbVilla)
        {
            _dbVilla = dbVilla;
            this._response = new();
        }

        public async Task<ActionResult<APIResponse>> Handle(DeleteVillaRequest request, CancellationToken cancellationToken)
        {
            var selectVilla = await _dbVilla.GetAsync(delVilla => delVilla.Id == request._id);

            await _dbVilla.RemoveAsync(selectVilla);
            _response.StatusCode = HttpStatusCode.NoContent;
            _response.isSuccess = true;

            return _response;
        }    
    }
}

