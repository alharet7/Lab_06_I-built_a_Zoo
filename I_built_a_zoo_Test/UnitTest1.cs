using System.Xml.Linq;
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
        // --------------------- Lab 07 Tests----------------------------------------------------------------
        [Fact]
        public void ParrotDoIAttackAndIPlay()
        {
            // Arrange
            Parrot parrot = new Parrot("Sparo", 2, 3, false, "small");
            // Assert
            Assert.IsAssignableFrom<IAttack>(parrot);
            Assert.IsAssignableFrom<IPlay>(parrot);
        }
        [Fact]
        public void BearDoIPlay()
        {
            // Arrange
            Bear bear = new Bear("Polo", 9, 150, true);
            // Assert
            Assert.IsAssignableFrom<IPlay>(bear);
        }
        [Fact]
        public void ElephantDoIAttack()
        {
            // Arrange
            Elephant elephant = new Elephant("Babar", 6, 300, false);
            // Assert
            Assert.IsAssignableFrom<IAttack>(elephant);
        }
        [Fact]
        public void TigerDoIAttack()
        {
            // Arrange
            Tiger tiger = new Tiger("Sharikhan", 7, 143, true);
            // Assert
            Assert.IsAssignableFrom<IAttack>(tiger);
        }
        [Fact]
        public void FalconDoIAttack()
        {
            // Arrange
            Falcon falcon = new Falcon("Hakeem", 3, 45.3, true, "meduim");
            // Assert
            Assert.IsAssignableFrom<IAttack>(falcon);
        }

        [Fact]
        public void InheritanceTest() //Test inheritance
        {
            // Arrange
            Tiger tiger = new Tiger("Sharikhan", 7, 143, true);
            // Assert
            // Test that the Tiger object has inherited the properties from the Mammal class
            Assert.Equal("Sharikhan", tiger.Name);
            Assert.Equal(7, tiger.Age);
            Assert.Equal(143, tiger.Weight);
            Assert.Equal(true, tiger.Predatory);

            // Test that the Tiger object has inherited the methods from the Animal class
            Assert.Equal("Sharikhan eats meat", tiger.Eat());
            Assert.Equal(7, tiger.Sleep());
        }
        [Fact]
        public void PolymorphismTest()
        {
            // Arrange
            Elephant elephant = new Elephant("Babar", 6, 300, false);
            // Assert
            Assert.Equal("Babar eats herbs and trees", elephant.Eat());
            Assert.Equal(6, elephant.Sleep());
        }
        [Fact]
        public void FalconIsAnimal() //concrete animals is an Animal
        {
            Falcon falcon = new Falcon("Hakeem", 3, 45.3, true, "meduim");

            Assert.IsAssignableFrom<Animal>(falcon);
        }

    }
}
