using EshopApi;
using Microsoft.AspNetCore.Mvc.Testing;
using TechTalk.SpecFlow.Assist;

namespace BasketTests.Features.Basket
{
    [Binding]
    internal class BasketStepDefinitions : IClassFixture<WebApplicationFactory<Program>>
    {
        private HttpClient _httpClient;

        public BasketStepDefinitions(WebApplicationFactory<Program> factory)
        {
            _httpClient = factory.CreateClient();
        }

        [Given(@"I have the following data")]
        public void GivenIHaveTheFollowingData(Table table)
        {
            // In this step we prepare our datastore.
        }

        [Given(@"I have a request to add product (.*)")]
        public void GivenIHaveARequestToAddProduct(int productId)
        {
            // In this step we set the product to add to the basket
        }

        [When(@"I call the Add method of the basket api")]
        public async Task WhenICallTheAddMethodOfTheBasketApi()
        {
            // In this step we actually do a call to our api
            var result = await _httpClient.GetAsync("basket");
            var response = await result.Content.ReadAsStringAsync();
            // deserialize JSON response to c# class??
        }

        [Then(@"the quantities are")]
        public void ThenTheQuantitiesAre(Table table)
        {
            // In this step we check the quantities on the result object returned by our api
            var productQuantities = table.CreateInstance<ProductQuantities>();
        }

        [Then(@"a message '([^']*)' is returned to the client")]
        public void ThenAMessageIsReturnedToTheClient(string message)
        {
            // In this step we check the message on the result object returned by our api
            throw new PendingStepException();
        }
    }
}