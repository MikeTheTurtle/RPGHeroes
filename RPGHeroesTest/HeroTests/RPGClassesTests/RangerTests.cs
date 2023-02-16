using RPGHeroes.Hero;
using RPGHeroes.Hero.RPG_Classes;

namespace RPGHeroesTest.HeroTests.RPGClassesTests
{
    public class RangerTests
    {
        [Fact]
        public void When_CreatingNewRanger_Expect_CorrectName()
        {
            //Arrange
            string expectedName = "Valgar";
            var hero = new Ranger(expectedName);

            //Act
            string actualName = hero.HeroName;

            //Assert
            Assert.Equal(expectedName, actualName);
        }

        [Fact]
        public void When_CreatingNewRanger_Expect_CorrectLevel()
        {
            //Arrange
            var hero = new Ranger("Valgar");
            int expectedLevel = 1;

            //Act
            int actualLevel = hero.HeroLevel;

            //Assert
            Assert.Equal(expectedLevel, actualLevel);
        }

        [Fact]
        public void When_CreatingNewRanger_Expect_CorrectAttributes()
        {
            //Arrange
            var hero = new Ranger("Valgar");
            HeroAttribute expectedAttributes = new(1, 7, 1, 1, 5, 1);

            //Act
            HeroAttribute actualAttributes = hero.HeroLevelAttributes;

            //Assert
            Assert.Equivalent(expectedAttributes, actualAttributes);
        }

        [Fact]
        public void When_GainingOneLevel_Expect_CorrectAttributeIncreases()
        {
            //Arrange
            var hero = new Ranger("Val");
            HeroAttribute levelOneAttributes = hero.HeroLevelAttributes;
            HeroAttribute expectedLevelTwoAttributes = new(levelOneAttributes.Strength + 1, levelOneAttributes.Dexterity + 5, levelOneAttributes.Intelligence + 1, 1, 5, 1);

            //Act
            hero.LevelUp();
            HeroAttribute actualLevelTwoAttributes = hero.HeroLevelAttributes;

            //Assert
            Assert.Equivalent(expectedLevelTwoAttributes, actualLevelTwoAttributes);
        }

        [Fact]
        public void When_DisplayingRangerInformation_Expect_CorrectName()
        {
            //Arrange
            var hero = new Ranger("Val");
            string expectedState = "Hero Name: " + hero.HeroName + "\n"
                + "Hero Class: " + hero.HeroClass + "\n"
                + "Hero Level: " + hero.HeroLevel + "\n"
                + "Total Strength: " + hero.CalculateTotalAttributes().Strength + "\n"
                + "Total Dexterity: " + hero.CalculateTotalAttributes().Dexterity + "\n"
                + "Total Intelligence: " + hero.CalculateTotalAttributes().Intelligence + "\n"
                + "Weapon Damage: " + hero.CalculateDamage();

            //Act
            string actualName = hero.DisplayHeroDetails();

            //Assert
            Assert.Equal(expectedState, actualName);
        }
    }
}