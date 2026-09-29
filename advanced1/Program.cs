namespace advanced1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1: What is a generic class? Why use generics?
            //A generic class takes one or more type parameters like: <T> that are specified when you use it.
            // Type safety , Reusability , Performance

            #endregion

            #region q2 
            Console.WriteLine("--- Q2: Container<T> ---");
            Container<string> c = new Container<string>();
            c.Add("Hello");
            c.Add("World");
            Console.WriteLine(c.Get(0) + " " + c.Get(1));

            #endregion
            #region q3
            Console.WriteLine("--- Q3: Pair<TKey,TValue> ---");
            Pair<string, int> p = new Pair<string, int>("Age", 30);
            Console.WriteLine(p.Key + " = " + p.Value);
            #endregion
            #region q4
            Console.WriteLine("--- Q4: Swap<T> ---");
            int x = 1, y = 2;
            Swap(ref x, ref y);
            Console.WriteLine("x=" + x + ", y=" + y);

            #endregion
            #region q5
            Console.WriteLine("--- Q5: FindMax<T> ---");
            Console.WriteLine(FindMax(new int[] { 3, 9, 2, 7 }));
            Console.WriteLine(FindMax(new string[] { "apple", "pear", "banana" }));

            #endregion
            #region q7
            Console.WriteLine("--- Q7: struct constraint ---");
            StructWrapper<int> sw = new StructWrapper<int>();
            sw.Value = 42;
            Console.WriteLine(sw.Value);
            #endregion
            #region q8
            Console.WriteLine("--- Q8: class constraint ---");
            ClassWrapper<string> cw = new ClassWrapper<string>();
            cw.Item = "I am a reference type";
            Console.WriteLine(cw.Item);
            #endregion
            #region q9
            Console.WriteLine("--- Q9: new() constraint ---");
            List<int> newList = Create<List<int>>();
            Console.WriteLine("Created list, count = " + newList.Count);

            #endregion
            #region q10
            Console.WriteLine("--- Q10: interface constraint ---");
            List<IShape> shapes = new List<IShape> { new Circle(1), new Square(2) };
            Console.WriteLine("Total area: " + TotalArea(shapes));
            #endregion
            #region q11
            Console.WriteLine("--- Q11: base class constraint ---");
            MakeSound(new Dog());
            MakeSound(new Animal());

            #endregion
            #region q12
            Console.WriteLine("--- Q12: multiple constraints ---");
            Factory<Dog> f = new Factory<Dog>();
            Dog d = f.Build();
            Console.WriteLine(d.Speak());
            d.play();
            #endregion
            #region q20
            Console.WriteLine("--- Q20: Cache<TKey,TValue> ---");
            Cache<string, int> cache = new Cache<string, int>(TimeSpan.FromSeconds(1));
            cache.Add("a", 100);
            Console.WriteLine("Contains a: " + cache.Contains("a"));
            Console.WriteLine("Get a: " + cache.Get("a"));
            Thread.Sleep(1500);
            Console.WriteLine("After 1s, contains a: " + cache.Contains("a"));
            cache.Add("b", 200);
            cache.Remove("b");
            Console.WriteLine("After Remove, contains b: " + cache.Contains("b"));

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
            #endregion





        }
        #region Q4:What is a generic method? Write Swap<T> method.

        //A generic method has its own type parameter, and the compiler usually infers it.
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        #endregion

        #region Q5:Write a generic method FindMax<T> that finds maximum value

        static T FindMax<T>(T[] items) where T : IComparable<T>
        {
            T max = items[0];
            foreach (T item in items)
            {
                if (item.CompareTo(max) > 0)
                    max = item;
            }
            return max;
        }
        #endregion

        #region Q9:What is the 'new()' constraint? Write an example.
        //The new() constraint specifies that the generic type T must have a public parameterless constructor.
        static T Create<T>() where T : new()
        {
            return new T();
        }

        #endregion

        #region Q10:What is the interface constraint? Write an example.
        // The interface constraint specifies that the generic type T must implement a specific interface.
        static double TotalArea<T>(List<T> shapes) where T : IShape
        {
            return shapes.Sum(s => s.Area());
        }


        #endregion

        #region Q11: What is the base class constraint? Write an example.
        //The base class constraint specifies that the generic type T must inherit from a specific base class.
        static void MakeSound<T>(T animal) where T : Animal
        {
            Console.WriteLine(animal.Speak());
        }


        #endregion

        #region Q12: How do you apply multiple constraints? Write an example. 
        //We can apply multiple constraints to a generic type by using where T : followed by the constraints separated by commas.

        #endregion

        #region  Q13:What does the 'default' keyword do in generics?

        //The default keyword returns the default value of the generic type T.
        #endregion

        #region Q15:What is covariance? Explain the 'out' keyword. 
        //Covariance allows you to use a more specific type where a more general type is expected The out keyword is used to make a generic interface covariant.
        //interface IProducer<out T>
        //{
        //    T Get();
        }
        #endregion

    #region  Q16:What is contravariance? Explain the 'in' keyword.
    //Contravariance allows you to use a more general type where a more specific type is expected.The in keyword is used for contravariance.
    //interface IProducer<in T>
    //{
    //    void Use(T item);

    #endregion

    #region Q17: What is the difference between covariance and contravariance?
    /// Covariance                   Contravariance
    /// Uses out                        Uses in
    /// Used for return/output       Used for input/parameters


    #endregion

    #region Q18:How do static members work in generic types?
    //In a generic class, each type gets its own copy of static members.

    #endregion

    #region Q19:How can you inherit from a generic class?
    //A class can inherit from a generic class by specifying the type for T.
    #endregion






}

