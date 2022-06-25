using HskApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace Hski.Models
{
    public class HskContext : DbContext
    {
        public HskContext(DbContextOptions<HskContext> options)
            : base(options)
        {
        }

        public DbSet<HskDetails> HskDetails { get; set; } = null!;
    }
}