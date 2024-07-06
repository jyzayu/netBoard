using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using netBoard.Models;

namespace netBoard.Data
{
    public class netBoardContext : DbContext
    {
        public netBoardContext (DbContextOptions<netBoardContext> options)
            : base(options)
        {
        }

        public DbSet<netBoard.Models.Board> Board { get; set; } = default!;
    }
}
