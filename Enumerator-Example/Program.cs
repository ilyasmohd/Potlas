using System.Collections;

namespace Enumerator_Example
{
    class Program
    {
		//https://support.microsoft.com/en-in/help/322022/how-to-make-a-visual-c-class-usable-in-a-foreach-statement
        static void Main(string[] args)
        {
            cars cars = new cars();
            foreach (car item in cars)
            {
                System.Console.WriteLine(item.Make + "-" + item.Year);
            }
        }
    }

    public class car
    {
        private int year;
        private string make;

        public car(string Make, int Year)
        {
            make = Make;
            year = Year;
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public string Make
        {
            get { return make; }
            set { make = value; }
        }
    }
    public class cars : IEnumerator, IEnumerable
    {
        private car[] carlist;
        int position = -1;

        //Create internal array in constructor.
        public cars()
        {
            carlist = new car[6]{
                 new car("Ford",1992),
                 new car("Fiat",1988),
                 new car("Buick",1932),
                 new car("Ford",1932),
                 new car("Dodge",1999),
                 new car("Honda",1977)
            };
        }

        //IEnumerator and IEnumerable require these methods.
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

        //IEnumerator
        public bool MoveNext()
        {
            position++;
            return (position < carlist.Length);
        }

        //IEnumerable
        public void Reset()
        {
            position = 0;
        }

        //IEnumerable
        public object Current
        {
            get { return carlist[position]; }
        }
    }
}
