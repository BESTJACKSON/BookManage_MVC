

namespace BookManage.Models
{
    using System;
    using System.Data.Entity;
    
    public partial class BookContext : DbContext
    {
        public DbSet<Books> Books { get; set; }
    }
}
