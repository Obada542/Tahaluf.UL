﻿using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;

namespace Tahaluf.UL.Core.Service
{
   public interface IAboutService
    {
        Aboutul GetAboutUl(Aboutul about);



        bool UpdateAbouttUl(Aboutul about);


    }
}
