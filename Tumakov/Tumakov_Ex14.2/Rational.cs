
namespace Tumakov
{
    [DeveloperInfo("Иван Марков", "2024.1.22")]
    [DeveloperInfo("Стёпа Петров","2024.1.21")]
    class Rational
    {
        private int Numerator;   
        private int Denominator; 

        public Rational(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new Exception("Знаменатель не может быть равен нулю.");
            }
            else
            {
                Numerator = numerator;
                Denominator = denominator;
            }
        }

        public static bool operator ==(Rational a, Rational b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Rational a, Rational b)
        {
            return !a.Equals(b);
        }

        public static bool operator <(Rational a, Rational b)
        {
            return (float)a < (float)b;
        }

        public static bool operator >(Rational a, Rational b)
        {
            return (float)a > (float)b;
        }

        public static bool operator <=(Rational a, Rational b)
        {
            return (float)a <= (float)b;
        }

        public static bool operator >=(Rational a, Rational b)
        {
            return (float)a >= (float)b;
        }

        // Операторы арифметики
        public static Rational operator +(Rational a, Rational b)
        {
            return new Rational(
                a.Numerator * b.Denominator + b.Numerator * a.Denominator,
                a.Denominator * b.Denominator
            );
        }

        public static Rational operator -(Rational a, Rational b)
        {
            return new Rational(
                a.Numerator * b.Denominator - b.Numerator * a.Denominator,
                a.Denominator * b.Denominator
            );
        }

        public static Rational operator *(Rational a, Rational b)
        {
            return new Rational(a.Numerator * b.Numerator, a.Denominator * b.Denominator);
        }

        public static Rational operator /(Rational a, Rational b)
        {
            if (b.Numerator == 0)
            {
                throw new Exception("Деление на ноль.");
            }
            return new Rational(a.Numerator * b.Denominator, a.Denominator * b.Numerator);
        }

        public static Rational operator %(Rational a, Rational b)
        {
            var div = a / b;
            return a - (new Rational(div.Numerator / div.Denominator, 1) * b);
        }

        public static explicit operator int(Rational r)
        {
            return r.Numerator / r.Denominator;
        }

        public static explicit operator float(Rational r)
        {
            return (float)r.Numerator / r.Denominator;
        }

        public static explicit operator Rational(int value)
        {
            return new Rational(value, 1);
        }

        public static explicit operator Rational(float value)
        {
            int denominator = 1000000;
            int numerator = (int)(value * denominator);
            return new Rational(numerator, denominator);
        }

        public static Rational operator ++(Rational r)
        {
            return new Rational(r.Numerator + r.Denominator, r.Denominator);
        }

        public static Rational operator --(Rational r)
        {
            return new Rational(r.Numerator - r.Denominator, r.Denominator);
        }

        public override bool Equals(object obj)
        {
            if (obj is Rational other)
            {
                return Numerator == other.Numerator && Denominator == other.Denominator;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Numerator, Denominator);
        }

        public override string ToString()
        {
            return Denominator == 1 ? $"{Numerator}" : $"{Numerator}/{Denominator}";
        }
    }
}
