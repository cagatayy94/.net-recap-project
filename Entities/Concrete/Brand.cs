using System;
using Core.Entities;

namespace Entities.Concrate
{
    public class Brand:IEntity
    {
        public Brand()
        {
        }

        public int BrandId { get; set; }
        public string BrandName { get; set; }
    }
}
