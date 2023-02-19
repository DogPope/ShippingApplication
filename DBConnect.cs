using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingApplication
{
    class DBConnect
    {
        // Tried copying the Nuget folder from X86 programs to just /programs.
        // Also should be noted that "plsql" directory is in C:\OracleBase19c\diag so might try copying that to programs.
        // tsnames is at C:\Oracle19c\WINDOWS.X64_193000_db_home\network\admin
        // Changed Active Solution platform to X86. https://stackoverflow.com/questions/67682501/error-in-connecting-visual-studio-2019-with-oracle-19c changed back after.
        // None of the above solutions worked. Maybe this just applies to home computer?

        public const String oradb = "Data Source = oracle/orcl; User Id = C##Daniel; Password = password";
        //public const String oradb = "Data Source = oracle/orcl; User Id = T00158237; Password = hkh9J7rgp!iw"; // Works, but only in college.
    }
}
