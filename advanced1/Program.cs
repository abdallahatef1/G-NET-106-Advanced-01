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

            #region Q4:What is a generic method? Write Swap<T> method.

            //A generic method has its own type parameter, and the compiler usually infers it.
            static void Swap<T>(ref T a, ref T b)
            {
                T temp = a;
                a = b;
                b = temp;
            }
            #endregion



        }
    }
}
