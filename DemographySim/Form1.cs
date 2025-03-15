using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace DemographySim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<ProbabilityOfDeath> pDeaths = new List<ProbabilityOfDeath>();

            StreamReader sr2 = new StreamReader("c:/temp/mortality.csv", Encoding.Default);
            sr2.ReadLine();
            while (!sr2.EndOfStream)
            {
                string line = sr2.ReadLine();
                string[] strings = line.Split(";");

                ProbabilityOfDeath d = new ProbabilityOfDeath();
                d.PDeath = double.Parse(strings[2]);
                d.Age = byte.Parse(strings[1]);
                d.Sex = (Sex)byte.Parse(strings[0]);
                pDeaths.Add(d);
            }
            sr2.Close();
            DataGridView3.DataSource = pDeaths; 

            List<ProbabilityOfBirth> pBirth = new List<ProbabilityOfBirth>();

            StreamReader sr1 = new StreamReader("c:/temp/fertality.csv");
            sr1.ReadLine();
            while (!sr1.EndOfStream)
            {
                string line = sr1.ReadLine();
                string[] strings = line.Split(";");

                ProbabilityOfBirth p = new ProbabilityOfBirth();
                p.Age = byte.Parse(strings[0]);
                p.NumberOfChildren = byte.Parse(strings[2]);
                p.PBirth = double.Parse(strings[3]);


                pBirth.Add(p);
            }


            sr1.Close();

            dataGridView2.DataSource = pBirth;


            List<Individual> individuals = new List<Individual>();

            DateTime start = DateTime.Now;

            StreamReader sr = new StreamReader("c:/temp/census.csv");

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] strings = line.Split(";");

                Individual individual = new Individual();
                individual.YearOfBirth = int.Parse(strings[0]);
                individual.Sex = (Sex)int.Parse(strings[1]);
                individual.NumberOfChildren = byte.Parse(strings[2]);
                individuals.Add(individual);
            }

            sr.Close();
            DateTime end = DateTime.Now;
            dataGridView1.DataSource = individuals;

            MessageBox.Show((end - start).ToString());
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}