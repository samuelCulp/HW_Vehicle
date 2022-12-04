using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Properties;


/*This program is to evaluate subjectively the automotive industry similarly to 
 * the Carvana website.It takes input from the user via the Combo box and then 
 * displays the info on in a list view. The user can click and then open the module
 * of the car and it will display on a label.
 */


namespace WindowsFormsApp2
{


    public partial class Form1 : Form
    {

 

        public int num = 0;
        public string val;
        public string[] arr;
        public string[] arr1;
        public int makeSet = 0;

        enum Type// enum for the Type of car combo box
        {
            Suv,
            Sedan, 
            Hatchback,
            Truck,
            Coupe,
            Minivan,
            Convertible,
            Wagon
        }

        enum Make// enum for the make of the car combo box
        {
            Buick,
            Cadillac,
            Chevrolet,
            Dodge,
            Ford,
            GMC,
            Hyundai,
            Jeep,
            Nissan,
            Pontiac,
            Ram,
            Saturn,
            Subaru,
            Toyota
        }

        public Form1()
        {
            InitializeComponent();
            val = "Make & Model";
            make_model.Text = val;
               
    }

        private void Form1_Load(object sender, EventArgs e)
            {
               
                foreach (int i in Enum.GetValues(typeof(Make)))// for the make combo box 
                {
                    make_model.Items.Add(Enum.GetName(typeof(Make), i));
                }
                foreach (int k in Enum.GetValues(typeof(Type)))
                {
                    type_box.Items.Add(Enum.GetName(typeof(Type), k));
                }

            // this puts the info in the form
            }
 
            private void make_model_SelectedIndexChanged(object sender, EventArgs e)
            {


            list.Items.Clear(); // clears the list every time the user inputs something new
            type_box.Click += type_box_SelectedIndexChanged;
            

            switch (make_model.SelectedIndex) // this is for the combo boxes 
            {
                case 0:// this output is Buick
                    for (int i = 0; i < 5; i++)
                    {
                        arr = CarTypeOB.GetModel(make_model.SelectedIndex);// get the info from a file called cartypeob
                        list.Items.Add(arr[i]);
                    }
                    break;
                case 1:
                    for (int i = 0; i < 5; i++)
                    {
                        arr = CarTypeOB.GetModel(make_model.SelectedIndex);
                        list.Items.Add(arr[i]);
                    }
                    break;

                case 2:
                    for (int i = 0; i < 5; i++)
                    {
                        arr = CarTypeOB.GetModel(make_model.SelectedIndex);
                        list.Items.Add(arr[i]);
                    }
                    break;
                case 3:
                    for (int i = 0; i < 5; i++)
                    {
                        arr = CarTypeOB.GetModel(make_model.SelectedIndex);
                        list.Items.Add(arr[i]);
                    }
                    break;
                case 4:
                    for (int i = 0; i < 5; i++)
                    {
                        arr = CarTypeOB.GetModel(make_model.SelectedIndex);
                        list.Items.Add(arr[i]);
                    }
                    break;
                case 5:
                    for (int i = 0; i < 5; i++)
                    {
                        arr = CarTypeOB.GetModel(make_model.SelectedIndex);
                        list.Items.Add(arr[i]);
                    }
                    break;
                case 6:
                    for (int i = 0; i < 5; i++)
                    {
                        arr = CarTypeOB.GetModel(make_model.SelectedIndex);
                        list.Items.Add(arr[i]);
                    }
                    break;
                case 7:
                    for (int i = 0; i < 5; i++)
                    {
                        arr = CarTypeOB.GetModel(make_model.SelectedIndex);
                        list.Items.Add(arr[i]);
                    }
                    break;
                case 8:
                    for (int i = 0; i < 5; i++)
                    {
                        arr = CarTypeOB.GetModel(make_model.SelectedIndex);
                        list.Items.Add(arr[i]);
                    }
                    break;
                case 9:
                    for (int i = 0; i < 5; i++)
                    {
                        arr = CarTypeOB.GetModel(make_model.SelectedIndex);
                        list.Items.Add(arr[i]);
                    }
                    break;
                case 10:
                    for (int i = 0; i < 5; i++)
                    {
                        arr = CarTypeOB.GetModel(make_model.SelectedIndex);
                        list.Items.Add(arr[i]);
                    }
                    break;
                case 11:
                    for (int i = 0; i < 3; i++)
                    {
                        arr = CarTypeOB.GetModel(make_model.SelectedIndex);
                        list.Items.Add(arr[i]);
                    }
                    break;
                case 12:

                    for (int i = 0; i < 5; i++)
                    {
                        arr = CarTypeOB.GetModel(make_model.SelectedIndex);
                        list.Items.Add(arr[i]);
                    }
                    break;
                case 13:
                    for (int i = 0; i < 5; i++)
                    {
                        arr = CarTypeOB.GetModel(make_model.SelectedIndex);
                        list.Items.Add(arr[i]);
                    }
                    break;
            }

                
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
            {



        }

      

            private void button1_Click(object sender, EventArgs e) // button
            {
            infoLabel.Text = list.SelectedItems[0].ToString();
            //infoLabel.Text = list.Items[0].ToString();
        }

        private void type_box_SelectedIndexChanged(object sender, EventArgs e)
        {

            list.Items.Clear();
            make_model.Click += make_model_SelectedIndexChanged;
            

            CarTypeOB.BodyType body = new CarTypeOB.BodyType();
            if (make_model.SelectedIndex == 0) // wish i would have used a switch statement
            {
                switch (type_box.SelectedIndex) // for boxes
                {

                    case 0:
                        body.BuickSUV.ToList().ForEach(element => list.Items.Add(element.ToString()));// foreach loop that puts info in listview
                        break;
                    case 1:
                        body.BuickSedan.ToList().ForEach(element => list.Items.Add(element.ToString()));
                        break;
                    case 6:
                        body.BuickConvertible.ToList().ForEach(element => list.Items.Add((element.ToString())));
                        break;

                }
            }
            else if (make_model.SelectedIndex == 1)
            {
                switch (type_box.SelectedIndex)
                {
                    case 0:
                        body.CadillacSUV.ToList().ForEach(element => list.Items.Add(element.ToString()));
                        break;
                    case 1:
                        body.CadillacSedan.ToList().ForEach(element => list.Items.Add(element.ToString()));
                        break;
                }
            }
            else if (make_model.SelectedIndex == 2)
            {
                switch (type_box.SelectedIndex)
                {
                    case 0:
                        body.ChevroletSUV.ToList().ForEach(element => list.Items.Add(element.ToString()));
                        break;
                    case 1:
                        body.ChevroletSedan.ToList().ForEach(element => list.Items.Add(element.ToString()));
                        break;
                    case 4:
                        body.ChevroletCoupe.ToList().ForEach(element => list.Items.Add(element.ToString()));
                        break;
                    case 3:
                        body.ChevroletTruck.ToList().ForEach(element => list.Items.Add(element.ToString()));
                        break;
                }
            }
            else if (make_model.SelectedIndex == 3)
            {
                switch (type_box.SelectedIndex)
                {
                    case 0:
                        body.DodgeSUV.ToList().ForEach(element => list.Items.Add(element.ToString()));
                        break;
                    case 1:
                        body.DodgeSedan.ToList().ForEach(element => list.Items.Add(element.ToString()));
                        break;
                    case 4:
                        body.DodgeCoupe.ToList().ForEach(element => list.Items.Add(element.ToString()));
                        break;
                }
            }
            else if (make_model.SelectedIndex == 4)
            {
                switch (type_box.SelectedIndex)
                {
                    case 0:
                        body.FordSUV.ToList().ForEach(element => list.Items.Add(element.ToString()));
                        break;
                    case 1:
                        body.FordSedan.ToList().ForEach(element => list.Items.Add(element.ToString()));
                        break;
                    case 3:
                        body.FordTruck.ToList().ForEach(element => list.Items.Add(element.ToString()));
                        break;
                    case 4:
                        body.FordCoupe.ToList().ForEach(element => list.Items.Add(element.ToString()));
                        break;
                }
            }
            else if (make_model.SelectedIndex == 5)
            {
                switch(type_box.SelectedIndex)
                {
                    case 0:
                        body.GMCSUV.ToList().ForEach(element => list.Items.Add(element.ToString()));
                        break;
                    case 3:
                        body.GMCTruck.ToList().ForEach(element => list.Items.Add(element.ToString()));
                        break;
                }
            }
            else if(make_model.SelectedIndex == 6)
            {
                switch(type_box.SelectedIndex){
                    case 0:
                        body.HyundaySUV.ToList().ForEach(element => list.Items.Add(element.ToString()));
                    break;
                    case 1:
                        body.HyundaiSedan.ToList().ForEach(element => list.Items.Add(element.ToString()));
                    break;
                }
            }
            else if (make_model.SelectedIndex == 7)
            {
                switch (type_box.SelectedIndex)
                {
                    case 0:
                        body.JeepSUV.ToList().ForEach(element => list.Items.Add(element.ToString()));
                        break;
                    case 3:
                        body.JeppTruck.ToList().ForEach(element => list.Items.Add(element.ToString()));
                        break;
                }
            }
            
            else if (make_model.SelectedIndex == 8)
            {
                switch (type_box.SelectedIndex)
                {
                    case 0:
                        body.NissanSUV.ToList().ForEach(element => list.Items.Add(element.ToString()));
                        break;
                    case 1:
                        body.NissanSedan.ToList().ForEach(element => list.Items.Add(element.ToString()));
                        break;
                    case 4:
                        body.NissanCoupe.ToList().ForEach(element => list.Items.Add(element.ToString()));
                        break;
                    case 5:
                        body.NissanVan.ToList().ForEach(element => list.Items.Add(element.ToString()));
                        break;
                }
            }
            else if (make_model.SelectedIndex == 9)
            {
                switch(type_box.SelectedIndex) {
                    case 1:
                        body.PontiacSedan.ToList().ForEach(element => list.Items.Add(element.ToString()));
                        break;
                    case 6:
                        body.PoniacConvertible.ToList().ForEach(element => list.Items.Add(element.ToString()));
                        break;
                    case 2:
                        body.PontiacHatch.ToList().ForEach(element => list.Items.Add(element.ToString()));
                        break;
                }
            }
            else if (make_model.SelectedIndex == 10)
            {
                switch(type_box.SelectedIndex){
                    case 3:
                        body.RAMTruck.ToList().ForEach(element => list.Items.Add(element.ToString()));
                        break;
                }
            }
            else if (make_model.SelectedIndex == 11)
            {
                switch (type_box.SelectedIndex)
                {
                    case 0:
                        body.SaturnSUV.ToList().ForEach(element => list.Items.Add(element.ToString()));
                        break;
                    case 1:
                        body.SaturnSedan.ToList().ForEach(element => list.Items.Add(element.ToString()));
                        break;

                }
            }
            else if(make_model.SelectedIndex == 12)
            {
                switch (type_box.SelectedIndex)
                {
                    case 0:
                        body.SubaruSUV.ToList().ForEach(element => list.Items.Add(element.ToString()));
                        break;
                    case 1:
                        body.SubaruSedan.ToList().ForEach(element => list.Items.Add(element.ToString()));
                        break;
                    case 4:
                        body.SubaruCoupe.ToList().ForEach(element => list.Items.Add(element.ToString()));
                        break;
                }
            }
            else if (make_model.SelectedIndex == 13)
            {
                switch(type_box.SelectedIndex)
                {
                    case 0:
                        body.ToyotaSuv.ToList().ForEach(element => list.Items.Add(element.ToString()));
                        break;
                    case 1:
                        body.ToyotaSedan.ToList().ForEach(element => list.Items.Add(element.ToString()));
                        break;
                    case 2:
                        body.ToyotaHatch.ToList().ForEach(element => list.Items.Add(element.ToString()));
                        break;
                    case 3:
                        body.ToyotaTruck.ToList().ForEach(element => list.Items.Add(element.ToString()));
                        break;
                }
            }

            else
            {
                switch (type_box.SelectedIndex)
                {



                    case 1:
                        for (int i = 0; i < CarTypeOB.GetTypeAllSedan(num).GetLength(num); i++)
                        {
                            arr1 = CarTypeOB.GetTypeAllSedan(type_box.SelectedIndex);
                            list.Items.Add(arr1[i]);
                        }
                        break;
                    case 0:
                        for (int i = 0; i < CarTypeOB.GetTypeAllSUV(num).GetLength(num); i++)
                        {
                            arr1 = CarTypeOB.GetTypeAllSUV(type_box.SelectedIndex);
                            list.Items.Add(arr1[i]);
                        }
                        break;
                    case 4:
                        for (int i = 0; i < CarTypeOB.GetTypeAllCoupe(num).GetLength(num); i++)
                        {
                            arr1 = CarTypeOB.GetTypeAllCoupe(type_box.SelectedIndex);
                            list.Items.Add(arr1[i]);
                        }
                        break;
                    case 6:
                        for (int i = 0; i < CarTypeOB.GetTypeAllConvertible(num).GetLength(num); i++)
                        {
                            arr1 = CarTypeOB.GetTypeAllConvertible(type_box.SelectedIndex);
                            list.Items.Add(arr1[i]);
                        }
                        break;
                    case 5:
                        for (int i = 0; i < CarTypeOB.GetTypeAllMinivan(num).GetLength(num); i++)
                        {
                            arr1 = CarTypeOB.GetTypeAllMinivan(type_box.SelectedIndex);
                            list.Items.Add(arr1[i]);
                        }
                        break;
                    case 2:
                        for (int i = 0; i < CarTypeOB.GetTypeAllHatchback(num).GetLength(num); i++)
                        {
                            arr1 = CarTypeOB.GetTypeAllHatchback(type_box.SelectedIndex);
                            list.Items.Add(arr1[i]);
                        }
                        break;
                    case 3:
                        for (int i = 0; i < CarTypeOB.GetTypeAllTruck(num).GetLength(num); i++)
                        {
                            arr1 = CarTypeOB.GetTypeAllTruck(type_box.SelectedIndex);
                            list.Items.Add(arr1[i]);
                        }
                        break;
                    case 7:
                        for (int i = 0; i > CarTypeOB.GetTypeAllWagon(num).GetLength(num); i++)
                        {
                            arr1 = CarTypeOB.GetTypeAllWagon(type_box.SelectedIndex);
                            list.Items.Add(arr1[i]);
                        }
                        break;
                }
            }
        }

        private void reset_Click(object sender, EventArgs e) // reset button not perfect 
        {
            infoLabel.Text = "";
            type_box.ResetText();
            make_model.ResetText();
            type_box.Items.Equals(0);
            make_model.Items.Equals(0);
            type_box.Text = "Body Type";
            make_model.Text = val;
            list.Items.Clear();
            
            
        }

        private void infoLabel_Click(object sender, EventArgs e)
        {
           
        }
    }
    } 
