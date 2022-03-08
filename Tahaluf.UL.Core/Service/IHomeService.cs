using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;

namespace Tahaluf.UL.Core.Service
{
    public interface IHomeService
    {
        List<Homeul> GetAllHomeul();

        bool CreateHomeul(Homeul hom);


        bool UpdateHomeul(Homeul hom);


        bool DeleteHomeul(int id);
    }
}
