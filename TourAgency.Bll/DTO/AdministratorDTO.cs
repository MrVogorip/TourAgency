﻿using Microsoft.AspNet.Identity.EntityFramework;
using TourAgency.Bll.DTO.Abstractions;

namespace TourAgency.Bll.DTO
{
    public class AdministratorDTO : BaseEntityDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserId { get; set; }
        public ApplicationUserDTO User { get; set; }
    }
}
