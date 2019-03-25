using AutomationTesting.Endpoint;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;


namespace AutomationTesting.StepDefination
{
    [Binding]
    public sealed class APIApplication
    {

        [Given(@"I have a endpoint (.*)")]
        public void GivenIHaveAEndpointEndpoint(string endpoint)
        {
            RestAPIHelper.SetUrl(endpoint);
        }

        [When(@"I call get method of  api")]
        public void WhenICallGetMethodOfApi()
        {
            RestAPIHelper.CreateRequest();
        }

        [Then(@"the get API response in JSON format")]
        public void ThenTheGetAPIResponseInJSONFormat()
        {
            var bookTitle = "selenium";
            var apiResponse = RestAPIHelper.GetResponse();
            if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK) ;
            {

            }
            /*var deserialize = new JsonDeserializer();
            var output = deserialize.Deserialize<Dictionary<string, string>>(apiResponse);
            var result = output["title"];
            Assert.That(result, Is.EqualTo(bookTitle), "Book title is not correct");*/
            JObject json = JObject.Parse(apiResponse.Content);
            Console.WriteLine(json);
            Assert.That(json["title"].ToString, Is.EqualTo(bookTitle), "Book title is not correct");
        }

        [When(@"I call a post method to register a user")]
        public void WhenICallAPostMethodToRegisterAUser()
        {
            RestAPIHelper.CreatePostRequest();
        }

        [Then(@"i will registred sucessfully")]
        public void ThenIWillRegistredSucessfully()
        {
            var apiResponse = RestAPIHelper.GetResponse();
            Console.WriteLine(apiResponse);
            
        }


    }
}
