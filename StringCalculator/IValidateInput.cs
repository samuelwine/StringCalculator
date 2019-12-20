namespace StringCalculator
{
    public interface IValidateInput
    {
        bool EmptyStringInput(string input);

        string RemoveTrailingCommas(string input);
    }
}