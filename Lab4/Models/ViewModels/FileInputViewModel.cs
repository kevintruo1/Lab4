﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Models.ViewModels
{
    public class FileInputViewModel
    {
        public string CommunityId { get; set; }
        public string CommunityTitle { get; set; }
        public Advertisement Advertisement { get; set; }
    }

}
