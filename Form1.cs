using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Baby_Sitter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //checking values from inputs on form.
            if (startTime.Text.Contains("Start Time"))
            {
                candyFromBaby.Text = endTime.Text;
                MessageBox.Show("Please select a start time.", "Start Time Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (endTime.Text.Contains("End Time"))
            {
                MessageBox.Show("Please select an end time.", "So, you are never coming back?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (BedtimeListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select a bed time.", "Staying up all night? Awesome!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {   
                int st = 0, bt = 0, et = 0, pay = 0;
                st = Int32.Parse(startTime.SelectedItem.ToString());
                et = Int32.Parse(endTime.SelectedItem.ToString());
                //check if start time is before end time selection
                if(et<=12 && et > st || et < 5 && et > 0)
                {
                    //There is a bed time
                    if (!BedtimeListBox1.CheckedItems[0].ToString().Contains("none"))
                    {
                        bt = Int32.Parse(BedtimeListBox1.CheckedItems[0].ToString());
                        if(bt<=12 && et<=12 && bt > st)
                        {
                            if (et < bt && et > 5)
                            {
                                MessageBox.Show("Please select a bedtime between start and end times.", "Please select valid bed time.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                pay = calculatePay(st, bt, et);
                                candyFromBaby.Text = pay.ToString();
                            }
                        }
                        else if(bt > 0 && bt > et )
                        {
                            MessageBox.Show("Please select a bedtime between start and end times.", "Please select valid bed time.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if(bt <= 12 && et > 4)
                        {
                            MessageBox.Show("Please select a bedtime between start and end times.", "Please select valid bed time.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            pay = calculatePay(st, bt, et);
                            candyFromBaby.Text = pay.ToString();
                        }
                    }

                    //there is no bed time
                    else
                    {
                        //total up earnings
                        pay = calculatePay(st, bt, et);
                        //write out total to label
                        candyFromBaby.Text = pay.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Please select an end time later than the start time.", "Please select valid end time.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private int calculatePay(int st, int bt, int et)
        {
            int startToBed = 0, midToEnd = 0, bedToEnd = 0, total = 0, bedToMid = 0;
            //calculate start-time to endtime with bedtime before midnight and endtime before or equal to midnight
            if (bt != 0)
            {
                if (bt <= 12 && bt > 5 && et <= 12 && et > 4)
                {
                    startToBed = (bt - st) * 12;
                    bedToEnd = (et - bt) * 8;
                    total = startToBed + bedToEnd;
                }
                //calculating time from start time to end time with bedtime before midnight and endtime after midnight
                else if (bt < 12 && bt > 4 && et < 5)
                {
                    startToBed = (bt - st) * 12;
                    bedToMid = (12 - bt) * 8;
                    midToEnd = et * 16;
                    total = startToBed + bedToMid + midToEnd;
                }
                //calculating time after midnight with bedtime later than or equal to midnight
                else 
                {
                    startToBed = (12 - st) * 12;
                    midToEnd = et * 16;
                    total = startToBed + midToEnd;
                }
            }
            //calculate hours with no bed time and not past midnight
            else
            {
                total = (et - st) * 12;
            } 
            return total;
        }

    }

}
