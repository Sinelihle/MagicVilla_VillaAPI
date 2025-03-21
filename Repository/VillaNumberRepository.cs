﻿using System.Linq.Expressions;
using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.Dto;
using MagicVilla_VillaAPI.Repository.IRepository;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace MagicVilla_VillaAPI.Repository
{
    public class VillaNumberRepository :Repository<VillaNumber>, IVillaNumberRepository
    {
        protected ApplicationDbContext _db;

        public VillaNumberRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }


        public async Task<VillaNumber> UpdateAsync(VillaNumber entity)
        { 
            _db.VillaNumbers.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

    }
}

