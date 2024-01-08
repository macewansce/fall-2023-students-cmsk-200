using System;
using System.Collections.Generic;

namespace Module2.Lesson09
{

    public class MagicHat<T> where T: IMagicHatItem
    {
        public List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public void Remove(T item)
        {
            items.Remove(item);
        }

        public string Name(T item)
        {
            return item.Name;
        }
    }

    public interface IMagicHatItem
    {
        int Id { get; set; }
        string Name { get; }
    }

    //class MagicHatItemBase : IMagicHatItem
    //{
    //    public virtual string Name => "BaseItem";
    //}

    class Sword : IMagicHatItem
    {
        public int Id { get; set; }
        public string Name => "Sword";
    }
    class Rabbit : IMagicHatItem
    {
        public int Id { get; set; }
        public string Name => "Rabbit";
    }

    class Program
    {
        static void Main(string[] args)
        {
            MagicHat<IMagicHatItem> magicHat = new MagicHat<IMagicHatItem>();
            magicHat.Add(new Sword());
            magicHat.Add(new Rabbit());

            foreach(IMagicHatItem item in magicHat.items)
            {
                Console.WriteLine(item.Name);
            }


        }



    }
}
