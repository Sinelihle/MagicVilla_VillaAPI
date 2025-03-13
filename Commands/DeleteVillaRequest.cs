using MagicVilla_VillaAPI.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Commands
{
    public class DeleteVillaRequest: IRequest<ActionResult<APIResponse>>
    {
        public int _id;

        public DeleteVillaRequest(int id)
        {
            _id = id;
        }
    }
}
