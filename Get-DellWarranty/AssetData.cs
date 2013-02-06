using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Get_DellWarranty
{
    public class AssetData {

        private string machineName;
        private string serviceTag;
        private string systemID;
        private string buid;
        private string region;
        private string systemType;
        private string systemModel;
        private DateTime systemShip;
        private DateTime machineWarrantyEnd;

        //default constructor
        public AssetData() { }
        //alternative constructors
        public AssetData
            (
                string newMachineName,
                string newServiceTag,
                string newSystemID,
                string newBuid,
                string newRegion,
                string newSystemType,
                string newSystemModel,
                DateTime newSystemShip,
                DateTime newMachineWarrantyEnd
            )
        {
            this.machineName = newMachineName;
            this.serviceTag = newServiceTag;
            this.systemID = newSystemID;
            this.buid = newBuid;
            this.region = newRegion;
            this.systemType = newSystemType;
            this.systemModel = newSystemModel;
            this.systemShip = newSystemShip;
            this.machineWarrantyEnd = newMachineWarrantyEnd;
        }

        public AssetData ( AssetData otherAsset )
        {
            this.machineName = otherAsset.machineName;
            this.serviceTag = otherAsset.serviceTag;
            this.systemID = otherAsset.systemID;
            this.buid = otherAsset.buid;
            this.region = otherAsset.region;
            this.systemType = otherAsset.systemType;
            this.systemModel = otherAsset.systemModel;
            this.systemShip = otherAsset.systemShip;
            this.machineWarrantyEnd = otherAsset.machineWarrantyEnd;
        }

        public string Name() { return this.machineName; }
        public string Serial() { return this.serviceTag; }
        public string SystemID() { return systemID; }
        public string Buid() { return buid; }
        public string Region() { return region; }
        public string Type() { return systemType; }
        public string Model() { return systemModel; }
        public DateTime ShipDate() { return this.systemShip; }
        public DateTime WarrantyEnd() { return this.machineWarrantyEnd; }

        public void Name(string newName) { this.machineName = newName; }
        public void Serial(string newSerial) { this.serviceTag = newSerial; }
        public void SystemID(string newSystemID) { this.systemID = newSystemID; }
        public void Buid(string newBuid) { this.buid = newBuid; }
        public void Region(string newRegion) { this.region = newRegion; }
        public void Type(string newType) { this.systemType = newType; }
        public void Model(string newModel) { this.systemModel = newModel; }
        public void ShipDate(DateTime newShipDate) { this.systemShip = newShipDate; }
        public void WarrantyEnd(DateTime newWarrantyEnd) { this.machineWarrantyEnd = newWarrantyEnd; }


        public override string ToString() { return
                         "Service Tag: "+this.Serial()+"\n"+
                         "Region: "+this.Region()+"\n"+
                         "Type: "+this.Type()+"\n"+
                         "Model: "+this.Model()+"\n"+
                         "ShipDate: "+this.ShipDate()+"\n"+
                         "Service: "+this.WarrantyEnd()+"\n"
            ;}

    }
}
