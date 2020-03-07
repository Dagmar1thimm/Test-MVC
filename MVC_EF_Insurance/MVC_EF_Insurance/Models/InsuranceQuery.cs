using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_EF_Insurance.Models
{
    public class InsuranceQuery
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public DateTime birthdate { get; set; }
        public int car_year { get; set; }
        public string car_make { get; set; }
        public string car_model { get; set; }
        public int tickets { get; set; }
        public bool dui { get; set; }
        public bool coverage_full { get; set; }
        public float calculated_rate { get; set; }

        public InsuranceQuery()
        {
        }

        //public float getQuote()
        //{
        //    const float baserate = 50.0f;

        //    calculated_rate = baserate;

        //    int age = DateTime.Now.Year - birthdate.Year;

        //    if (age < 25) calculated_rate += 25.0f;
        //    if (age < 18) calculated_rate += 75.0f;
        //    if (age > 100) calculated_rate += 25.0f;
        //    if (car_year < 2000) calculated_rate += 25.0f;
        //    if (car_year > 2015) calculated_rate += 25.0f;
        //    if (car_make == "Porsche") calculated_rate += 25.0f;
        //    if (car_model == "911") calculated_rate += 25.0f;
        //    calculated_rate += tickets * 10.0f;
        //    if (dui) calculated_rate *= 1.25f;
        //    if (coverage_full) calculated_rate *= 1.5f;

        //    Console.WriteLine("Insurance quote: " + calculated_rate);

        //    return calculated_rate;
        //}
    }
}