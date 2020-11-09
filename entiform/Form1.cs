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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Car> li = new List<Car>();
            Car c = new Car();

            c.update(li);

            AllCarsTable.DataSource = li;

            //using (CarSalonContext db = new CarSalonContext())
            //{
            //    List<Contract> contr = db.Contract.ToList();
            //    List<Car> car = db.Car.ToList();
            //    List<Person> pers = db.Person.ToList();
            //    AllCarsTable.RowCount = contr.Count;
            //    for (int i = 0; i < contr.Count(); i++)
            //    {
            //        for (int j = 0; j < car.Count(); j++)
            //        {
            //            if (contr[i].Car == car[j].IdCar)
            //            {
            //                AllCarsTable.Rows[i].Cells["Mark"].Value = car[j].Mark;
            //                AllCarsTable.Rows[i].Cells["Price"].Value = car[j].Price;
            //            }

            //        }
            //        for (int j = 0; j < pers.Count(); j++)
            //        {
            //            if (contr[i].Person == pers[j].IdPerson)
            //            {
            //                AllCarsTable.Rows[i].Cells["FName"].Value = pers[j].Fname;
            //                AllCarsTable.Rows[i].Cells["LName"].Value = pers[j].Lname;
            //                AllCarsTable.Rows[i].Cells["PName"].Value = pers[j].Pname;
            //            }
            //        }
            //        AllCarsTable.Rows[i].Cells["DealDate"].Value = contr[i].ConDate;
            //    }
            //}
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            List<Car> li = new List<Car>();
            List<Car> l = new List<Car>();
            Car ca = new Car();
            ca.update(li);

            if (Mark_t.Text != "" && size_t.Text != "")
            {
                l.Clear();
                for (int i = 0; i < li.Count; i++)
                {
                    if (Mark_t.Text == li[i].Mark && size_t.Text == li[i].Size)
                    {
                        l.Add(li[i]);
                    }
                }
                AllCarsTable.DataSource = l;
                AllCarsTable.Refresh();
            }

            else if (Mark_t.Text != "")
            {
                l.Clear();
                for (int i = 0; i < li.Count; i++)
                {
                    if (Mark_t.Text == li[i].Mark)
                    {
                        l.Add(li[i]);
                    }
                }
                AllCarsTable.DataSource = l;
                AllCarsTable.Refresh();
            }

            else if (size_t.Text != "")
            {
                l.Clear();
                for (int i = 0; i < li.Count; i++)
                {
                    if (size_t.Text == li[i].Size)
                    {
                        l.Add(li[i]);
                    }
                }
                AllCarsTable.DataSource = l;
                AllCarsTable.Refresh();
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            using (CarSalonContext db = new CarSalonContext())
            {
                List<Car> l = new List<Car>();
                Contract con = new Contract();
                Car cc = new Car();
                cc.update(l);

                foreach (DataGridViewRow drv in AllCarsTable.SelectedRows)
                {
                    int index = drv.Index;
                    int val = l[index].IdCar;
                    con = db.Contract
                        .Where(j => j.Car == val)
                        .FirstOrDefault();

                    db.Contract.Remove(con);

                    cc = db.Car
                        .Where(j => j.IdCar == val)
                        .FirstOrDefault();

                    db.Car.Remove(cc);
                    db.SaveChanges();
                    cc.update(l);
                    AllCarsTable.DataSource = l;
                    break;
                }
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            AddForm ad = new AddForm();
            ad.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Car> li = new List<Car>();
            Car c = new Car();
            c.update(li);
            AllCarsTable.DataSource = li;
        }

        private void chdnge_button_Click(object sender, EventArgs e)
        {
            using (CarSalonContext db = new CarSalonContext())
            {
                List<Car> li = new List<Car>();
                Car ca = new Car();
                ca.update(li);

                int index = AllCarsTable.CurrentCell.RowIndex;

                li[index].Mark = Mark_t.Text;

                List<Car> l = new List<Car>();
                ca.update(l);
                int val = li[index].IdCar;

                ca = db.Car
                      .Where(j => j.IdCar == val)
                      .FirstOrDefault();

                ca.Mark = li[index].Mark;

                db.SaveChanges();
                ca.update(li);
            }
        }

        private void AllCarsTable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
