using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Get_DellWarranty
{
    public class warrantyLookupEngine
    {
        private Guid engineGuid;
        public string appName;
        private string serviceURI;

        //constructor
        public warrantyLookupEngine(string URI = "http://xserv.dell.com/services/assetservice.asmx")
        {
            this.engineGuid = Guid.NewGuid();
            this.appName = "Warranty Lookup Tool for Dell Systems";
            this.serviceURI = URI;
        }
        public void setServiceURI(string URI)
        {
            this.serviceURI = URI;
        }
        public void engineLookup(ref Computer machine, ref string machineSerial)
        {
            if (machineSerial.Length != 7)
            {
                throw new ArgumentNullException();
            }
            Get_DellWarranty.DellServiceReference.AssetService engine = new Get_DellWarranty.DellServiceReference.AssetService();
            Get_DellWarranty.DellServiceReference.Asset[] result = engine.GetAssetInformation(this.engineGuid, this.appName, machineSerial);


            DellServiceReference.EntitlementData[] Entitlements = result[0].Entitlements;
            DateTime WarrantyEndDate = Entitlements[0].EndDate;
            machine = new Computer("unknown", machineSerial, result[0].AssetHeaderData.SystemModel, result[0].AssetHeaderData.SystemShipDate, WarrantyEndDate);
        }

    }
}
