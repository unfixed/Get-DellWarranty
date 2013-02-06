using System;
using System.Management;
using System.Management.Automation;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Get_DellWarranty
{



    [System.Management.Automation.Cmdlet("Get", "DellWarranty")]
    public class Cmdlet_GetDellWarranty : System.Management.Automation.PSCmdlet
    {
        [System.Management.Automation.Parameter(Position=0,Mandatory=true,ValueFromPipeline=true)]
        public string ServiceTag;

        protected override void ProcessRecord()
        {
            warrantyLookupEngine lookupEngine = new warrantyLookupEngine();
            Computer machine = new Computer();
            lookupEngine.engineLookup(ref machine, ref this.ServiceTag);
            this.WriteObject(machine.Model());
        }
    }
}
