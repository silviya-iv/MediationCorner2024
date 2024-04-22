﻿using Microsoft.AspNetCore.Mvc;

namespace MediationCorner.Components
{
        public class MenuComponent : ViewComponent
        {
            public async Task<IViewComponentResult> InvokeAsync()
            {
                return await Task.FromResult<IViewComponentResult>(View());
            }
        }
    }

