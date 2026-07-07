using Emp_CRUD.Repositories;  
using Emp_CRUD.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// builder.Services.AddCors(options=>{
//     options.AddPolicy("AllowAll",
//     builder=>builder.AllowAnyOrigin(),builder.AllowAnyHeader(), builder.AllowAnyMethod());
// });

builder.Services.AddOpenApi();
builder.Services.AddScoped<IEmployeeRepository , EmployeeRepository>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();

// builder.Services.AddCors(options=>{
//     options.AddPolicy("AllowAll",
//     builder=>builder.AllowAnyOrigin(),builder.AllowAnyHeader(), builder.AllowAnyMethod());
// });



var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.UseCors();

app.Run();
