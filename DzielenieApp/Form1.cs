using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace DzielenieApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDzielenie_Click(object sender, EventArgs e)
        {
            try
            {
                double dzielna = double.Parse(textBoxDzielna.Text);
                double dzielnik = double.Parse(textBoxDzielnik.Text);

                if (dzielnik == 0)
                {
                    throw new DivideByZeroException("Dzielnik nie może być zerem.");
                }

                double wynik = dzielna / dzielnik;
                textBoxWynik.Text = wynik.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Wprowadź prawidłowe liczby.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogError(ex);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("Dzielnik nie może być zerem.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogError(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogError(ex);
            }
        }

        private void LogError(Exception ex)
        {
            if (!EventLog.SourceExists("DzielenieApp"))
            {
                EventLog.CreateEventSource("DzielenieApp", "Application");
            }
            EventLog.WriteEntry("DzielenieApp", ex.ToString(), EventLogEntryType.Error);
        }
    }
}
