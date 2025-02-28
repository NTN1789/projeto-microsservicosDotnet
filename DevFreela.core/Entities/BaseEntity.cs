using System;

namespace DevFreela.core.Entities
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {

        }
        public int Id { get; private set; }
    }

}

