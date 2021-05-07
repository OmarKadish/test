using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class PersonManagementController : Controller
    {

        public IActionResult Index() //Listeleme
        {
            //Musteri ----> (Ahmet,Çokçalışır, Toki,..... )

            // ViewBag.Adi = "Ahmet";
            // ViewBag.Soyadi = "Çokçalışır";
            // ViewBag.Adresi = "Toki";

            // var musteri= new Musteri
            // {
            //     Id=1, Adi="Ahmet", Soyadi="balsever", Adresi="Toki"
            // };
            // var musteri1= new Musteri
            // {
            //     Id=2, Adi="Mehmet", Soyadi="Aslan", Adresi="Toki"
            // };
            // var musteri2= new Musteri
            // {
            //     Id=3, Adi="Omar", Soyadi="Koşar", Adresi="Toki"
            // };

            // var Musterler= new List<Musteri>
            // {
            //     musteri, musteri1, musteri2
            // };

            var SanalMusterler= new List<Person>
            {
                new Person{Id=1, Name="Ahmet", LastName="balsever", PhoneNumber=05522997016},
                new Person{Id=2, Name="Mehmet", LastName="Aslan", PhoneNumber=05522997016},
                new Person{Id=3, Name="Omar", LastName="Koşar", PhoneNumber=05522997016},
            };

            return View(SanalMusterler);
        }
    }
    
}