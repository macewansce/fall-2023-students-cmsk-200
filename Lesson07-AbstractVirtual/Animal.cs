namespace Module2.Lesson07
{
    public abstract class Animal
    {
        public abstract string Name();

        public int NumberOfLegs()
        {
            return 4;
        }

        public virtual string Speak()
        {
            return "grunt....";
        }
    }


    public class Dog : Animal
    {
        public override string Name()
        {
            return "Dog";
        }

        public override string Speak()
        {
            return "woof";
        }
    }


    public class Cat : Animal
    {
        public override string Name()
        {
            return "Cat";
        }


        public override string Speak()
        {
            return "meow";
        }

    }
}
