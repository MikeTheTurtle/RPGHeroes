﻿using RPGHeroes.Hero;
using RPGHeroes.Hero.RPG_Classes;

namespace RPGHeroesTest.HeroTests.RPGClassesTests
{
    public class RogueTests
    {
        [Fact]
        public void When_CreatingNewRogue_Expect_CorrectName()
        {
            //Arrange
            string expectedName = "Tyson";
            var hero = new Rogue(expectedName);

            //Act
            string actualName = hero.HeroName;

            //Assert
            Assert.Equal(expectedName, actualName);
        }

        [Fact]
        public void When_CreatingNewRogue_Expect_CorrectLevel()
        {
            //Arrange
            var hero = new Rogue("Tyson");
            int expectedLevel = 1;

            //Act
            int actualLevel = hero.HeroLevel;

            //Assert
            Assert.Equal(expectedLevel, actualLevel);
        }

        [Fact]
        public void When_CreatingNewRogue_Expect_CorrectAttributes()
        {
            //Arrange
            var hero = new Rogue("Tyson");
            HeroAttribute expectedAttributes = new(2, 6, 1, 1, 4, 1);

            //Act
            HeroAttribute actualAttributes = hero.HeroLevelAttributes;

            //Assert
            Assert.Equivalent(expectedAttributes, actualAttributes);
        }

        [Fact]
        public void When_GainingOneLevel_Expect_CorrectAttributeIncreases()
        {
            //Arrange
            var hero = new Rogue("Tyson");
            HeroAttribute levelOneAttributes = hero.HeroLevelAttributes;
            HeroAttribute expectedLevelTwoAttributes = new(levelOneAttributes.Strength + 1, levelOneAttributes.Dexterity + 4, levelOneAttributes.Intelligence + 1, 1, 4, 1);

            //Act
            hero.LevelUp();
            HeroAttribute actualLevelTwoAttributes = hero.HeroLevelAttributes;

            //Assert
            Assert.Equivalent(expectedLevelTwoAttributes, actualLevelTwoAttributes);
        }

        [Fact]
        public void When_DisplayingHeroInformation_Expect_CorrectName()
        {
            //Arrange
            var hero = new Rogue("Tyson");
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