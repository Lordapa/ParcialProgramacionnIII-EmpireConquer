﻿using MiguelBeneditProgramación3_Core.Entities;
using MiguelBeneditProgramación3_Core.Interfaces.Services;

namespace MiguelBeneditProgramación3_WebApplication.V1.Controllers
{
    public class QuestController : BaseApiController<Quest>
    {
        public QuestController(IBaseService baseService) : base(baseService)
        {
        }
    }
}
