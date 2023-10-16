using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace DesafioApi.Context;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    { }

    public DbSet<ToDoItem> ToDoItems { get; set; }


}