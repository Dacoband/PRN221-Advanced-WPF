using Candidate_Repositories;
using Candidate_Services;

namespace CandidateRazorWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddScoped<IJobPostingRepo, JobPostingRepo>();
            builder.Services.AddScoped<IJobPostingService, JobPostingService>();
            builder.Services.AddScoped<ICandidateProfileRepo, CandidateProfileRepo>();
            builder.Services.AddScoped<ICandidateProfileService, CandidateProfileService>();
            builder.Services.AddScoped<IHRAccountRepo, HRAccountRepo>();
            builder.Services.AddScoped<IHRAccountService, HRAccountService>();
            builder.Services.AddSession();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseSession();

            app.MapRazorPages();

            app.Run();
        }
    }
}