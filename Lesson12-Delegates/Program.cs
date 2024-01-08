using System;

namespace Module04.Lesson12
{

    // 1. This line defines a new delegate type
    // the type name is KeyPressDelegate
    // the signiture is void name(parameter) ie. void KeyPressDelegate(char key)
    public delegate void KeyPressDelegate(char key);
    public delegate void QuitDelegate();

    public class KeyStrokeHandler
    {

        // 2. this is where we define a new variable OF that delegate type
        //
        public KeyPressDelegate OnKey;
        public QuitDelegate OnQuit;

        public void Run()
        {
            Console.WriteLine("keystroke handler running, 'q' to quit");
            while (true)
            {
                var key = Console.ReadKey(true).KeyChar;

                // 3. if the delegate variable is NOT null, then invoke (run) the
                // method assigned to this variable
                //
                if (OnKey != null)
                    OnKey.Invoke(key);

                if (key != 'q') continue;

                /// call our OnQuit delegate
                ///
                if (OnQuit == null)
                    QuitingProgramDefault();
                else
                    OnQuit.Invoke();

                break;
            }
        }

        void QuitingProgramDefault()
        {
            Console.WriteLine("Default Quit code");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var keyHandler = new KeyStrokeHandler();

            // 4. here, we assign the delegate variable the Method to invoke
            //
            keyHandler.OnKey = KeyPressed;
            keyHandler.OnKey += SecondKeyPressed;
            keyHandler.OnKey += ThirdKeyPressed;
            keyHandler.OnKey -= SecondKeyPressed;

            keyHandler.OnQuit = QuitingProgram;


            keyHandler.Run();
        }


        // 5. This is the method that the delegate will invoke
        // notive, that it is the same signiture as the delegate type definition
        //
        static void KeyPressed(char key)
        {
            Console.WriteLine(key);
        }

        static void SecondKeyPressed(char key)
        {
            Console.WriteLine($"{key} was pressed");
        }

        static void ThirdKeyPressed(char key)
        {
            Console.WriteLine($"KEY pressed");
        }

        static void QuitingProgram()
        {
            Console.WriteLine("Program has ended");
        }
    }
}
