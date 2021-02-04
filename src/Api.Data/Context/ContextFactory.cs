using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            var conn = "Server=localhost;Port=3306;Database=dbApi;Uid=root;Pwd=LG17041998";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseMySql(conn);
            return new MyContext(optionsBuilder.Options);
        }
    }
}
