using ModernAppliances;
using ModernAppliances.Entities.Abstract;

namespace SubAppliances
{
    class Refrigerator : Appliance
    {
        private readonly int _numberOfDoors;
        private readonly int _height;
        private readonly int _width;

        protected Refrigerator(long itemNumber, string brand, int quantity, decimal wattage, string color, decimal price, int numberOfDoors, int height, int width) : base(itemNumber, brand, quantity, wattage, color, price)
        {
            this._numberOfDoors = numberOfDoors;
            this._height = height;
            this._width = width;
        }
        public override string FormatForFile()
        {
            return $"{ItemNumber};{Brand};{Quantity};{Wattage};{Color};{Price};{_numberOfDoors};{_height};{_width};";
        }

        public override string ToString()
        {
            string line = $"Item Number: {ItemNumber}" +
                "\n" + $"Brand: {Brand}" +
                "\n" + $"Quantity: {Quantity}" +
                "\n" + $"Wattage: {Wattage}" +
                "\n" + $"Color: {Price}" +
                "\n" + $"Price: {Price}" +
                "\n" + $"Number of Doors: {_numberOfDoors}" +
                "\n" + $"Height: {_height}" +
                "\n" + $"Width: {_width}";

            return line;
        }
        class Vacuum : Appliance
        {
            private readonly int _batteryVoltage;
            private readonly string _grade;

            protected Vacuum(long itemNumber, string brand, int quantity, decimal wattage, string color, decimal price, int batteryVoltage, string grade) : base(itemNumber, brand, quantity, wattage, color, price)
            {
                this._batteryVoltage = batteryVoltage;
                this._grade = grade;
            }
            public override string FormatForFile()
            {
                return $"{ItemNumber};{Brand};{Quantity};{Wattage};{Color};{Price};{_batteryVoltage};{_grade}";
            }

            public override string ToString()
            {
                string line = $"Item Number: {ItemNumber}" +
                    "\n" + $"Brand: {Brand}" +
                    "\n" + $"Quantity: {Quantity}" +
                    "\n" + $"Wattage: {Wattage}" +
                    "\n" + $"Color: {Price}" +
                    "\n" + $"Price: {Price}" +
                    "\n" + $"Battery Voltage: {_batteryVoltage}" +
                    "\n" + $"Grade: {_grade}";

                return line;
            }
        }
        class Microwave : Appliance
        {
            private readonly decimal _capacity;
            private readonly char _roomType;

            protected Microwave(long itemNumber, string brand, int quantity, decimal wattage, string color, decimal price, decimal capacity, char roomType, int width) : base(itemNumber, brand, quantity, wattage, color, price)
            {
                this._capacity = capacity;
                this._roomType = roomType;
            }

            public override string FormatForFile()
            {
                return $"{ItemNumber};{Brand};{Quantity};{Wattage};{Color};{Price};{_capacity};{_roomType}";
            }

            public override string ToString()
            {
                string line = $"Item Number: {ItemNumber}" +
                    "\n" + $"Brand: {Brand}" +
                    "\n" + $"Quantity: {Quantity}" +
                    "\n" + $"Wattage: {Wattage}" +
                    "\n" + $"Color: {Price}" +
                    "\n" + $"Price: {Price}" +
                    "\n" + $"Capacity: {_capacity}" +
                    "\n" + $"Room Type: {_roomType}";

                return line;
            }
        }
        class Dishwasher : Appliance
        {
            private readonly string _feature;
            private readonly string _soundRating;

            protected Dishwasher(long itemNumber, string brand, int quantity, decimal wattage, string color, decimal price, string feature, string soundRating) : base(itemNumber, brand, quantity, wattage, color, price)
            {
                this._feature = feature;
                this._soundRating = soundRating;
            }
            public override string FormatForFile()
            {
                return $"{ItemNumber};{Brand};{Quantity};{Wattage};{Color};{Price};{_feature};{_soundRating}";
            }

            public override string ToString()
            {
                string line = $"Item Number: {ItemNumber}" +
                    "\n" + $"Brand: {Brand}" +
                    "\n" + $"Quantity: {Quantity}" +
                    "\n" + $"Wattage: {Wattage}" +
                    "\n" + $"Color: {Price}" +
                    "\n" + $"Price: {Price}" +
                    "\n" + $"Feature: {_feature}" +
                    "\n" + $"Sound Rating: {_soundRating}";

                return line;
            }
        }
    }
}