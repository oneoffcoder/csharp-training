namespace Coder.Model {
    public class Human {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Human(string firstName, string lastName) {
            FirstName = firstName;
            LastName = lastName;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.FirstName, this.LastName);
        }

        public override bool Equals(object? obj)
        {
            if (obj is null || obj.GetType() != typeof(Human)) {
                return false;
            }

            var that = (Human) obj;
            return this.FirstName.Equals(that.FirstName) &&
                this.LastName.Equals(that.LastName);
        }

        public override string ToString() {
            return $"{this.FirstName} {this.LastName}";
        }
    }

    public record Pet(string Name, string Sound);
}