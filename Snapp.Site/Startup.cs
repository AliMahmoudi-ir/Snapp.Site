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

<<<<<<< HEAD
        
=======
>>>>>>> 09fa0ec708dcac846b690c74e442ea12ee640c55
        #region AddDbContext    
        services.AddDbContext<DatabaseContext>(options =>
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        });

        #endregion
<<<<<<< HEAD

        #region 
        //services.AddScoped<Itest, TestService>();
        #endregion

        #region Add Service
        services.AddMvc(option => option.EnableEndpointRouting = false);
        #endregion

=======
        services.AddMvc(option => option.EnableEndpointRouting = false);
>>>>>>> 09fa0ec708dcac846b690c74e442ea12ee640c55
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
