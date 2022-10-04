using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using wazyApi.Helpers;
using wazyApi.Infrastructure;
using wazyApi.interfaces;
using wazyApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
  builder.Services.AddScoped(typeof (IGenericRepository<>), (typeof (GenericRepository<>)));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
  builder.Services.AddAutoMapper(typeof (MappingProfiles));
builder.Services.AddDbContext<wazytools_vendorContext>(options => 

     options.UseMySql("server=localhost;port=3306;user=ali;password=Ali@123;database=wazytools_vendor_update;Convert Zero Datetime=True", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.30-mysql")));
       
var app = builder.Build();
    // var host = CreateHostBuilder (args).Build ();
    //        using (var scope = app.Services.CreateScope ()) {
    //             var services = scope.ServiceProvider;
    //             var loggerFactory = services.GetRequiredService<ILoggerFactory> ();
    //             try {               
    //                 var identityContext = services.GetRequiredService<wazytools_vendorContext>();
    //                 await identityContext.Database.MigrateAsync();
    //                 await wazytoolsVendorContextSeed.SeedAsync(identityContext, loggerFactory);
    //              } catch (Exception err) {
    //                 var logger = loggerFactory.CreateLogger<Program> ();
    //                 logger.LogError (err, "An error occurred during migration");
    //             }
    //         }
    //         host.Run ();
    //     }






// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseDefaultFiles();
app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();
