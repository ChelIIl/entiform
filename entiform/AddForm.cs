using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entiform
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            Car c = new Car();
            string mark = Convert.ToString(Mark_t.Text);
            DateTime year = Convert.ToDateTime(date.Text);
            int probeg = Convert.ToInt32(mileage_t.Text);
            int price = Convert.ToInt32(price_t.Text);
            string size = Convert.ToString(size_t.Text);
            string descript = Convert.ToString(desc_t.Text);

            //c.addCar(mark, year, probeg, price, size, descript);

            AddForm ad = new AddForm();
            ad.Close();
        }
    }
}
