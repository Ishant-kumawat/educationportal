using KaniniAcademy.Repository;
using KaniniAcademy.Models;
using Microsoft.EntityFrameworkCore;
using Azure.Identity;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<KaniniAcademyContext>(
    options =>
    {
        options.UseMySql(builder.Configuration.GetConnectionString("KaniniDb"),
            ServerVersion.Parse("8.0.23-mysql"));
    }
    );

builder.Services.ConfigureSwaggerGen(setup =>
{
    setup.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
       
        Version = "v1"
    });
});
builder.Services.AddScoped<ICourseRepository, CourseRepository>();
builder.Services.AddScoped<IBlogRepository, BlogRepository>();
builder.Services.AddScoped<ICertificationRepository, CertificationRepository>();
builder.Services.AddScoped<IAboutcertificatesRepository, AboutCertificateRepository>();
builder.Services.AddScoped<ICourseResourceRepository, CourseResourseRepository>();
builder.Services.AddScoped<IDetails, DetailsRepository>();
builder.Services.AddScoped<ICreator, CreatorRepository>();
builder.Services.AddScoped<ICtcReg, CtcRegRepository>();
builder.Services.AddScoped<IFreeResourse, FreeResourseRepository>();
builder.Services.AddScoped<INotes, NotesRepository>();
builder.Services.AddScoped<IQa, QaRepository>();
builder.Services.AddScoped<IReview, ReviewRepository>();
builder.Services.AddScoped<IUsability, UsabilityRepository>();
builder.Services.AddScoped<IPoints, PointsRepository>();
builder.Services.AddScoped<ISkillQuiz, SkillQuizRepository>();
builder.Services.AddScoped<IStatusOfLearning, StatusOfLearningRepository>();
builder.Services.AddScoped<ISubmission, SubmissionRepository>();
builder.Services.AddScoped<ITraining, TrainingRepository>();
builder.Services.AddScoped<IUserDetails, UserDetailsRepository>();
builder.Services.AddDbContext<KaniniAcademyContext>(options => options.UseSqlServer("constr"));
builder.Services.AddCors(options =>
{
    options.AddPolicy("MyCorPolicy", builder =>
    {
        builder.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader();
    });
});
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("MyCorPolicy");
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
