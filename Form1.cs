namespace static_data_visuals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowResults_Click(object sender, EventArgs e)
        {
            //students chart
            chart1.Series["Students"].Points.AddXY("Cheska", 422);
            chart1.Series["Students"].Points.AddXY("Kangsan", 502);
            chart1.Series["Students"].Points.AddXY("Ej", 322);
            chart1.Series["Students"].Points.AddXY("Masae", 622);

            //teachers chart
            chart2.Series["Teachers"].Points.AddXY("t1", 422);
            chart2.Series["Teachers"].Points.AddXY("t2", 502);
            chart2.Series["Teachers"].Points.AddXY("t3", 300);
            chart2.Series["Teachers"].Points.AddXY("t4", 200);

            //performance chart
            chart3.Series["Performance"].Points.AddXY("2014", 10);
            chart3.Series["Performance"].Points.AddXY("2015", 22);
            chart3.Series["Performance"].Points.AddXY("2016", 70);
            chart3.Series["Performance"].Points.AddXY("2017", 84);

            //results chart
            chart4.Series["Results"].Points.AddXY("2014", 20);
            chart4.Series["Results"].Points.AddXY("2015", 47);
            chart4.Series["Results"].Points.AddXY("2016", 62);
            chart4.Series["Results"].Points.AddXY("2017", 85);
        }
    }
}
