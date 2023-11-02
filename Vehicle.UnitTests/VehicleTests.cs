namespace Vehicle.UnitTests
{
    public class VehicleTests
    {
        [Fact]
        public void WhenCreated_HasCorrectProperties()
        {
            Vehicle megansCar = new Vehicle(4, "Green");

            Assert.Equal(4, megansCar.NumberOfWheels);
            Assert.Equal("Green", megansCar.Color);
            Assert.Equal(0, megansCar.MilesDriven);
        }

        // This test needs some work!
        /////////////////////////////////////////////////////////////////
        [Fact]
        public void Summary_ReturnsInfoAboutVehicle()
        {
            Vehicle andysBike = new Vehicle(2, "Blue");

            Assert.Equal(2, andysBike.NumberOfWheels);
            Assert.Equal("Blue", andysBike.Color);
            Assert.Equal(0, andysBike.MilesDriven);

            var expected = "This Blue vehicle has 2 wheels and has driven 0 miles";
            Console.WriteLine(expected);
        }
       
       
        ////////////////////////////////////////////////////////////////////////
        
        [Fact]
        public void Drive_AddsMilesToVehicle()
        {
            Vehicle andysBike = new Vehicle(2, "Blue");

            Assert.Equal(0, andysBike.MilesDriven);

            andysBike.Drive();

            Assert.Equal(5, andysBike.MilesDriven);

            var expected = (5, andysBike.MilesDriven);
        }

        ////////////////////////////////////////////////////////////////////////

        [Fact]
        public void Paint_ChangesColorOfVehicle()
        {
            Vehicle andysBike = new Vehicle(2, "Blue");

            Assert.Equal("Blue", andysBike.Color);

            andysBike.Paint();

            var newColor = "Red";

            Assert.Equal("Red", andysBike.newColor);


        }
    }
}

