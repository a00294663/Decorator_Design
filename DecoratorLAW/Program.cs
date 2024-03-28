 class Program
    {
        static void Main(string[] args)
        {
            // Create ConcreteComponent
            IComponent<string> component = new ConcreteComponent();

            // Create decorators
            IComponent<string> plainDecorator = new PlainDecorator(component);
            IComponent<string> upperCaseDecorator = new UpperCaseDecorator(component);
            IComponent<string> colorDecorator = new ColorDecorator(component);

            // Test decorators
            Console.WriteLine("Plain Decorator: " + plainDecorator.GetText());
            Console.WriteLine("Upper Case Decorator: " + upperCaseDecorator.GetText());
            Console.WriteLine("Color Decorator: " + colorDecorator.GetText());
        }
    }