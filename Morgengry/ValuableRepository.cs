using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Morgengry
{
    public class ValuableRepository : IPersistable
    {
        List<IValuable> valuables = new List<IValuable>();

        public void AddValuable(IValuable valuable)
        {
            valuables.Add(valuable);
        }
        public IValuable GetValuable(string Id)
        {
            foreach(IValuable valuable in valuables)
            {
                if(valuable.ItemId == Id)
                {
                    return valuable;
                }
            }
            return null;
        }
        public double GetTotalValue()
        {
            double value = 0.0;
            foreach(IValuable valuable in valuables)
            {
                value += valuable.GetValue();
            }
            return value;
        }
        public int Count()
        {
            return valuables.Count;
        }
        
        //IMPLEMENT CODE BELOW
        public void Save()
        {
            ValuableRepository v = new ValuableRepository();
            StreamWriter sr = new StreamWriter("TestFile01.txt", false);
            sr.WriteLine(v);
            sr.Close();
        }

        public void Save(string filename)
        {
            
        }

        public void Load()
        {
            throw new NotImplementedException();
        }

        public void Load(string filename)
        {
            StreamReader read = new StreamReader("TestFile01.txt");
            while (read.EndOfStream == false)
            {
                string lines = read.ReadLine();
                Console.WriteLine(lines);
            }
            read.Close();
        }
    }
}
