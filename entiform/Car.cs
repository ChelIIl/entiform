using System;
using System.Collections.Generic;

namespace entiform
{
    public partial class Car
    {
        public Car()
        {
            Contract = new HashSet<Contract>();
        }

        public int IdCar { get; set; }
        public string Mark { get; set; }
        public DateTime IssueYear { get; set; }
        public int Mileage { get; set; }
        public decimal Price { get; set; }
        public string Size { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Contract> Contract { get; set; }

        public void addCar(string mark_t, DateTime year_t, int mileage_t, int price_t, string size_t, string desc_t)
        {
            using (CarSalonContext db = new CarSalonContext())
            {
                Car car = new Car();
                car.Mark = mark_t;
                car.IssueYear = Convert.ToDateTime(year_t);
                car.Mileage = mileage_t;
                car.Price = Convert.ToDecimal(price_t);
                car.Size = size_t;
                car.Description = desc_t;
                db.Car.Add(car);
                db.SaveChanges();
            }
        }

        public void update(List<Car> li)
        {
            using (CarSalonContext db = new CarSalonContext())
            {
                li.Clear();

                foreach (Car car in db.Car)
                {
                    Car ca = new Car();
                    ca.IdCar = car.IdCar;
                    ca.Mark = car.Mark;
                    ca.IssueYear = car.IssueYear;
                    ca.Mileage = car.Mileage;
                    ca.Price = car.Price;
                    ca.Size = car.Size;
                    ca.Description = car.Description;
                    li.Add(ca);
                }
            }
        }
    }
}
