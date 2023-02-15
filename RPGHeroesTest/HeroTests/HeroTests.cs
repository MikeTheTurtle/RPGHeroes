using RPGHeroes.Hero;
using RPGHeroes.Hero.RPG_Classes;

namespace RPGHeroesTest.HeroTests
{
    public class HeroTests
    {
        [Fact]
        public void When_CreatingNewHero_Expect_CorrectName()
        {
            //Arrange
            var hero = new Warrior("Maddie");
            string expectedName = "Maddie";

            //Act
            string actualName = hero.HeroName;

            //Assert
            Assert.Equal(expectedName, actualName);
        }

        [Fact]
        public void When_CreatingNewHero_Expect_CorrectLevel()
        {
            //Arrange
            var hero = new Warrior("Maddie");
            int expectedLevel = 1;

            //Act
            int actualLevel = hero.HeroLevel;

            //Assert
            Assert.Equal(expectedLevel, actualLevel);
        }

        [Fact]
        public void When_CreatingNewHero_Expect_CorrectAttributes()
        {
            //Arrange
            var hero = new Warrior("Maddie");
            HeroAttribute expectedAttributes = new(5, 2, 1, 3, 2, 1);

            //Act
            HeroAttribute actualAttributes = hero.HeroLevelAttributes;

            //Assert
            Assert.Equivalent(expectedAttributes, actualAttributes);
        }
    }
}