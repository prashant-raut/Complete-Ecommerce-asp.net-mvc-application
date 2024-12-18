using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETicket.Data.Base;
using ETicket.Models;

namespace ETicket.Data.Services
{
    public class ProducerService:EntityBaseRepository<Producer>,IProducerService
    {
        public ProducerService(AppDbContext context):base(context)
        {

        }
    }
}
