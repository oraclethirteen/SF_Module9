using System;

namespace SF_Module9
{
    class Program
    {
        /* (V - VI) [9.3.2 - 9.3.3]
        public delegate int SubtractDelegate(int a, int b);
        */

        /* (VII - VIII) [9.3.4 - 9.3.5]
        public delegate void SumSubtractDelegate(int a, int b);
        */

        /* (IX - X) [9.3.7 - 9.3.8]
        delegate void ShowMessageDelegate();
        delegate int SumDelegate(int a, int b, int c);
        delegate bool CheckLengthDelegate(string _row);
        */

        /* (XI, XIII) [9.3.12, 9.3.14]
        delegate void ShowMessageDelegate(string _message);
        */

        /* (XII, XIV) [9.3.13, 9.3.15]
        delegate int RandomNumberDelegate();
        */

        /* (XV) [9.4.2]
        public delegate Car HandlerMethod();

        public static Car CarHandler()
        {
            return null;
        }

        public static Lexus LexusHandler()
        {
            return null;
        }
        */

        /* (XVI) [9.4.3]
        public delegate Parent HandlerMethod();

        delegate void ChildInfo(Child child);

        public static Parent PaarentHandler()
        {
            return null;
        }

        public static Child ChildHandler()
        {
            return null;
        }

        public static void GetParentInfo(Parent p)
        {
            Console.WriteLine(p.GetType());
        }
        */

        static void Main(string[] args)
        {
            /*(I -II) [9.1.3 - 9.1.4]
            Exception exception = new Exception();

            exception.Data.Add("Дата создания исключения: ", DateTime.Now);

            exception.HelpLink = "www.google.com";
            */

            /* (III) [9.2.2]
            try
            {
                throw new ArgumentOutOfRangeException("Сообщение об ошибке");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);   
            }
            finally
            {
                Console.Read();
            }
            */

            /* (IV) [9.2.3]
            try
            {
                throw new RankException("Сообщение об ошибке");
            }
            catch (RankException ex)
            {
                Console.WriteLine(ex.GetType());
            }
            finally
            {
                Console.Read();
            }
            */

            /* (V - VI) [9.3.2 - 9.3.3]
            SubtractDelegate subtractDelegate = Subtract;

            int resultOne = subtractDelegate.Invoke(1, 10);
            int resultTwo = subtractDelegate(1, 10);

            Console.WriteLine(resultOne);
            Console.WriteLine(resultTwo);

            Console.Read();
            */

            /* (VII - VIII) [9.3.4 - 9.3.5]
            SumSubtractDelegate sumSubtractDelegate = Subtract;
            sumSubtractDelegate += Sum;
            sumSubtractDelegate -= Sum;

            sumSubtractDelegate.Invoke(1, 10);

            Console.Read();
            */

            /* (IX) [9.3.7]
            ShowMessageDelegate showMessageDelegate = ShowMessage;
            showMessageDelegate.Invoke();

            SumDelegate sumDelegate = Sum;
            int result = sumDelegate.Invoke(1, 30, 120);
            Console.WriteLine(result);

            CheckLengthDelegate checkLengthDelegate = CheckLength;
            bool status = checkLengthDelegate.Invoke("skill_factory");
            Console.WriteLine(status);

            Console.Read();
            */

            /* (X) [9.3.8]
            Action<string> action = new Action<string>(ShowMessage);
            action("Hello World!");

            Func<int, int, int, int> sumDelegate = Sum;
            int result = sumDelegate.Invoke(1, 30, 120);
            Console.WriteLine(result);

            Predicate<string> checkLengthDelegate = CheckLength;
            bool status = checkLengthDelegate("skill_factory");
            if (status)
                Console.WriteLine("SkillFactory");

            Console.ReadLine();
            */

            /* (XI, XIII) [9.3.12, 9.3.14]
            ShowMessageDelegate showMessageDelegate1 = delegate (string _message)
            {
                Console.WriteLine(_message);
            };

            showMessageDelegate1.Invoke("Hello World!");

            ShowMessageDelegate showMessageDelegate2 = (string _message) =>
            {
                Console.WriteLine(_message);
            };

            showMessageDelegate2.Invoke("Hello World!");

            Console.Read();
            */

            /* (XII, XIV) [9.3.13, 9.3.15]
            RandomNumberDelegate randomNumberDelegate1 = delegate
            {
                return new Random().Next(0, 100);
            };

            int result1 = randomNumberDelegate1.Invoke();

            Console.WriteLine(result1);

            RandomNumberDelegate randomNumberDelegate2 = () =>
            {
                return new Random().Next(0, 100);
            };

            int result2 = randomNumberDelegate2.Invoke();

            Console.WriteLine(result2);

            Console.Read();
            */

            /* (XV) [9.4.2]
            HandlerMethod handlerLexus = LexusHandler;

            Console.Read();
            */

            /* (XVI) [9.4.3]
            ChildInfo childInfo = GetParentInfo;

            childInfo.Invoke(new Child());

            Console.Read();
            */
        }

        /* (V - VI) [9.3.2 - 9.3.3]
        static int Subtract(int a, int b)
        {
            return a - b;
        }
        */

        /* (VII - VIII) [9.3.4 - 9.3.5]
        static void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        */

        /* (IX - X) [9.3.7 - 9.3.8]
        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        private static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        private static bool CheckLength(string _row)
        {
            if (_row.Length > 3) return true;
            return false;
        }
        */

        /* (XI) [9.3.12]
        static void ShowMessage(string _message)
        {
            Console.WriteLine(_message);
        }
        */

        /* (XII) [9.3.13]
        static int RandomNumber()
        {
            return new Random().Next(0, 100);
        }
        */
    }

    /* (XV) [9.4.2]
    class Car { }
    class Lexus : Car { }
    */

    /* (XVI) [9.4.3]
    class Parent { }
    class Child : Parent { }
    */
}
