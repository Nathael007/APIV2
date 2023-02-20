using Microsoft.VisualStudio.TestTools.UnitTesting;
using APIV2.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIV2.Models.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace APIV2.Controllers.Tests
{
    [TestClass()]
    public class SeriesControllerTests
    {
        [TestInitialize()]
        public void SeriesControllerTest()
        {
            var builder = new DbContextOptionsBuilder<SeriesDbContext>().UseNpgsql("Server=localhost;port=5432;Database=SeriesDB; uid=postgres;\npassword=postgres;"); // Chaine de connexion à mettre dans les ( )
            context = new SeriesDbContext(builder.Options);
            controller = new SeriesController(context);

        }

        SeriesDbContext context;
        SeriesController controller;


        [TestMethod()]
        public void GetSeriesTest()
        {
            List<Serie> serie = new List<Serie>();
            serie.Add(new Serie(138, "Charlie Jade", "Que se serait-il passé si les humains n'avaient pas abusé de la Terre et de ses ressources ? Combien le monde serait-il différent ? Faites un saut dans l'imaginaire et explorez le monde à travers 3 univers parallèles : L'Alphaverse (ce que notre monde pourrait devenir), le Betaverse (notre monde) et le Gammaverse (ce qu'aurait pu être notre monde).Charlie Jade est un détective privé dans un monde futuriste (Alphaverse) dominé par la technologie et les multinationales. Il enquête sur le meurtre d'une jeune femme inconnue... Charlie Jade est une série Sud Africaine, co-produite par le Canada, créée en 2005 par Robert Wertheimer et Chris Roland. Il s'agit d'une série originale par de nombreux aspects, notamment par le traitement visuel de l'image. La série bénéficie de décors naturels magnifiques pour le Gammaverse, sombre et futuriste à la 'Blade Runner' pour l'Alphaverse. Le téléspectateur peut ainsi identifier très facilement l'univers dans lequel se déroule chaque action. La série est tournée à Cape Town (Le Cap - Afrique du Sud)...", 1, 20, 2005, "Space"));
            Assert.AreEqual(controller.GetSeries(), serie[0]);
        }

        [TestMethod()]
        public void GetSerieTest()
        {
            Serie serie = new Serie(138, "Charlie Jade", "Que se serait-il passé si les humains n'avaient pas abusé de la Terre et de ses ressources ? Combien le monde serait-il différent ? Faites un saut dans l'imaginaire et explorez le monde à travers 3 univers parallèles : L'Alphaverse (ce que notre monde pourrait devenir), le Betaverse (notre monde) et le Gammaverse (ce qu'aurait pu être notre monde).Charlie Jade est un détective privé dans un monde futuriste (Alphaverse) dominé par la technologie et les multinationales. Il enquête sur le meurtre d'une jeune femme inconnue... Charlie Jade est une série Sud Africaine, co-produite par le Canada, créée en 2005 par Robert Wertheimer et Chris Roland. Il s'agit d'une série originale par de nombreux aspects, notamment par le traitement visuel de l'image. La série bénéficie de décors naturels magnifiques pour le Gammaverse, sombre et futuriste à la 'Blade Runner' pour l'Alphaverse. Le téléspectateur peut ainsi identifier très facilement l'univers dans lequel se déroule chaque action. La série est tournée à Cape Town (Le Cap - Afrique du Sud)...", 1, 20, 2005, "Space");
            Assert.AreEqual(controller.GetSerie(138), serie);
        }

        [TestMethod()]
        public void PutSerieTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void PostSerieTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteSerieTest()
        {
            Assert.Fail();
        }
    }
}