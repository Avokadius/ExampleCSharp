namespace ObjectEx.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj is Person other)
            {
                return other.Name == Name && other.Age == Age;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Age);
        }

        public static bool operator ==(Person a, Person b)
        {
            if (ReferenceEquals(a, b))
            {
                return true;
            }

            if (a is null || b is null)
            {
                return false;
            }

            return a.Equals(b);
        }

        public static bool operator !=(Person a, Person b)
        {
            return !(a == b);
        }

        // Перегрузка операторов > и <
        public static bool operator >(Person a, Person b)
        {
            if (a is null || b is null)
            {
                throw new ArgumentNullException("Один из объектов Person равен null.");
            }

            return a.Age > b.Age;
        }

        public static bool operator <(Person a, Person b)
        {
            if (a is null || b is null)
            {
                throw new ArgumentNullException("Один из объектов Person равен null.");
            }

            return a.Age < b.Age;
        }
    }
}