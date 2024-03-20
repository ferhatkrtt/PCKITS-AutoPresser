using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace PCKITSAutoPresser
{
    class ProcessList
    {

        public  List<string> ProcessNames = new List<string>();
        public  List<string> Pid = new List<string>();
        public List<int> RamUsage = new List<int>();
        

        public void GetProcessInformations()
        {
            foreach(var names in Process.GetProcesses())
            {
                ProcessNames.Add(names.ProcessName);
                Pid.Add(names.Id.ToString());
                try
                {
                    RamUsage.Add(Convert.ToInt32(names.PagedMemorySize64));
                }catch(Exception){
                    continue;
                }
             
            }
        }
    }
}
