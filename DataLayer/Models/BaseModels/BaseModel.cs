using DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models.BaseModels
{
    public abstract class BaseModel : IModel
    {
        public int Id { get; set; }

        private DateTime createdAt;
        public DateTime CreatedAt
        {
            get
            {
                if (createdAt == DateTime.MinValue)
                    return DateTime.Now; // insert operation
                return createdAt; // update operation
                
            }

            private set => createdAt = value;
        }

        public abstract void IsValid();
    }
}
