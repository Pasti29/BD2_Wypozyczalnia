using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using Pracownik.Database;
using System.Data.SqlClient;
using System.IO;
using System.Data.SqlTypes;

namespace Pracownik.Forms
{
    public partial class FormModyfikowanieKatalogu : Form
    {


        /// <summary>
        /// Wskaźnik na instancję klasy Repository
        /// </summary>
        private readonly Repository _repository = new Repository();


        public FormModyfikowanieKatalogu()
        {
            InitializeComponent();
        }



        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            using OpenFileDialog fileDialog = new OpenFileDialog()
            {
                Filter = "Image Files | *.jpg;*.png",
                Multiselect = false
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBoxAuto.Image = Image.FromFile(fileDialog.FileName);
                    SuccessMessage("Pomyślnie dodano zdjęcie!");
                }
                catch (OutOfMemoryException)
                {
                    // Przechwycenie wyjątku pojawiającego się, gdy dodawane zdjęcie jest za duże
                    FailureMessage("Wybrany obraz ma za duży rozmiar!");
                }
            }
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxRegistration.MaskCompleted) {

                DataRow? car = _repository.GetCar(maskedTextBoxRegistration.Text);    

                if (car == null)
                {
                    FailureMessage("Wprowadzona rejestracja nie istnieje!");
                }
                else {
                    SuccessMessage("Pomyślnie znaleziono auto!");

                    // Przejście do trybu modyfikacji
                    SwitchMode();

                    // Przypisanie wartości do etykiet
                    textBoxWorkerLogin.Text = car[1].ToString();
                    textBoxBrand.Text = car[2].ToString();
                    textBoxModel.Text = car[3].ToString();
                    //checkBoxBorrowed.Checked = (bool)car[4];
                    textBoxVintage.Text = car[4].ToString();
                    textBoxAverageConsumption.Text = car[5].ToString();
                    textBoxMaxSpeed.Text = car[6].ToString();
                    textBoxEngineCapacity.Text = car[7].ToString();
                    //maskedTextBoxControlDate.Text = ((DateTime)car[9]).ToString("dd-MM-yyyy");
                    maskedTextBoxControlDate.Text = ((DateTime)car[8]).ToString();

                    // Ustawienie obrazu
                    MemoryStream memoryStream = new MemoryStream((byte[])car[9]);
                    var image = Image.FromStream(memoryStream);
                    pictureBoxAuto.Image = image;
                }
            }
            else
            {
                FailureMessage("Pole rejestracji nie jest całkowicie wypełnione!");
            }
        }



        private void btnReturn_Click(object sender, EventArgs e)
        {
            SwitchMode();
            ClearAllData();
            labelStatus.Text = "Status: Porzucono zmiany!";
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckDataCorrectness())
            {
                _repository.UpdateCar(
                        maskedTextBoxRegistration.Text,
                        textBoxWorkerLogin.Text,
                        textBoxBrand.Text,
                        textBoxModel.Text,
                        //checkBoxBorrowed.Checked,
                        int.Parse(textBoxVintage.Text),
                        float.Parse(textBoxAverageConsumption.Text),
                        int.Parse(textBoxMaxSpeed.Text),
                        int.Parse(textBoxEngineCapacity.Text),
                        DateTime.Parse(maskedTextBoxControlDate.Text),
                        pictureBoxAuto.Image);

                SwitchMode();
                ClearAllData();
                SuccessMessage("Pomyślnie zaktualizowano!");
            }
        }



        private void ClearAllData() 
        {
            textBoxWorkerLogin.Text = "";
            textBoxBrand.Text = "";
            textBoxModel.Text = "";
            //checkBoxBorrowed.Checked = false;
            textBoxVintage.Text = "";
            textBoxAverageConsumption.Text = "";
            textBoxMaxSpeed.Text = "";
            textBoxEngineCapacity.Text = "";
            maskedTextBoxControlDate.Text = "";
            pictureBoxAuto.Image = null;
            SuccessMessage("Wprowadź rejestrację...");
        }



        private bool CheckDataCorrectness() 
        {
            int mistakes = 0;
            int emptyFields = 0;

            // Sprawdzanie poprawności ID pracownika
            if (textBoxWorkerLogin.Text == string.Empty)
            {
                emptyFields++;
            }
            else    
            {
                // Sprawdzamy, czy pracownik o danym id istnieje w bazie
                string workerLogin = textBoxWorkerLogin.Text;
                if (_repository.GetWorker(workerLogin) == null)
                {
                    SetStatusMessage("Wprowadzone login pracownika nie istnieje!");
                    mistakes++;
                }
            }

            // Sprawdzenie, czy pole marki i modelu nie jest puste
            if (textBoxBrand.Text == string.Empty) emptyFields++;

            if (textBoxModel.Text == string.Empty) emptyFields++;

            // Sprawdzenie poprawności rocznika
            if (textBoxVintage.Text == string.Empty)
            {
                emptyFields++;
            }
            else 
            {
                try
                {
                    int vintage = int.Parse(textBoxVintage.Text);
                    int currentYear = DateTime.Now.Year;

                    // Spawdzamy, czy rocznik mieści się przynajmniej w zakresie od <1886 currentYear>; 
                    if (vintage < 1886 || vintage > currentYear)
                    {
                        SetStatusMessage("Wprowadzono niepoprawny rocznik!");
                        mistakes++;
                    }
                }
                catch (FormatException)
                {
                    // Przechwycenie wyjątku - wprowadzenie innej wartości niż int
                    SetStatusMessage("Wprowadzony rocznik zawiera niedozwolone znaki!");
                    mistakes++;
                }
            }

            // Sprawdzenie poprawności średniego spalania
            if (textBoxAverageConsumption.Text == string.Empty)
            {
                emptyFields++;
            }
            else 
            {
                try
                {
                    float averageConsumption = float.Parse(textBoxAverageConsumption.Text);
                    // Zakładamy, że wartość ta musi być przynajmniej większa od 0
                    if (averageConsumption <= 0)
                    {
                        SetStatusMessage("Pole średnie spalanie zawiera niepoprawną wartość!");
                        mistakes++;
                    }

                }
                catch (FormatException){

                    // Przechwycenie wyjątku - wprowadzenie innej wartości niż float
                    SetStatusMessage("Pole średnie spalanie zawiera niedozwolone znaki!");
                    mistakes++;
                }
                
            }

            // Sprawdzanie poprawności prędkości maksymalnej
            if (textBoxMaxSpeed.Text == string.Empty)
            {
                emptyFields++;
            }
            else {
                try 
                {
                    int maxSpeed = int.Parse(textBoxMaxSpeed.Text);
                    // Zakładamy, że prędkość masymalna będzie się zawierać w przedziale od <0;600>
                    if (maxSpeed < 0 || maxSpeed > 600) {
                        SetStatusMessage("Pole prędkość maksymalna zawiera niepoprawną wartość!");
                        mistakes++;
                    }
                }
                catch (FormatException) {

                    // Przechwycenie wyjątku - wprowadzenie innej wartości niż int
                    SetStatusMessage("Pole prędkość maksymalna zawiera niedozwolone znaki!");
                    mistakes++;
                }
            }

            // Sprwdzanie poprawności pojemności silnika
            if (textBoxEngineCapacity.Text == string.Empty)
            {
                emptyFields++;
            }
            else 
            {
                try
                {
                    int engineCapacity = int.Parse(textBoxEngineCapacity.Text);
                    // Zakładamy, że pojemność silnika zawiera się w przedziale <0; 10 000>
                    if (engineCapacity < 0 || engineCapacity > 10000)
                    {

                        SetStatusMessage("Pole pojemność silnika zawiera niepoprawną wartość!");
                        mistakes++;
                    }
                }
                catch (FormatException)
                {

                    // Przechwycenie wyjątku - wprowadzenie innej wartości niż int
                    SetStatusMessage("Pole pojemność silnika zawiera niedozwolone znaki!");
                    mistakes++;
                }
            }


            // Sprawdzanie poprawności daty przeglądu
            if (maskedTextBoxControlDate.Text == "  /  /")
            {
                emptyFields++;
            }
            else 
            {
                try
                {
                    DateTime date = DateTime.Parse(maskedTextBoxControlDate.Text);
                }
                catch (FormatException)
                {
                    // Przechwycenie wyjątku - niepoprawny format daty
                    SetStatusMessage("Wprowadzona data ma niepoprawny format!");
                    mistakes++;
                }
            }

            // Sprawdzenie, czy obraz został wybrany
            if(pictureBoxAuto.Image == null) emptyFields++;



            // Ustawienie etykiety statusu
            if (mistakes == 0 && emptyFields == 0)
            {
                SuccessMessage("Pola uzupełnione poprawnie!");
                return true;
            }
            else {
                labelStatus.ForeColor = Color.Red;
                if(emptyFields != 0) 
                {
                    SetStatusMessage("Nie uzupełniono wszystkich pól!");
                }
                return false;
            }
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxRegistration.MaskCompleted)
            {
                if (_repository.GetCar(maskedTextBoxRegistration.Text) != null)
                {
                    FailureMessage("Auto o danej rejestracji już istnieje!");
                }
                else
                {
                    if (CheckDataCorrectness())
                    {
                        _repository.AddCar(
                            maskedTextBoxRegistration.Text, 
                            textBoxWorkerLogin.Text, 
                            textBoxBrand.Text, 
                            textBoxModel.Text,
                            //checkBoxBorrowed.Checked,
                            int.Parse(textBoxVintage.Text), 
                            float.Parse(textBoxAverageConsumption.Text), 
                            int.Parse(textBoxMaxSpeed.Text), 
                            int.Parse(textBoxEngineCapacity.Text), 
                            DateTime.Parse(maskedTextBoxControlDate.Text),
                            pictureBoxAuto.Image);

                        ClearAllData();
                        SuccessMessage("Auto zostało dodane pomyślnie!");
                    }
                }
            }
            else 
            {
                FailureMessage("Pole rejestracji nie jest całkowicie wypełnione!");
            }
            
        }



        private void SuccessMessage(string message) {

            labelStatus.ForeColor = Color.Green;
            SetStatusMessage(message);
        }



        private void FailureMessage(string message) {
            labelStatus.ForeColor = Color.Red;
            SetStatusMessage(message);
        }



        private void SetStatusMessage(string message) {
            labelStatus.Text = "Status: " + message;
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            _repository.DeleteCar(maskedTextBoxRegistration.Text);
            SwitchMode();
            ClearAllData();
            SuccessMessage("Pomyślnie usunięto!");
        }



        private void SwitchMode() 
        {
            btnAdd.Visible = !btnAdd.Visible;
            btnSearch.Visible = !btnSearch.Visible;
            btnUpdate.Visible = !btnUpdate.Visible;
            btnReturn.Visible = !btnReturn.Visible;
            btnDelete.Visible = !btnDelete.Visible;
            maskedTextBoxRegistration.Enabled = !maskedTextBoxRegistration.Enabled;
        }
    }
}
