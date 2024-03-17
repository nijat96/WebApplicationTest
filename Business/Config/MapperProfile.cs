using AutoMapper;
using DataAccess.Entity;
using DTO.DTOEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Config
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<AboutDTO, About>();
            CreateMap<About, AboutDTO>();

            CreateMap<CategoryDTO, Category>();
            CreateMap<Category, CategoryDTO>();

            CreateMap<ContactDTO, Contact>();
            CreateMap<Contact, ContactDTO>();

            CreateMap<CustomerDTO, Customer>();
            CreateMap<Customer, CustomerDTO>();

            CreateMap<MenuDTO, Menu>();
            CreateMap<Menu, MenuDTO>();

            CreateMap<MessageDTO, Message>();
            CreateMap<Message, MessageDTO>();

            CreateMap<RoleDTO, Role>();
            CreateMap<Role, RoleDTO>();

            CreateMap<UserDTO, User>();
            CreateMap<User, UserDTO>();
        }
    }
}
