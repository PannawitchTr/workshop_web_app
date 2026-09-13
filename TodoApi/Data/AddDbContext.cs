using Microsoft.EntityFrameworkCore;
using TodoApi.Dtos.Model;

namespace TodoApi.Data;

public class AddDbContext : DbContext
{
    public AddDbContext(DbContextOptions<AddDbContext> options) : base(options) { }

    public DbSet<TodoItem> Todos => Set<TodoItem>();
}