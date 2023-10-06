using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Commom.Domain
{
    public class EntityBase<TKey>
    {


        public TKey Id { get; private set; }
        public DateTime CreateDate { get; private set; }
        public DateTime? LastUpdate { get; private set; }
        public bool IsRemove { get; private set; }

        #region Constracture

        public EntityBase()
        {
            CreateDate = DateTime.Now;
            IsRemove = false;
        }

        #endregion

    }
}
