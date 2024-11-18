using System.Collections;

namespace GenericDemo
{
    internal class Program2
    {
        static void Main2(string[] args)
        {
            // het leven vooraf aan generics

            var getallen = new ArrayList();
            getallen.Add(4);
            getallen.Add(8);
            getallen.Add(15);
            //getallen.Add("hoi");

            foreach (var getal in getallen)
            {
                var echtGetal = (int)getal;
                Console.WriteLine(echtGetal * 2);
            }

            // het leven sinds generics
            var nogMeerGetallen = new List<int>();
            nogMeerGetallen.Add(4);
            nogMeerGetallen.Add(8);
            nogMeerGetallen.Add(15);
            //nogMeerGetallen.Add("hoi");

            foreach (var getal in nogMeerGetallen)
            {
                Console.WriteLine(getal * 2);
            }

        }
    }
}
