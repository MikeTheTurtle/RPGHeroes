using RPGHeroes.Hero;
using RPGHeroes.Hero.RPG_Classes;

namespace RPGHeroesTest.HeroTests.RPGClassesTests
{
    public class WarriorTests
    {
        [Fact]
        public void When_CreatingNewWarrior_Expect_CorrectName()
        {
            //Arrange
            string expectedName = "Maddie";
            var hero = new Warrior(expectedName);

            //Act
            string actualName = hero.HeroName;

            //Assert
            Assert.Equal(expectedName, actualName);
        }

        [Fact]
        public void When_CreatingNewWarrior_Expect_CorrectLevel()
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
        public void When_CreatingNewWarrior_Expect_CorrectAttributes()
        {
            //Arrange
            var hero = new Warrior("Maddie");
            HeroAttribute expectedAttributes = new(5, 2, 1, 3, 2, 1);

            //Act
            HeroAttribute actualAttributes = hero.HeroLevelAttributes;

            //Assert
            Assert.Equivalent(expectedAttributes, actualAttributes);
        }

        [Fact]
        public void When_GainingOneLevel_Expect_CorrectAttributeIncreases()
        {
            //Arrange
            var hero = new Warrior("Maddie");
            HeroAttribute levelOneAttributes = hero.HeroLevelAttributes;
            HeroAttribute expectedLevelTwoAttributes = new(levelOneAttributes.Strength + 3, levelOneAttributes.Dexterity + 2, levelOneAttributes.Intelligence + 1, 3, 2, 1);

            //Act
            hero.LevelUp();
            HeroAttribute actualLevelTwoAttributes = hero.HeroLevelAttributes;

            //Assert
            Assert.Equivalent(expectedLevelTwoAttributes, actualLevelTwoAttributes);
        }

        [Fact]
        public void When_DisplayingWarriorInformation_Expect_CorrectName()
        {
            //Arrange
            var hero = new Warrior("Maddie");
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