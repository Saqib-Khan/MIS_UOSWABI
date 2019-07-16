using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MIS_UOSWABI
{
    public class MISUOSWABIContext : DbContext
    {
        public MISUOSWABIContext() : base(nameOrConnectionString: "MISUSOSWABI_MainDB_CS")
        {
            Database.SetInitializer<MISUOSWABIContext>(new MISUOSWABIInitializer());
        }

        public DbSet<Grade> Grades { get; set; }

        public DbSet<Student> Students { get; set; }
    }
}