public class PlainDecorator : Decorator<string>
    {
        public PlainDecorator(IComponent<string> component) : base(component) { }

        public override string GetText()
        {
            return "Paschal means the resurrection of the Lord: " + base.GetText();
        }
    }