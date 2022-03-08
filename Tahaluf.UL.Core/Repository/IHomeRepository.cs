using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;

namespace Tahaluf.UL.Core.Repository
{
   public interface IHomeRepository
    {
        List<Homeul> GetAllSliders();
        bool CreateSlider(Homeul slider);
        bool UpdateSlider(Homeul slider);
        bool DeleteSlider(int id);
    }
}
