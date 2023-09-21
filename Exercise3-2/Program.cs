namespace Exercise3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<UserError> userErrors = new List<UserError>();

            userErrors.Add(new NumericInputError());
            userErrors.Add(new TextInputError());
            userErrors.Add(new DivideByZero());
            userErrors.Add(new FileNotFound());
            userErrors.Add(new CanNotReadFile());
            userErrors.Add(new CanNotWriteFile());
            userErrors.Add(new DirectoryNotFound());

            foreach (var error in userErrors)
                Console.WriteLine(error.UEMessage());
        }       
    }
}