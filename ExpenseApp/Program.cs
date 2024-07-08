using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ExpenseApp.Data;

namespace ExpenseApp;

public class Program {
    public static void Main(string[] args) {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddDbContext<ExpenseAppContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("ExpenseAppContext") ?? throw new InvalidOperationException("Connection string 'ExpenseAppContext' not found.")));

        builder.Services.AddDbContext<ExpenseAppContext>(options =>

           options.UseSqlServer(builder.Configuration.GetConnectionString("ExpenseAppContext") ?? throw new InvalidOperationException("Connection string 'PRS_ServerContext' not found.")));

        builder.Services.AddDbContext<ExpenseAppContext>(options =>
               options.UseSqlServer(builder.Configuration.GetConnectionString("ExpenseAppContext")
               ?? throw new InvalidOperationException("Connection string 'ExpenseAppContext' not found.")));

        
        builder.Services.AddControllers();
        builder.Services.AddCors();
        var app = builder.Build();

        app.UseCors(x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}
