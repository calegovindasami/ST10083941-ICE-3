using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using ICE_3.Classes;

namespace ICE_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbVehicle.SelectedIndex = 0;
        }

        private void cmbVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbVehicle.SelectedIndex)
            {
                case 0:
                    UpdateLabels("Number of Wheels", "Number of Doors", "Horn Type");
                    break;
                case 1:
                    UpdateLabels("Wing Span", "Number of Emergency Exists", "Propeller Type");
                    break;
                case 2:
                    UpdateLabels("Number of Life Jackets", "Rudder Type", "Anchor Type");
                    break;
                case 3:
                    UpdateLabels("Number of Blades", "Blade Length", "Rotor Type");
                    break;
                case 4:
                    UpdateLabels("Type of Propeller", "Type of Diving Plane", "Maximum Depth");
                    break;

                default:
                    break;
            }
        }

        public void UpdateLabels(string attrFour, string attrFive, string attrSix)
        {
            lblAttrFour.Text = attrFour;
            lblAttrFive.Text = attrFive;
            lblAttrSix.Text = attrSix;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
             
            switch (cmbVehicle.SelectedIndex)
            {
                case 0:
                    Car car = new(boxAttrOne.Text, Convert.ToInt32(boxAttrTwo.Text), boxAttrThree.Text, Convert.ToInt32(boxAttrFour.Text), Convert.ToInt32(boxAttrFive.Text), boxAttrSix.Text);
                    WriteToFile(car.EngineType, car.NumberOfSeats.ToString(), car.Color, car.NumberOfWheels.ToString(), car.NumberOfDoors.ToString(), car.HornType);
                    break;
                case 1:
                    Airplane airplane = new(boxAttrOne.Text, Convert.ToInt32(boxAttrTwo.Text), boxAttrThree.Text, Convert.ToDouble(boxAttrFour.Text), Convert.ToInt32(boxAttrFive.Text), boxAttrSix.Text);
                    WriteToFile(airplane.EngineType, airplane.NumberOfSeats.ToString(), airplane.Color, airplane.WingSpan.ToString(), airplane.NumberOfEmergecyExits.ToString(), airplane.PropellerType);
                    break;
                case 2:
                    Boat boat = new(boxAttrOne.Text, Convert.ToInt32(boxAttrTwo.Text), boxAttrThree.Text, Convert.ToInt32(boxAttrFour.Text), boxAttrFive.Text, boxAttrSix.Text);
                    WriteToFile(boat.EngineType, boat.NumberOfSeats.ToString(), boat.Color, boat.NumberOfLifeJackets.ToString(), boat.RudderType, boat.AnchorType);
                    break;
                case 3:
                    Helicopter helicopter = new(boxAttrOne.Text, Convert.ToInt32(boxAttrTwo.Text), boxAttrThree.Text, Convert.ToInt32(boxAttrFour.Text), Convert.ToDouble(boxAttrFive.Text), boxAttrSix.Text);
                    WriteToFile(helicopter.EngineType, helicopter.NumberOfSeats.ToString(), helicopter.Color, helicopter.NumberOfBlades.ToString(), helicopter.BladeLength.ToString(), helicopter.RotorType);
                    break;
                case 4:
                    Submarine submarine = new(boxAttrOne.Text, Convert.ToInt32(boxAttrTwo.Text), boxAttrThree.Text, boxAttrFour.Text, boxAttrFive.Text, Convert.ToDouble(boxAttrSix.Text));
                    WriteToFile(submarine.EngineType, submarine.NumberOfSeats.ToString(), submarine.Color, submarine.PropellerType, submarine.DivingPlaneType, submarine.MaximumDepth.ToString());
                    break;

                default:
                    break;
            }
        }

        public void WriteToFile(string attrOne, string attrTwo, string attrThree, string attrFour, string attrFive, string attrSix)
        {
            try
            {


                StreamWriter writer = new("C:\\Users\\Cale\\source\\repos\\ICE-3\\ICE-3\\Vehicle.txt", true);
                writer.WriteLine("--- New Entry ---");
                writer.WriteLine($"Vehicle Type: {cmbVehicle.Text}");
                writer.WriteLine($"{lblAttrOne.Text}: {attrOne}");
                writer.WriteLine($"{lblAttrTwo.Text}: {attrTwo}");
                writer.WriteLine($"{lblAttrThree.Text}: {attrThree}");
                writer.WriteLine($"{lblAttrFour.Text}: {attrFour}");
                writer.WriteLine($"{lblAttrFive.Text}: {attrFive}");
                writer.WriteLine($"{lblAttrSix.Text}: {attrSix}");
                writer.WriteLine("--- End of Entry ---");
                writer.WriteLine();
                writer.Close();

                MessageBox.Show("Entry successfully added.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
