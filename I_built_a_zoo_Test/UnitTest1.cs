using Xunit;

namespace Lab_06_I_built_a_Zoo.Tests
{
    public class BearTests
    {
        [Fact]
        public void BearRunSpeed()
        {
            // Arrange
            Bear bear = new Bear("Polo", 9, 150, true);

            // Act
            string result = bear.Run();

            // Assert
            Assert.Equal(" Polo the bear can run with average speed 30m/h", result);
        }

        [Fact]
        public void BearEatFood()
        {
            // Arrange
            Bear bear = new Bear("Polo", 9, 150, true);

            // Act
            string result = bear.Eat();

            // Assert
            Assert.Equal("Polo eats Fish", result);
        }
        [Fact]
        public void TigerRunSpeed()
        {
            // Arrange
            Tiger tiger = new Tiger("Sharikhan", 5, 180, true);

            // Act
            string result = tiger.Run();

            // Assert
            Assert.Equal(" Sharikhan the tiger can run with average speed 40m/h", result);
        }

        [Fact]
        public void TigerEatFood()
        {
            // Arrange
            Tiger tiger = new Tiger("Sharikhan", 5, 180, true);

            // Act
            string result = tiger.Eat();

            // Assert
            Assert.Equal("Sharikhan eats meat", result);
        }
        [Fact]
        public void ElephantEatFood()
        {
            // Arrange
            Elephant elephant = new Elephant("Babar", 10, 4000, false);

            // Act
            string result = elephant.Eat();

            // Assert
            Assert.Equal("Babar eats herbs and trees", result);
        }

        [Fact]
        public void ElephantSleepHours()
        {
            // Arrange
            Elephant elephant = new Elephant("Babar", 10, 4000, false);

            // Act
            double result = elephant.Sleep();

            // Assert
            Assert.Equal(6, result);
        }
        [Fact]
        public void FalconEatFood()
        {
            // Arrange
            Falcon falcon = new Falcon("Hakeem", 5, 80, true, "Medium");

            // Act
            string result = falcon.Eat();

            // Assert
            Assert.Equal("Hakeem the Falcon eats meat specialy Rabbits", result);
        }

        [Fact]
        public void FalconFly()
        {
            // Arrange
            Falcon falcon = new Falcon("Hakeem", 5, 80, true, "Medium");

            // Act
            string result = falcon.Fly();

            // Assert
            Assert.Equal("Hakeem the Falcon can fly inside the cage", result);
        }
        [Fact]
        public void ParrotEat()
        {
            // Arrange
            Parrot parrot = new Parrot("Sparo", 3, 20, false, "Small");

            // Act
            string result = parrot.Eat();

            // Assert
            Assert.Equal("Sparo eats Cereals and fruits.", result);
        }

        [Fact]
        public void ParrotSpeak()
        {
            // Arrange
            Parrot parrot = new Parrot("Sparo", 3, 20, false, "Small");

            // Act
            string result = parrot.Speak();

            // Assert
            Assert.Equal("Sparo the Parrot in the Zoo can speak with people in English", result);
        }
    }
}
