class Calculator
{
    private List<string> history = new List<string>();
    private const string HistoryFile = "calculator_history.txt";

    public Calculator()
    {
        LoadHistory();
    }

    // Basic operations
    public double Add(double a, double b) => SaveOperation(a, "+", b, a + b);
    public double Subtract(double a, double b) => SaveOperation(a, "-", b, a - b);
    public double Multiply(double a, double b) => SaveOperation(a, "*", b, a * b);

    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return double.NaN;
        }

        return SaveOperation(a, "/", b, a / b);
    }

    private double SaveOperation(double a, string op, double b, double result)
    {
        string record = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} | {a} {op} {b} = {result}";
        history.Add(record);
        return result;
    }

    // Display history
    public void DisplayHistory()
    {
        if (history.Count == 0)
        {
            Console.WriteLine("No calculation history found.");
            return;
        }

        Console.WriteLine($"\nHistory ({history.Count} records):");
        Console.WriteLine(new string('-', 50));

        foreach (var item in history)
            Console.WriteLine(item);

        Console.WriteLine(new string('-', 50));
    }

    // Save history to file
    public void SaveHistory()
    {
        try
        {
            File.WriteAllLines(HistoryFile, history);
            Console.WriteLine($"History saved successfully ({history.Count} records).");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving history: {ex.Message}");
        }
    }

    // Load history from file
    private void LoadHistory()
    {
        try
        {
            if (File.Exists(HistoryFile))
            {
                string[] lines = File.ReadAllLines(HistoryFile);
                history = new List<string>(lines);

                Console.WriteLine($"Loaded {lines.Length} previous records.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading history: {ex.Message}");
        }
    }

    // Clear history
    public void ClearHistory()
    {
        history.Clear();

        if (File.Exists(HistoryFile))
            File.Delete(HistoryFile);

        Console.WriteLine("History cleared successfully.");
    }

    public int HistoryCount => history.Count;
}
