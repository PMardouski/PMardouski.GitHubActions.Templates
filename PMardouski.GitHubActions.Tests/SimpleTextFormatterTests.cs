using FluentAssertions;

namespace PMardouski.GitHubActions.Tests;

public class SimpleTextFormatterTests
{
    private ISimpleTextFormatter underTest = null!;

    [Fact]
    public void Format_WhenInputParameterIsNullOrEmpty_ShouldThrowException()
    {
        // Arrange
        underTest = new SimpleTextFormatter();

        // Act
        Action act = () => underTest.Format(null!);

        // Assert
        act.Should().Throw<ArgumentNullException>().WithMessage("Value cannot be null. (Parameter 'text')");
    }

    [Fact]
    public void Format_WhenInputParameterCorrect_ShouldReturnsExpectedResult()
    {
        // Arrange
        underTest = new SimpleTextFormatter();
        var expected = "My Message!";

        // Act
        var result = underTest.Format("My Message!");

        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}