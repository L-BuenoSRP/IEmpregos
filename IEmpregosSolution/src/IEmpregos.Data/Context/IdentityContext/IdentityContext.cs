﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IEmpregos.Data.Context.IdentityContext
{
    public class IdentityContext : IdentityDbContext
    {
        public IdentityContext(DbContextOptions<IdentityContext> options)
            : base(options)
        {
        }
    }
}
