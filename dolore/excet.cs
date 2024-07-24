public class Options {
    public string Fieldvar { get; set; }

    public Options(string fieldvar) {
        this.Fieldvar = fieldvar;
    }
}

public class Program {
    public static void Main() {
        Options opt = new Options("some value");
        string fieldvar = opt.Fieldvar;
        Console.WriteLine(fieldvar);  // Output: "some value"
    }
}
