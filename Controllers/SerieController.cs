﻿using csharp_boolflix.Data.Repository;
using csharp_boolflix.Data;
using csharp_boolflix.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace csharp_boolflix.Controllers
{
    [Authorize]
    [Route("[controller]/[action]/{id?}", Order = 0)]
    public class SerieController : Controller
    {
        ISerieRepository serieRepository;
        BoolflixDbContext db; // da toglire quando ci saranno tutti i repository
        public SerieController(ISerieRepository _serieRepository, BoolflixDbContext _db) : base()
        {
            serieRepository = _serieRepository;
            db = _db;
        }
        public IActionResult Index()
        {
            List<Serie> serie = serieRepository.All();
            return View(serie);
        }
        public IActionResult Detail(int id)
        {
            Serie serie = serieRepository.GetById(id);
            return View(serie);
        }
        public IActionResult Create()
        {
            FormSerie formSerie = new FormSerie();
            formSerie.Serie = new Serie();
            formSerie.Attori = db.Attori.ToList();
            formSerie.Registi = db.Registi.ToList();
            formSerie.Caratteristiche = db.Caratteristiche.ToList();
            formSerie.Generi = db.Generi.ToList();
            return View(formSerie);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(FormSerie formSerie)
        {
            if (!ModelState.IsValid)
            {
                return View(formSerie);
            }
            List<Attore> attori = db.Attori.ToList();
            List<Caratteristica> caratteristiche = db.Caratteristiche.ToList();
            List<Genere> generi = db.Generi.ToList();
            Regia regista = db.Registi.Where(r => r.Id == formSerie.Serie.RegiaId).FirstOrDefault();
            Serie serie = serieRepository.Create(formSerie.Serie, caratteristiche, generi, attori, regista);

            return RedirectToAction("Detail", new { id = serie.Id });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            Serie serie = serieRepository.GetById(id);

            if (serie == null)
                return View("NotFound", "La serie cercata non è stata trovata");

            serieRepository.Delete(serie);

            return RedirectToAction("Index");
        }

        public IActionResult AddStagione(int id)
        {
            Stagione stagione = new Stagione();
            stagione.SerieId = id;
            return View(stagione);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddStagione(Stagione stagione, int id)
        {
            stagione.SerieId = id;
            serieRepository.AddStagione(stagione);
            return RedirectToAction("Detail", new { id = stagione.SerieId });
        }
    }
}
