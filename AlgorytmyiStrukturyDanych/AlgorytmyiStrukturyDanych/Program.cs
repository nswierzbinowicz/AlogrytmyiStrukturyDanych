namespace AlgorytmyiStrukturyDanych
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            //MergeSort(Tab, p punkt pocz¹tkowy,r punkt koñcowy)
            //if p < r (punkt pocz¹tkowy mniejszy od punktu koñcowego)
            //q = (p+r)/2
            //MergeSort(T,p,q)
            //MergeSort(T,q+1,r)
            //SCAL(T,p,q,r)
            //quicksort
        }
    }
}