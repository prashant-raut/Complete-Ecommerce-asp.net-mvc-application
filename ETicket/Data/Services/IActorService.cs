using ETicket.Data.Base;
using ETicket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicket.Data.Services
{
    public interface IActorsService:IEntityBaseRepository<Actor>
    {

        //Task<IEnumerable<Actor>> GetAllAsync();
        //Task<Actor> GetByIdAsync(int id);

        //Task<Actor> UpdateAsync(int id, Actor newActor);
        //Task DeleteAsync(int id);
    }
}

