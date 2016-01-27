using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataBindingHomeWork.Models
{
    public class Model
    {
        public string Name { get; set; }

        public static ICollection<Model> InitializeModels(params string[] modelsList)
        {
            ICollection<Model> models = new List<Model>();
            foreach(var model in modelsList)
            {
                Model mod = new Model();
                mod.Name = model;
                models.Add(mod);
            }
            return models;
        }
    }
}