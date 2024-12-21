using Snapp.DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
public class Startup
{
    public IConfiguration Configuration { get; set; }

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    // Configure services here (equivalent to ConfigureServices)
    public void ConfigureServices(IServiceCollection services)
    {

        #region AddDbContext    
        services.AddDbContext<DatabaseContext>(options =>
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        });

        #endregion
        services.AddMvc(option => option.EnableEndpointRouting = false);
    }

    // Configure middleware here (equivalent to Configure)
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (!env.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });
    }
}
