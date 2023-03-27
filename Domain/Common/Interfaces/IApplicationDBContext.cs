using Domain.Master;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common.Interfaces
{

        public interface IApplicationDBContext
        {
            DbSet<AppSetting> AppSettings { get; set; }
            Task<int> SaveChangesAsync();
        }
    
}
