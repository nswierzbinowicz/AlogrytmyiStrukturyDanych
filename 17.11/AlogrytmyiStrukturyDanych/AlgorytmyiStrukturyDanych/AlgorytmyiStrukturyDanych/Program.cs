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

            //MergeSort(Tab, p punkt pocz�tkowy,r punkt ko�cowy)
            //if p < r (punkt pocz�tkowy mniejszy od punktu ko�cowego)
            //q = (p+r)/2
            //MergeSort(T,p,q)
            //MergeSort(T,q+1,r)
            //SCAL(T,p,q,r)
            //quicksort
        }
    }
}