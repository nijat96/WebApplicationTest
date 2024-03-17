using Business.Abstract;
using Business.Concrete;

namespace WebApplicationTest.Helper
{
    public static class Services
    {
        public static void AddScoped(WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IAboutService, AboutService>();
            builder.Services.AddScoped<ICategoryService, CategoryService>();
            builder.Services.AddScoped<IContactService, ContactService>();
            builder.Services.AddScoped<ICustomerService, CustomerService>();
            builder.Services.AddScoped<IMenuService, MenuService>();
            builder.Services.AddScoped<IMessageService, MessageService>();
            builder.Services.AddScoped<IRoleService, RoleService>();
            builder.Services.AddScoped<IUserService, UserService>();
        }
    }
}
