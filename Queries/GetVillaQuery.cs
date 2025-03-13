using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.Dto;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Queries
{
    public class GetVillaQuery : IRequest<ActionResult<APIResponse>>
    {
        public int _id { get; }

        public GetVillaQuery(int id)
        {
            _id = id;
        }
    }
}
