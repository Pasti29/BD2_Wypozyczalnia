﻿using Klient.Database;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Klient.Forms
{
    public partial class FormCatalog : Form
    {
        private readonly DataTable _carsDataTable;

        public FormCatalog()
        {
            InitializeComponent();

            // Zaczerpnięcie informacji o wszystkich autach z bazy danych
            _carsDataTable = Repository.GetCarsTable();

            // Dodanie zdjęc do 'imageListWithCars'
            foreach (DataRow row in _carsDataTable.Rows)
            {
                byte[] imageInBytes = (byte[])row["Zdjecie"];
                MemoryStream memoryStream = new MemoryStream(imageInBytes);
                Image image = Image.FromStream(memoryStream);

                this.imageListWithCars.Images.Add(image);
            }

            // Tworzenie ListViewItems
            int imageIndex = 0;
            StringBuilder stringBuilder = new StringBuilder();
            foreach (DataRow row in _carsDataTable.Rows)
            {
                stringBuilder.Append(row["Marka"]).Append(" ").Append(row["Model"]).Append(" [").Append(row["Rocznik"]).Append("]");
                // Utworzenie 'ListViewItem' o danym opisie i indeksie obrazka z 'imageListWithCars'
                ListViewItem item = new ListViewItem(stringBuilder.ToString(), imageIndex);
                this.listViewCars.Items.Add(item);
                imageIndex++;
                stringBuilder.Clear();
            }
        }

        private void listViewCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCars.SelectedItems.Count > 0)
            {
                // Przypisane indeksu zaznaczonego obrazka do zmiennej 'selectedIndex'
                int selectedIndex = listViewCars.SelectedItems[0].Index;
                // Wyznaczenie wiersza
                DataRow selectedRow = _carsDataTable.Rows[selectedIndex];

                // Przypisanie wartości do etykiet
                labelRegistrationData.Text = selectedRow[0].ToString();
                labelWorkerIDData.Text = selectedRow[1].ToString();
                labelBrandData.Text = selectedRow[2].ToString();
                labelModelData.Text = selectedRow[3].ToString();
                labelVintageData.Text = selectedRow[4].ToString();
                labelAverageConsumptionData.Text = selectedRow[5].ToString();
                labelMaxSpeedData.Text = selectedRow[6].ToString();
                labelEngineCapacityData.Text = selectedRow[7].ToString();
                labelControlDateData.Text = selectedRow[8].ToString().Substring(0, 10);
            }
            else if (listViewCars.SelectedItems.Count == 0)
            {
                // Jeśli nic nie zostało kliknięte - czyścimy wartości etykiet
                labelRegistrationData.Text = "";
                labelWorkerIDData.Text = "";
                labelBrandData.Text = "";
                labelModelData.Text = "";
                labelVintageData.Text = "";
                labelAverageConsumptionData.Text = "";
                labelMaxSpeedData.Text = "";
                labelEngineCapacityData.Text = "";
                labelControlDateData.Text = "";
            }
        }
    }
}