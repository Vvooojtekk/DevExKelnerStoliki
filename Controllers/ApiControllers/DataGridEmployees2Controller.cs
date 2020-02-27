using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using KelnerStoliki.Models.DataGrid;
using KelnerStoliki.Models.SampleData;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace KelnerStoliki.Controllers.ApiControllers
{
    public class DataGridEmployees2Controller : ApiController
    {


        [HttpGet]
        public HttpResponseMessage Get(DataSourceLoadOptions loadOptions)
        {
            ICollection<PrzedmiotZamowienia> PrzedmiotyZamowienia = ZamowieniaLista.Lista[1];

            return Request.CreateResponse(DataSourceLoader.Load(PrzedmiotyZamowienia, loadOptions));
        }

        [HttpPost]
        public HttpResponseMessage Post(FormDataCollection form)
        {
            ICollection<PrzedmiotZamowienia> PrzedmiotyZamowienia = ZamowieniaLista.Lista[1];

            var values = form.Get("values");

            var newPrzedmiotZamowienia = new PrzedmiotZamowienia();

            JsonConvert.PopulateObject(values, newPrzedmiotZamowienia);

            var Dania = SampleData.Dania.ToList();
            int DanieId = newPrzedmiotZamowienia.DanieID - 1;
            var Danie = Dania[DanieId].Name;
            newPrzedmiotZamowienia.Danie = Danie;
            newPrzedmiotZamowienia.ID = PrzedmiotyZamowienia.Count + 1;
            newPrzedmiotZamowienia.Cena = Dania[DanieId].Cena;


            Validate(newPrzedmiotZamowienia);
            if (!ModelState.IsValid)
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState.GetFullErrorMessage());

            PrzedmiotyZamowienia.Add(newPrzedmiotZamowienia);

            return Request.CreateResponse(HttpStatusCode.Created, newPrzedmiotZamowienia);
        }

        [HttpPut]
        public HttpResponseMessage Put(FormDataCollection form)
        {
            ICollection<PrzedmiotZamowienia> PrzedmiotyZamowienia = ZamowieniaLista.Lista[1];

            var key = Convert.ToInt32(form.Get("key"));
            var values = form.Get("values");

            var przedmiotZamowienia = PrzedmiotyZamowienia.First(e => e.ID == key);

            JsonConvert.PopulateObject(values, przedmiotZamowienia);

            Validate(przedmiotZamowienia);
            if (!ModelState.IsValid)
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState.GetFullErrorMessage());


            return Request.CreateResponse(HttpStatusCode.OK, przedmiotZamowienia);
        }

        [HttpDelete]
        public void Delete(FormDataCollection form)
        {
            ICollection<PrzedmiotZamowienia> PrzedmiotyZamowienia = ZamowieniaLista.Lista[1];
            var key = Convert.ToInt32(form.Get("key"));


            var employee = PrzedmiotyZamowienia.First(e => e.ID == key);

            PrzedmiotyZamowienia.Remove(employee);
        }
    }
}
