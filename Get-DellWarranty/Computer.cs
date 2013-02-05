using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Get_DellWarranty
{
    public class Computer {
        private string machineName;
        private string machineSerial;
        private string machineModel;
        private DateTime machineShipDate;
        private DateTime machineWarrantyEnd;

        //default constructor
        public Computer() { }
        //alternative constructors
        public Computer(string newMachineName, string newMachineSerial, string newMachineModel, DateTime newMachineShipDate, DateTime newMachineWarrantyEnd)
        {
            this.machineName = newMachineName;
            this.machineSerial = newMachineSerial;
            this.machineModel = newMachineModel;
            this.machineShipDate = newMachineShipDate;
            this.machineWarrantyEnd = newMachineWarrantyEnd;
        }
        
        public Computer(Computer otherComputer)
        {
            this.machineName = otherComputer.machineName;
            this.machineSerial = otherComputer.machineSerial;
            this.machineModel = otherComputer.machineModel;
            this.machineShipDate = otherComputer.machineShipDate;
            this.machineWarrantyEnd = otherComputer.machineWarrantyEnd;
        }

        //get name
        public string Name()
        {
            return this.machineName;
        }
        //set name
        public void Name(string newName)
        {
            this.machineName = newName;
        }
        //get serial
        public string Serial() {
            return this.machineSerial;
        }
        //set serial
        public void Serial(string newSerial)
        {
            this.machineSerial = newSerial;
        }
        //get model
        public string Model() {
            return machineModel;
        }
        //set model
        public void Model(string newModel)
        {
            this.machineModel = newModel;
        }
        //get shipdate
        public DateTime ShipDate()
        {
            return this.machineShipDate;
        }
        //set shipdate
        public void ShipDate(DateTime newShipDate)
        {
            this.machineShipDate = newShipDate;
        }
        //get warranty end date
        public DateTime WarrantyEnd()
        {
            return this.machineWarrantyEnd;
        }
        //set warranty end date
        public void WarrantyEnd(DateTime newWarrantyEnd)
        {
            this.machineWarrantyEnd = newWarrantyEnd;
        }

    }
}
