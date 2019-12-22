namespace StringCalculator
{
    public interface IValidateInput
    {
        bool EmptyStringInput(string input);

        string RemoveTrailingSeperator(string input, string seperator);
    }
}