using TestElasticSearch.Controllers;
using TestElasticSearch.Models;
using Xunit;

namespace TestElasticSearch.Tests;

public class Tests
{
// add xunit   tests to test the AddData method in ElasticSearchService class

    [Fact]
    public async void AddDataTest()
    {
        var elasticSearchService = new ElasticSearchService();
        var dataObject = new DataObject
        {
            Category = "test1",
            Data = new
            {
                //Initialize Id with random integer value       
                
                Id = Guid.NewGuid(),
                        
                Name = "houston",
                Age = 20,
                Address = "john"
            }
        };
        var response = await elasticSearchService.AddData(dataObject.Category, dataObject.Data);
    }
//write a test case to test the ListAllIndexes method in ElasticSearchService class
    [Fact]
    public async void ListIndex()
    {
        var elasticSearchService = new ElasticSearchService();
        var response = await elasticSearchService.ListAllIndexes();
        Console.WriteLine(response.Indices);
        Assert.NotNull(response);
    }
    //add a test case to test the SearchData method in ElasticSearchService class
    [Fact]
    public async void SearchData()
    {
        var elasticSearchService = new ElasticSearchService();
        var response = await elasticSearchService.SearchData("test1","hous");
        Console.WriteLine(response.Documents);
        Assert.NotNull(response);
    }
}