using Expense_Tracker.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//DI
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));

var app = builder.Build();

//Register Syncfusion license
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("@32302e342e30OyGsFi/1iCYTw5hN/7PMahJr31 nHZhzL/2nGrMogDo=;Mgo DSMBaFt/QHRqVVhkVFpGaV5LQmFJfFBmQGlbfFRydEUmHVdTRHRcQl9iS39UdEZhWXZfdHM=;Mgo DSMBMAY9C3t2VVhkQlFacldJX3xId0x0RWFab1t6dlZMYlxBJAtUQF1hSn5Rd0diXn1dcnRcR2Vb;Mgo DSMBPh8sVXJ0S0J XE9AflRAQmJAYVF2R2BJelRyd19EYEwxOX1dQl9gSXxSdERkW3xccH1UQWc=;@32302e342e30pDvW25XqaELfHW87XIrxYOBApK7y3/SB9oJ6VgHxAls=;NRAiBiAaIQQuGjN/V0Z WE9EaFtKVmFWf1ppR2NbfE51fldFal5RVBYiSV9jS31TdERhWHhcc3ZVT2JcVg==;NT8mJyc2IWhhY31nfWN9Z2toYXxianxhY2Fgc2ZpYWBpYWNzAx5oNiA0NyYiJjZiZ2QTND4yOj99MDw ;ORg4AjUWIQA/Gnt2VVhkQlFacldJX3xId0x0RWFab1t6dlZMYlxBJAtUQF1hSn5Rd0diXn1dcnRcRGJb;@32302e342e30nQVO0lKw5uh1jEaL0MiGoaRh6kDsqAWIUmrfZlIfXUo=;@32302e342e30BFXop6my6lsDb2KEOvDjvRP vVVapqvSGoTl7 pmfZI=;@32302e342e30bYzUpFS7zHU6l7ta/cXSxzm5GAUVgll/NyFQ3a5N46M=;@32302e342e30covyuq mavobR /kgqPc4hJZGyf6LlQfCL6xTKDPGu0=;@32302e342e30OyGsFi/1iCYTw5hN/7PMahJr31 nHZhzL/2nGrMogDo=");

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
