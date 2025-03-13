using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.Dto;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Commands
{
    public class CreateVillaRequest: IRequest<ActionResult<APIResponse>>
    {
        public VillaCreateDTO _createDTO;

        public CreateVillaRequest(VillaCreateDTO createDTO)
        {
            _createDTO = createDTO;
        }
    }
}
