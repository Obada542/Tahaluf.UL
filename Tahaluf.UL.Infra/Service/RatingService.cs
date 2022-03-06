using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.Repository;
using Tahaluf.UL.Core.Service;

namespace Tahaluf.UL.Infra.Service
{
    public class RatingService : IRatingService
    {
        private readonly IRatingRepository _ratingRepository;
        public RatingService(IRatingRepository ratingRepository)
        {
            this._ratingRepository = ratingRepository;
        }
        public string AddRating(Ratingul rate)
        {
            return _ratingRepository.AddRating(rate);
        }

        public List<Ratingul> GetBookRating(int id)
        {
            return _ratingRepository.GetBookRating(id);
        }
    }
}
