using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataBindingHomeWork.Models
{
    public class Producer
    {
        public string Name { get; set; }

        public ICollection<Model> Models { get; set; }

        public static List<Producer> InitializeProducers(params string[] producersList)
        {
            List<Producer> producers = new List<Producer>();
            foreach (var item in producersList)
            {
                Producer prod = new Producer();
                prod.Models = new List<Model>();
                prod.Name = item;
                producers.Add(prod);
            }

            return producers;
        }
    }
}