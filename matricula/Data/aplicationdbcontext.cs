using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace matricula.Data
{
    public class aplicationdbcontext
    {
        public aplicationdbcontext(DbContextOptions<aplicationdbcontext>options)
        : base(options)
         {
         }
    }
}