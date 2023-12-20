namespace DungeonOfOOPProjectTest.MonstersLogic
{
    using DungeonOfOOPProject.Entities;
    using DungeonOfOOPProject.MonstersLogic;
    using Xunit;
    public class BloodElfBuilderTests
    {
        [Fact]
        public void Given_NewBloodElfBuilder_When_SetMonsterType_Then_CreatesBloodElfMonster()
        {
            // Arrange
            BloodElfBuilder builder = new BloodElfBuilder();

            // Act
            builder.SetMonsterType();
            Monster createdMonster = builder.GetMonster();

            // Assert
            Assert.Equal(MonsterType.BloodElf, createdMonster.Type);
        }

        [Fact]
        public void Given_NewBloodElfBuilder_When_SetDefaultValues_Then_CreatesMonsterWithDefaultValues()
        {
            // Arrange
            BloodElfBuilder builder = new BloodElfBuilder();

            // Act
            builder.SetMonsterType();
            builder.SetAppearance();
            builder.SetMessages();
            builder.SetAttackPower();
            builder.SetHealth();
            Monster createdMonster = builder.GetMonster();

            // Assert
            Assert.Equal("1", createdMonster.Appearance);
            Assert.Equal(5, createdMonster.AttackPower);
            Assert.Equal(100, createdMonster.Health);
            Assert.Collection(
                createdMonster.Messages,
                message => Assert.Equal("Poor player!", message),
                message => Assert.Equal("I will be your doom", message)
            );
        }

        [Fact]
        public void Given_BloodElfBuilder_When_OverrideAttackPowerAndHealth_Then_SetsCorrectValues()
        {
            // Arrange
            BloodElfBuilder builder = new BloodElfBuilder();

            // Act
            builder.SetMonsterType();
            builder.SetAttackPower(10);
            builder.SetHealth(150);
            Monster createdMonster = builder.GetMonster();

            // Assert
            Assert.Equal(10, createdMonster.AttackPower);
            Assert.Equal(150, createdMonster.Health);
        }
    }
}