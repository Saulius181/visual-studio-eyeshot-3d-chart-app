using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using devDept.Geometry;
using devDept.Graphics;
using devDept.Eyeshot.Labels;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           

        }

        private void viewportLayout1_Click(object sender, EventArgs e)
        {

        }





        protected override void OnLoad(EventArgs e)
        {
            // adjusts grid extents ad step
            
            //viewportLayout1.Grid.Max = new Point3D(1000, 1000);
            viewportLayout1.Grid.AutoStep = true;
            //viewportLayout1.Grid.Step = 1;

            // sets trimetric view
            viewportLayout1.SetView(viewType.Trimetric);

            // fits the model in the viewport
            viewportLayout1.ZoomFit( 100 );

            base.OnLoad(e);
        }


        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                viewportLayout1.Clear();
                //viewportLayout1.Labels.Clear();

                Dictionary<string, Dictionary<string, double>> panel_data = new Dictionary<string, Dictionary<string, double>>();
                Dictionary<string, Dictionary<int, Dictionary<string, double>>> cell_data_by_axis = new Dictionary<string, Dictionary<int, Dictionary<string, double>>>();

                Dictionary<int, Dictionary<string, Dictionary<string, double>>> cell_data_by_id = new Dictionary<int, Dictionary<string, Dictionary<string, double>> >();

                panel_data.Add("X", new Dictionary<string, double>());
                panel_data.Add("Y", new Dictionary<string, double>());
                panel_data.Add("Z", new Dictionary<string, double>());

                cell_data_by_axis.Add("X", new Dictionary<int, Dictionary<string, double>>());
                cell_data_by_axis.Add("Y", new Dictionary<int, Dictionary<string, double>>());
                cell_data_by_axis.Add("Z", new Dictionary<int, Dictionary<string, double>>());

                panel_data["X"].Add("Average", 0);
                panel_data["Y"].Add("Average", 0);
                panel_data["Z"].Add("Average", 0);

                panel_data["X"].Add("Row Count", 0);
                panel_data["Y"].Add("Row Count", 0);
                panel_data["Z"].Add("Row Count", 0);

                panel_data["X"].Add("Max", 0);
                panel_data["Y"].Add("Max", 0);
                panel_data["Z"].Add("Max", 0);

                panel_data["X"].Add("Min", 0);
                panel_data["Y"].Add("Min", 0);
                panel_data["Z"].Add("Min", 0);

                panel_data["X"].Add("Variance", 0);
                panel_data["Y"].Add("Variance", 0);
                panel_data["Z"].Add("Variance", 0);

                panel_data["X"].Add("DeltaMax", 0);
                panel_data["Y"].Add("DeltaMax", 0);
                panel_data["Z"].Add("DeltaMax", 0);

                panel_data["X"].Add("DeltaAvg", 0);
                panel_data["Y"].Add("DeltaAvg", 0);
                panel_data["Z"].Add("DeltaAvg", 0);

                panel_data["X"].Add("Median", 0);
                panel_data["Y"].Add("Median", 0);
                panel_data["Z"].Add("Median", 0);

                //Pass valid data from the grid to the dictionary
                foreach (DataGridViewRow row in this.dataGridView.Rows)
                {

                    if (row.Cells[0].Value != null && Information.IsNumeric(row.Cells[0].Value) &&
                        row.Cells[1].Value != null &&
                        row.Cells[2].Value != null && Information.IsNumeric(row.Cells[2].Value) &&
                        row.Cells[3].Value != null && Information.IsNumeric(row.Cells[3].Value) &&
                        row.Cells[4].Value != null && Information.IsNumeric(row.Cells[4].Value) &&
                        row.Cells[5].Value != null && Information.IsNumeric(row.Cells[5].Value)
                        )
                    {
                        
                        var id = int.Parse(row.Cells[0].Value.ToString());
                        var axis = row.Cells[1].Value.ToString();
                        var value = double.Parse(row.Cells[2].Value.ToString());
                        var nominal = double.Parse(row.Cells[3].Value.ToString());
                        var lowTolerance = double.Parse(row.Cells[4].Value.ToString());
                        var upTolerance = double.Parse(row.Cells[5].Value.ToString());

                        if (cell_data_by_axis[axis].ContainsKey(id)) {
                            MessageBox.Show("Duplicate measurements with the id " + id.ToString() + " on the " + axis.ToString() + " axis.");
                        } else { 

                            cell_data_by_axis[axis].Add(
                            id,
                            new Dictionary<string, double>()
                            );

                            cell_data_by_axis[axis][id].Add("Value", value);
                            cell_data_by_axis[axis][id].Add("Nominal", nominal);
                            cell_data_by_axis[axis][id].Add("LowTolerance", lowTolerance);
                            cell_data_by_axis[axis][id].Add("UpTolerance", upTolerance);

                            if (!cell_data_by_id.ContainsKey(id))
                            {
                                cell_data_by_id[id] = new Dictionary<string, Dictionary<string, double>>();
                                cell_data_by_id[id]["X"] = new Dictionary<string, double>();
                                cell_data_by_id[id]["Y"] = new Dictionary<string, double>();
                                cell_data_by_id[id]["Z"] = new Dictionary<string, double>();

                                cell_data_by_id[id]["X"]["Value"] = 0;
                                cell_data_by_id[id]["Y"]["Value"] = 0;
                                cell_data_by_id[id]["Z"]["Value"] = 0;

                                cell_data_by_id[id]["X"]["Nominal"] = 0;
                                cell_data_by_id[id]["Y"]["Nominal"] = 0;
                                cell_data_by_id[id]["Z"]["Nominal"] = 0;

                                cell_data_by_id[id]["X"]["LowTolerance"] = 0;
                                cell_data_by_id[id]["Y"]["LowTolerance"] = 0;
                                cell_data_by_id[id]["Z"]["LowTolerance"] = 0;

                                cell_data_by_id[id]["X"]["UpTolerance"] = 0;
                                cell_data_by_id[id]["Y"]["UpTolerance"] = 0;
                                cell_data_by_id[id]["Z"]["UpTolerance"] = 0;

                            }
                            cell_data_by_id[id][axis]["Value"] = value;
                            cell_data_by_id[id][axis]["Nominal"] = nominal;
                            cell_data_by_id[id][axis]["LowTolerance"] = lowTolerance;
                            cell_data_by_id[id][axis]["UpTolerance"] = upTolerance;
                        }
                    }

                }
                

                //Iterate over data dictionary
                foreach (var axis in cell_data_by_axis)
                {
                    List<double> median_list = new List<double>();

                    foreach (var value in axis.Value)
                    {
                        panel_data[axis.Key]["Average"] += value.Value["Value"];

                        median_list.Add(value.Value["Value"]);

                        //Biggest value
                        if (value.Value["Value"] > panel_data[axis.Key]["Max"] || panel_data[axis.Key]["Max"] == 0)
                        {
                            panel_data[axis.Key]["Max"] = value.Value["Value"];
                        }
                        //Smallest value
                        if (value.Value["Value"] < panel_data[axis.Key]["Min"] || panel_data[axis.Key]["Min"] == 0)
                        {
                            panel_data[axis.Key]["Min"] = value.Value["Value"];
                        }
                    }

                    //Average value
                    panel_data[axis.Key]["Average"] /= axis.Value.Count;

                    foreach (var value in axis.Value)
                    {
                        panel_data[axis.Key]["Variance"] += Math.Pow(value.Value["Value"] - panel_data[axis.Key]["Average"], 2);
                    }
                    //Variance value
                    panel_data[axis.Key]["Variance"] = Math.Sqrt(panel_data[axis.Key]["Variance"] / axis.Value.Count);

                    //Median value
                    if (axis.Value.Count > 0)
                    {
                        if (axis.Value.Count % 2 == 1)
                        {
                            panel_data[axis.Key]["Median"] =  median_list.OrderBy(x => x).ToList()[(int)axis.Value.Count / 2];
                        }
                        else
                        {
                            panel_data[axis.Key]["Median"] = (median_list.OrderBy(x => x).ToList()[(int)median_list.Count / 2] + median_list.OrderBy(x => x).ToList()[(int)median_list.Count / 2 - 1]) / 2;
                        }
                    }

                    var skippedFirstLoop = false;
                    var first_var = 0.0;
                    var second_var = 0.0;


                    foreach (var value in axis.Value)
                    {
                        first_var = value.Value["Value"];
                        if (skippedFirstLoop)
                        {
                            if (Information.IsNumeric(value.Value["Value"]))
                            {
                                if (Math.Abs(first_var - second_var) > panel_data[axis.Key]["DeltaMax"])
                                {
                                    //Greatest change
                                    panel_data[axis.Key]["DeltaMax"] = Math.Abs(first_var - second_var);
                                }

                                panel_data[axis.Key]["DeltaAvg"] += Math.Abs(first_var - second_var);
                            }
                        }
                        else
                        {
                            skippedFirstLoop = true;
                        }
                        second_var = value.Value["Value"];
                    }
                    //Average change
                    panel_data[axis.Key]["DeltaAvg"] /= axis.Value.Count;
                }

                int valid_measurement_count = 0;
                int invalid_measurement_count = 0;
                
                //Draw viewport items
                foreach (var axis in cell_data_by_id)
                {

                    Boolean is_valid_measurement = true;

                    Point3D pt1 = new Point3D(axis.Value["X"]["Nominal"], axis.Value["Y"]["Nominal"], axis.Value["Z"]["Nominal"]);
                    Joint j1 = new Joint(pt1, 0.1, 1);
                    viewportLayout1.Entities.Add(j1, 0, Color.Black);

                    Point3D pt2 = new Point3D(axis.Value["X"]["Value"], axis.Value["Y"]["Value"], axis.Value["Z"]["Value"]);
                    Joint j2 = new Joint(pt2, 0.2, 1);
                    viewportLayout1.Entities.Add(new Line(pt1, pt2), 0, Color.Black);

                    var color = Color.Green;
                    viewportLayout1.Labels.Add(new LeaderAndText(axis.Value["X"]["Value"], axis.Value["Y"]["Value"], axis.Value["Z"]["Value"],
                            "Measurement " + axis.Key, new Font("Tahoma", 8.25f), Color.Black, new Vector2D(0, 10)));

                    if (axis.Value["X"]["Value"] > axis.Value["X"]["Nominal"] + axis.Value["X"]["UpTolerance"]  ||
                        axis.Value["X"]["Value"] < axis.Value["X"]["Nominal"] + axis.Value["X"]["LowTolerance"]  )
                    {
                        color = Color.Red;
                        var label_message = "X-axis out of tolerance\n X: " + axis.Value["X"]["Value"] + " | Valid range: " + (axis.Value["X"]["Nominal"] + axis.Value["X"]["LowTolerance"]).ToString() + " - " + (axis.Value["X"]["Nominal"] + axis.Value["X"]["UpTolerance"]).ToString();
                        viewportLayout1.Labels.Add(new LeaderAndText(axis.Value["X"]["Value"], axis.Value["Y"]["Value"], axis.Value["Z"]["Value"],
                            label_message, new Font("Tahoma", 8.25f), Color.Black, new Vector2D(0, 25)));
                        is_valid_measurement = false;
                    }
                    if (axis.Value["Y"]["Value"] > axis.Value["Y"]["Nominal"] + axis.Value["Y"]["UpTolerance"] ||
                        axis.Value["Y"]["Value"] < axis.Value["Y"]["Nominal"] + axis.Value["Y"]["LowTolerance"] )
                    {
                        color = Color.Red;
                        var label_message = "Y-axis out of tolerance\n Y: " + axis.Value["Y"]["Value"] + " | Valid range: " + (axis.Value["Y"]["Nominal"] + axis.Value["Y"]["LowTolerance"]).ToString() + " - " + (axis.Value["Y"]["Nominal"] + axis.Value["Y"]["UpTolerance"]).ToString();
                        viewportLayout1.Labels.Add(new LeaderAndText(axis.Value["X"]["Value"], axis.Value["Y"]["Value"], axis.Value["Z"]["Value"],
                            label_message, new Font("Tahoma", 8.25f), Color.Black, new Vector2D(0, 50)));
                        is_valid_measurement = false;
                    }
                    if (axis.Value["Z"]["Value"] > axis.Value["Z"]["Nominal"] + axis.Value["Z"]["UpTolerance"] ||
                        axis.Value["Z"]["Value"] < axis.Value["Z"]["Nominal"] + axis.Value["Z"]["LowTolerance"]  )
                    {
                        color = Color.Red;
                        var label_message = "Z-axis out of tolerance\n Z: " + axis.Value["Z"]["Value"] + " | Valid range: " + (axis.Value["Z"]["Nominal"] + axis.Value["Z"]["LowTolerance"]).ToString() + " - " + (axis.Value["Z"]["Nominal"] + axis.Value["Z"]["UpTolerance"]).ToString();
                        viewportLayout1.Labels.Add(new LeaderAndText(axis.Value["X"]["Value"], axis.Value["Y"]["Value"], axis.Value["Z"]["Value"],
                            label_message, new Font("Tahoma", 8.25f), Color.Black, new Vector2D(0, 75)));
                        is_valid_measurement = false;
                    }

                    if (is_valid_measurement ) {
                        valid_measurement_count++;
                    } else
                    {
                        invalid_measurement_count++;
                    }
                    
                    viewportLayout1.Entities.Add(j2, 0, color);
                }

                //Setup labels

                this.average_x_label_value.Text = (panel_data["X"]["Average"]).ToString();
                this.average_y_label_value.Text = (panel_data["Y"]["Average"]).ToString();
                this.average_z_label_value.Text = (panel_data["Z"]["Average"]).ToString();

                this.max_x_label_value.Text = (panel_data["X"]["Max"]).ToString();
                this.max_y_label_value.Text = (panel_data["Y"]["Max"]).ToString();
                this.max_z_label_value.Text = (panel_data["Z"]["Max"]).ToString();

                this.min_x_label_value.Text = (panel_data["X"]["Min"]).ToString();
                this.min_y_label_value.Text = (panel_data["Y"]["Min"]).ToString();
                this.min_z_label_value.Text = (panel_data["Z"]["Min"]).ToString();

                this.variance_x_label_value.Text = (panel_data["X"]["Variance"]).ToString();
                this.variance_y_label_value.Text = (panel_data["Y"]["Variance"]).ToString();
                this.variance_z_label_value.Text = (panel_data["Z"]["Variance"]).ToString();

                this.deltaMax_x_label_value.Text = (panel_data["X"]["DeltaMax"]).ToString();
                this.deltaMax_y_label_value.Text = (panel_data["Y"]["DeltaMax"]).ToString();
                this.deltaMax_z_label_value.Text = (panel_data["Z"]["DeltaMax"]).ToString();

                this.deltaAvg_x_label_value.Text = (panel_data["X"]["DeltaAvg"]).ToString();
                this.deltaAvg_y_label_value.Text = (panel_data["Y"]["DeltaAvg"]).ToString();
                this.deltaAvg_z_label_value.Text = (panel_data["Z"]["DeltaAvg"]).ToString();

                this.median_x_label_value.Text = (panel_data["X"]["Median"]).ToString();
                this.median_y_label_value.Text = (panel_data["Y"]["Median"]).ToString();
                this.median_z_label_value.Text = (panel_data["Z"]["Median"]).ToString();

                this.valid_measure_count_label.Text = valid_measurement_count.ToString() + " out of " + cell_data_by_id.Count.ToString();
                this.invalid_measure_count_label.Text = invalid_measurement_count.ToString() + " out of " + cell_data_by_id.Count.ToString();

                viewportLayout1.ZoomFit( 100 );
                viewportLayout1.Refresh();

            }
        }

        //Default axis value
        private void dataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["Axis"].Value = "X";
        }
    }

}
