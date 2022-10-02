namespace PMardouski.GitHubActions;
public class SimpleTextFormatter : ISimpleTextFormatter
{
    public string Format(string text)
    {
        if (string.IsNullOrEmpty(text))
            throw new ArgumentNullException(nameof(text));

        return text;
    }
}
