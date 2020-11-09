using System;
using System.Collections.Generic;

namespace entiform
{
    public partial class CarPersCuntr
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Lname { get; set; }
        public string Fname { get; set; }
        public string Pname { get; set; }
        public DateTime ConDate { get; set; }

        public void update(List<CarPersCuntr> li)
        {
            using (CarSalonContext db = new CarSalonContext())
            {
                li.Clear();

                foreach (CarPersCuntr car in db.CarPersCuntr)
                {
                    CarPersCuntr ca = new CarPersCuntr();
                    ca.Name = car.Name;
                    ca.Price = car.Price;
                    ca.Lname = car.Lname;
                    ca.Fname = car.Fname;
                    ca.Pname = car.Pname;
                    ca.ConDate = car.ConDate;
                    li.Add(ca);
                }
            }
        }
    }
}
