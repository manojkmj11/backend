namespace api_example
{
    public class IceCream
    {
        public string User { get; set; } = String.Empty;

        public string Name => User.Equals("Nikitha", StringComparison.OrdinalIgnoreCase) ? "Rich Chocolate" : String.Empty;

        public string Price => User.Equals("Nikitha", StringComparison.OrdinalIgnoreCase) ? "Free!" : "99.99rs.";

        public string Summary => User.Equals("Nikitha", StringComparison.OrdinalIgnoreCase) ? "Already paid!" : String.Empty;
    }
}
