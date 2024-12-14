namespace Cosikcosik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tab = Generuj(10);
            var tab1 = tab.Where(e => e > 50).ToArray();
            label1.Text = Wypisz(tab);

            tab1 = tab1.OrderBy(x => x).ToArray();
            label2.Text = Wypisz(tab1);
        }

        int[] Generuj(int Length)
        {
            int[] tab = new int[Length];
            Random rnd = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < Length; i++)
            {
                tab[i] = rnd.Next(0, 100);
            }
            return tab;
        }
        string Wypisz(int[] tab)
        {
            var wynik = "";
            for (int i = 0; i < tab.Length; i++)
            {
                wynik += tab[i].ToString() + " ";
            }
            return wynik;
        }
    }
}