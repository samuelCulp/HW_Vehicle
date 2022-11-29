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



/*# Objective
To evaluate subjectively the Automotive Industry from a specific Car Dealers website Search Functionality.

# Deliverables
1. Word Document
    * File Name: HW_Vehicle_[username].docx
        * [username] is the portion of your email before @jeffersonstate.edu
    * Have GitHub Repository URL that is accessible to me to obtain a copy of the Repository
2. Excel Document
    * File Name: HW_Vehicle_[username].xlsx
        * [username] is the portion of your email before @jeffersonstate.edu
    * Table Listing each Make, Model, Year, Body Type, and Color combination
        * Certain Models will only have 1 Body Type, so pay attention
        * Certain Makes will have limited Body Types, so pay attention
    * You will necessarily have a long list (~350 +/- Unique), there should be no less than 5 different combination (Year + Body Type + Color) for each Make & Model.
        * Focus on the variations between Make + Model + Body Type + Color; Year does not have to factor in to the combination list

# Criteria
1. In a browser, Navigate to: https://www.carvana.com/cars
2. Based on the Drop Down boxes: (excluding "Payment & Price", "Features", and "More Filters")
    1. From the "Make & Model", use these fourteen (14) Make's as your guide
        1. Buick, Cadillac, Chevrolet, Dodge, Ford, GMC, Hyundai, Jeep, Nissan, Pontiac, Ram, Saturn, Subaru, and Toyota
    2. From the "Make & Model", pick 5 Models for each Make.
    2. All Body Types must be represented.
        - A single Make & Model may have multiple Body Type availability.
3. Assume there are 5 Color Options for any Make & Model: Black, White, Red, Green, and Beige
4. Some Makes & Model's will NOT have all Body Types, so account for that unique variation
5. Based on your observation with the inventory, you should develop Object of these types
    1. Structures: At least two (2)
    2. Classes: At least one (1) for each "Make & Model" + "Body Type" combination
        1. There should be at least one (1) Abstract for each Model, there could be more
    3. Interfaces: At least one (1) effectively implemented; NO gratuitous unimplemented Interfaces.
        * Must be a template architecture for those Classes that implement them.
        * All classes must inherit or implement an Interfaces contract.

# Hints
* FIRST: Identify Make + Model combinations
* SECOND: Create Unique Body Type Options for the Make + Model + Year combinations
    * Think of this like the Options for Make & Model
    * Body Type could include 2, 3, 4, or 5 door; 4-door Cars have 5 doors, find the 5th.
        > Certain Body Styles are limited to 2-door, so make sure to account for that.
    * Body Type could also include 2x4, 4x4, and AWD
* Third: Add Color variants for each of the Combinations.
* Lastly: Based on observed consistencies, create a Class that will Describe the Make + Model
    * Start with the combinations you know, abstract classes appropriately and implement Interfaces from the Abstract Class (typically)
    * Make sure to have the basic Actions for each vehicle:
        1. Door Status; account for all doors, can be separated into compartmental checks
        2. Engine Status
        3. Motion Status
        4. Key Status
        5. Break Status
    * Attributes for the Vehicles:
        > Certain attributes will ONLY apply to certain Body Types
        1. Tires
        2. Doors
        3. Cabin Style
        4. Body Type
        5. Bed Length
        6. MPG - City
        7. MPG - Highway
 * */

namespace WindowsFormsApp2
{


    public partial class Form1 : Form
    {

 

        public int num = 0;
        public string val;
        public string[] arr;
        public string[] arr1;
        public int makeSet = 0;

        enum Type// enum for the Type of car
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

        enum Make// enum for the make of the car 
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

        private void Form1_Load(object sender, EventArgs e) // note make a method for combo boxes
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
            //his.Controls.Add(make_model);

            }
 
            private void make_model_SelectedIndexChanged(object sender, EventArgs e)
            {


            list.Items.Clear();
            type_box.Click += type_box_SelectedIndexChanged;
            

            switch (make_model.SelectedIndex)
            {
                case 0:// this output is Buick
                    for (int i = 0; i < 5; i++)
                    {
                        arr = Class2.GetModel(make_model.SelectedIndex);
                        list.Items.Add(arr[i]);
                    }
                    break;
                case 1:// this output is Buick
                    for (int i = 0; i < 5; i++)
                    {
                        arr = Class2.GetModel(make_model.SelectedIndex);
                        list.Items.Add(arr[i]);
                    }
                    break;

                case 2:// this output is Buick
                    for (int i = 0; i < 5; i++)
                    {
                        arr = Class2.GetModel(make_model.SelectedIndex);
                        list.Items.Add(arr[i]);
                    }
                    break;
                case 3:// this output is Buick
                    for (int i = 0; i < 5; i++)
                    {
                        arr = Class2.GetModel(make_model.SelectedIndex);
                        list.Items.Add(arr[i]);
                    }
                    break;
                case 4:// this output is Buick
                    for (int i = 0; i < 5; i++)
                    {
                        arr = Class2.GetModel(make_model.SelectedIndex);
                        list.Items.Add(arr[i]);
                    }
                    break;
                case 5:// this output is Buick
                    for (int i = 0; i < 5; i++)
                    {
                        arr = Class2.GetModel(make_model.SelectedIndex);
                        list.Items.Add(arr[i]);
                    }
                    break;
                case 6:// this output is Buick
                    for (int i = 0; i < 5; i++)
                    {
                        arr = Class2.GetModel(make_model.SelectedIndex);
                        list.Items.Add(arr[i]);
                    }
                    break;
                case 7:// this output is Buick
                    for (int i = 0; i < 5; i++)
                    {
                        arr = Class2.GetModel(make_model.SelectedIndex);
                        list.Items.Add(arr[i]);
                    }
                    break;
                case 8:// this output is Buick
                    for (int i = 0; i < 5; i++)
                    {
                        arr = Class2.GetModel(make_model.SelectedIndex);
                        list.Items.Add(arr[i]);
                    }
                    break;
                case 9:// this output is Buick
                    for (int i = 0; i < 5; i++)
                    {
                        arr = Class2.GetModel(make_model.SelectedIndex);
                        list.Items.Add(arr[i]);
                    }
                    break;
                case 10:// this output is Buick
                    for (int i = 0; i < 5; i++)
                    {
                        arr = Class2.GetModel(make_model.SelectedIndex);
                        list.Items.Add(arr[i]);
                    }
                    break;
                case 11:// this output is Buick
                    for (int i = 0; i < 3; i++)
                    {
                        arr = Class2.GetModel(make_model.SelectedIndex);
                        list.Items.Add(arr[i]);
                    }
                    break;
                case 12:// this output is Buick

                    for (int i = 0; i < 5; i++)
                    {
                        arr = Class2.GetModel(make_model.SelectedIndex);
                        list.Items.Add(arr[i]);
                    }
                    break;
                case 13:// this output is Buick
                    for (int i = 0; i < 5; i++)
                    {
                        arr = Class2.GetModel(make_model.SelectedIndex);
                        list.Items.Add(arr[i]);
                    }
                    break;
            }
               // if (make_model.SelectedIndex != -1) {
                 //   num = make_model.SelectedIndex;
                   // make_model.ResetText();
                    //make_model.Items.RemoveAt(make_model.SelectedIndex);
                //}
           // BeginInvoke(new Action(() => make_model.Text = Enum.GetName(typeof(Make), num)));
                
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
            {



        }

      

            private void button1_Click(object sender, EventArgs e)
            {
            infoLabel.Text = list.SelectedItems[0].ToString();
        }

        private void type_box_SelectedIndexChanged(object sender, EventArgs e)
        {

            list.Items.Clear();
            make_model.Click += make_model_SelectedIndexChanged;
            

            Class2.BodyType body = new Class2.BodyType();
            if (make_model.SelectedIndex == 0) // wish i would have used a switch statement
            {
                switch (type_box.SelectedIndex)
                {

                    case 0:
                        body.BuickSUV.ToList().ForEach(element => list.Items.Add(element.ToString()));
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
                    case 2:
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
                        for (int i = 0; i < Class2.GetTypeAllSedan(num).GetLength(num); i++)
                        {
                            arr1 = Class2.GetTypeAllSedan(type_box.SelectedIndex);
                            list.Items.Add(arr1[i]);
                        }
                        break;
                    case 0:
                        for (int i = 0; i < Class2.GetTypeAllSUV(num).GetLength(num); i++)
                        {
                            arr1 = Class2.GetTypeAllSUV(type_box.SelectedIndex);
                            list.Items.Add(arr1[i]);
                        }
                        break;
                    case 4:
                        for (int i = 0; i < Class2.GetTypeAllCoupe(num).GetLength(num); i++)
                        {
                            arr1 = Class2.GetTypeAllCoupe(type_box.SelectedIndex);
                            list.Items.Add(arr1[i]);
                        }
                        break;
                    case 6:
                        for (int i = 0; i < Class2.GetTypeAllConvertible(num).GetLength(num); i++)
                        {
                            arr1 = Class2.GetTypeAllConvertible(type_box.SelectedIndex);
                            list.Items.Add(arr1[i]);
                        }
                        break;
                    case 5:
                        for (int i = 0; i < Class2.GetTypeAllMinivan(num).GetLength(num); i++)
                        {
                            arr1 = Class2.GetTypeAllMinivan(type_box.SelectedIndex);
                            list.Items.Add(arr1[i]);
                        }
                        break;
                    case 2:
                        for (int i = 0; i < Class2.GetTypeAllHatchback(num).GetLength(num); i++)
                        {
                            arr1 = Class2.GetTypeAllHatchback(type_box.SelectedIndex);
                            list.Items.Add(arr1[i]);
                        }
                        break;
                    case 3:
                        for (int i = 0; i < Class2.GetTypeAllTruck(num).GetLength(num); i++)
                        {
                            arr1 = Class2.GetTypeAllTruck(type_box.SelectedIndex);
                            list.Items.Add(arr1[i]);
                        }
                        break;
                    case 7:
                        for (int i = 0; i > Class2.GetTypeAllWagon(num).GetLength(num); i++)
                        {
                            arr1 = Class2.GetTypeAllWagon(type_box.SelectedIndex);
                            list.Items.Add(arr1[i]);
                        }
                        break;
                }
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {

            type_box.ResetText();
            make_model.ResetText();
            type_box.Text = "Body Type";
            make_model.Text = val;
            list.Items.Clear();
            
            
        }

        private void infoLabel_Click(object sender, EventArgs e)
        {
           
        }
    }
    } 
