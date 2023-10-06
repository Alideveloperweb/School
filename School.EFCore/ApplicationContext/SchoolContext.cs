using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.EFCore.ApplicationContext
{
    public class SchoolContext:DbContext
    {
        #region Constractore

        public SchoolContext(DbContextOptions<SchoolContext> options):base(options)
        {

        }

        #endregion

        #region Entity

        #endregion

    }
}
