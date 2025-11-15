using HotelListing.API.Core.Repository;
using HotelListing.API.Data;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Net.Http;
using HotelListing.API;
using HotelListing.API.Controllers;
using AutoMapper;
using HotelListing.API.Data.Confirgurations;


namespace HotelListingAPIUnitTests


{
    public class UnitTest1
    {
        private HotelListingDbContext m_listingDbContext;
        private readonly HotelsRepository m_mockHotelsRepo;
        private HttpClient _httpClient;

        // = Substitute.For<IRepository<Basket>>();
        //private readonly IAppLogger<BasketService> _mockLogger = Substitute.For<IAppLogger<BasketService>>();

        public  UnitTest1() {
           // DbContextOptions dbOptions = HotelListingDbContextFactory(;// new DbContextOptionsBuilder<HotelListingDbContext>().Options.da;
                                                                       // .UseInMemoryDatabase(databaseName: "TestCatalog")
                                                                       // .Options;
                                                                       // _catalogContext = new CatalogContext(dbOptions);
            
            HotelListingDbContextFactory hotelsDbFact = new();
            string[] args = new string[1];
            m_listingDbContext = hotelsDbFact.CreateDbContext(args);// HotelListingDbContext(dbOptions);
            m_mockHotelsRepo = new HotelsRepository(m_listingDbContext, null);

            _httpClient = new HttpClient();
        }

        [Fact]
        public void Test1()
        {
            //Act
           var tmpRes = m_mockHotelsRepo.GetAllAsync();
           // assert
           Assert.NotNull(tmpRes);         
        }


        /// <summary>
        /// TODO
        /// </summary>
        /// <returns></returns>
        //[Fact]
        //public async Task Test2()
        //{
        //    //Act
        //    var url = @"https://localhost:7071/api/HotelManager/-1";// + PRICES_ENDPOINT;

        //    HttpResponseMessage response = await _httpClient.GetAsync(url);

        //    string serialized = await response.Content.ReadAsStringAsync();
        //    var result = JsonConvert
        //        .DeserializeObject<Dictionary<string, Dictionary<string, double?>>>(serialized);

        //   // assert
        //   Assert.NotNull(result);
        //}

        [Fact]
        public void Test3()
        {
            HotelManagerController ho = new HotelManagerController(m_listingDbContext);
            //Act
            var tmpRes = ho.GetHotelManager(-1);
           
            // assert
            Assert.NotNull(tmpRes);
        }



        [Fact]
        public void Test4()
        {
            HotelDescriptionsController hoDescr = new HotelDescriptionsController(m_listingDbContext);


            var reponse = hoDescr.GetHotelDescription(1);
            //ConfigurationP
            //CountriesController contCtrl = new CountriesController(

            //    new Mapper(, 
            //    new CountriesRepository(m_listingDbContext), new Logger());
            ////Act
            //var tmpRes = contCtrl.GetCountry(1);

            // assert
            Assert.NotNull(reponse);
        }


    }
}