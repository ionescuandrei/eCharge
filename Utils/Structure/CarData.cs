using System;

namespace eChargeAPI.Utils.Structure
{
    public class CarData
    {
        private long carId;
        private double currentChargeInkW;
        public CarData(long carId, double currentChargeInkW)
        {
            this.carId = carId;
            this.currentChargeInkW = currentChargeInkW;
        }

        public long getCarId()
        {
            return carId;
        }

        public void setCarId(long carId)
        {
            this.carId = carId;
        }

        public double getCurrentChargeInkW()
        {
            return currentChargeInkW;
        }

        public void setCurrentChargeInkW(double currentChargeInkW)
        {
            this.currentChargeInkW = currentChargeInkW;
        }
    }
}
