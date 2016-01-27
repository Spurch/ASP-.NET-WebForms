using DataBindingHomeWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataBindingHomeWork
{
    public partial class _Default : Page
    {
        private static List<Producer> Producers;
        private static List<Extra> Extras;
        private static string selectedProducer = "";

        protected void Page_Init(object sender, EventArgs e)
        {
            Extras = Extra.InitializeExtras("ABS", "ESP", "AC", "Central Locking", "Seat Heating");
            Producers = Producer.InitializeProducers("Mercedes", "Opel", "Renault");
            Producers[0].Models = Model.InitializeModels("CLK200", "E270", "GL320");
            Producers[1].Models = Model.InitializeModels("Kadett", "Vectra", "Elantra");
            Producers[2].Models = Model.InitializeModels("Clio", "Megane", "Scenic");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                if (ProducerSelect.SelectedValue == "" || ModelSelect.SelectedValue != "")
                {
                    return;
                }
                else
                {
                    selectedProducer = ProducerSelect.SelectedValue;
                    var prod = Producers.Where(x => x.Name == selectedProducer).First();
                    ModelSelect.DataSource = prod.Models;
                    ModelSelect.DataTextField = "Name";
                    ModelSelect.DataValueField = "Name";
                    ModelSelect.DataBind();
                    ModelSelect.Items.Insert(0, new ListItem("", ""));
                }
            }
            else
            {
                ProducerSelect.DataSource = Producers;
                ProducerSelect.DataTextField = "Name";
                ProducerSelect.DataValueField = "Name";
                ProducerSelect.DataBind();
                ProducerSelect.Items.Insert(0, new ListItem("", ""));

                ExtraSelect.DataSource = Extras;
                ExtraSelect.DataTextField = "Name";
                ExtraSelect.DataValueField = "Name";
                ExtraSelect.DataBind();
            }
        }

        protected void SearchCars(object sender, EventArgs e)
        {
            List<string> selectedValues = ExtraSelect.Items.Cast<ListItem>()
                .Where(li => li.Selected)
                .Select(li => li.Value)
                .ToList();


            resultProducerLabel.Text = "Producer: ";
            resultProducer.Text = ProducerSelect.SelectedValue;

            resultModelLabel.Text = "Model: ";
            resultModel.Text = ModelSelect.SelectedValue;

            resultExtrasLabel.Text = "Extras: ";
            resultExtras.Text = string.Join(",", selectedValues.ToArray());

            resultEngineTypeLabel.Text = "Engine type: ";
            resultEngineType.Text = EngineSelect.SelectedValue;
        }
    }
}