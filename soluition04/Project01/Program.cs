namespace Project01
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Compilation Type Error
            int say(int x, int y)
            {
                return x + y;
            }

            say(45);

            #endregion

        }
    }
}
