﻿using System;
using System.Management;
using System.Management.Automation;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Get_DellWarranty
{
    [System.Management.Automation.Cmdlet("Get", "DellWarranty")]
    public class Get_DellWarranty : System.Management.Automation.PSCmdlet
    {
        [System.Management.Automation.Parameter(Position=0,Mandatory=true,ValueFromPipeline=true)]
        public string ServiceTag;

        protected override void ProcessRecord()
        {
            this.WriteObject(this.ServiceTag);
        }
    }
}
