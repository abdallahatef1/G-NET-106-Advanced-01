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






}

