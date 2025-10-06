using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UD1_EjBINDING
{
    public partial class Form1 : Form
    {
        //Declaracion de variables
        public List<City> Cities;
        public String[] mycities = new string[] {"Sevilla","Cordoba","Malaga" ,"jaen"};
        public City murcia = new City() { NameCity = "Murcia", CountryCity = "Noexiste", PopulationCity = 10 };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Vinculamos el control combobox con el array de string de las ciudades
            cbCity.DataSource = mycities;

            //Inicializamos la lista de ciudades
            Cities = new List<City>() {
            
                new City(){
                NameCity = "cordoba",
                PopulationCity = 330000,
                CountryCity = "España"
                },
                new City(){
                NameCity = "Malaga",
                PopulationCity = 577000,
                CountryCity = "España"
                },
                new City(){
                NameCity = "Jaen",
                PopulationCity = 110000,
                CountryCity = "España"
                },new City(){
                NameCity = "Huelva",
                PopulationCity = 240000,
                CountryCity = "España"
                }
            };

            //Vincular la lista con el control datagridview
            cityBindingSource.DataSource = Cities;
        
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (!Cities.Contains(murcia))
            {

                Cities.Add(murcia);
                //Temnemos que actualizar el binding para mostrar la nueva ciudad en el control
                cityBindingSource.DataSource = null;
                cityBindingSource.DataSource = Cities;

            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            foreach (City c in Cities.ToList()) {

                if (c.NameCity.Equals("Huelva")) {

                    Cities.Remove(c);

                    cityBindingSource.DataSource = null;
                    cityBindingSource.DataSource = Cities;
                }
            
            }
        }
    }
}
