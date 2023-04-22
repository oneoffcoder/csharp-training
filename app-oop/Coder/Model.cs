namespace Coder.Model
{
    public class HumanClazz
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public HumanClazz(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.FirstName, this.LastName);
        }

        public override bool Equals(object? obj)
        {
            if (obj is null || obj.GetType() != typeof(HumanClazz))
            {
                return false;
            }

            var that = (HumanClazz)obj;
            return this.FirstName.Equals(that.FirstName) &&
                this.LastName.Equals(that.LastName);
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}";
        }
    }

    public struct HumanStruct {
        public string FirstName;
        public string LastName;

        public HumanStruct(string firstName, string lastName) {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }

    public record HumanRecord(string FirstName, string LastName);

    public record Pet(string Name, string Sound);
}