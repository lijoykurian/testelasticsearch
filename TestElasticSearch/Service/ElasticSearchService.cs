using Nest;
using TestElasticSearch.Models;

namespace TestElasticSearch.Controllers;
//create test case for this class

public class ElasticSearchService
{
    private readonly ElasticClient _elasticClient;
    public ElasticSearchService()
    {
        var node = new Uri("https://localhost:9200");
        var settings = new ConnectionSettings(node)
                .CertificateFingerprint("a0a51aa001e5b60c47117426ca31cda2f80910b17473f5abfde29d2b3008e942")
                .BasicAuthentication("elastic", "cAxI=RqJrohk1vF84U1o")
                .DefaultIndex("test");
        _elasticClient = new ElasticClient(settings);
    }
    //Add method to add data to index name passed as a parameter and data passed as a parameter
    public async Task<IndexResponse> AddData(string indexName, dynamic data)
    {
        var response = await _elasticClient.IndexAsync(new IndexRequest<dynamic>(data, indexName));
        return response;
    }
    //add code to list all indexes in elastic search
    public async Task<GetIndexResponse> ListAllIndexes()
    {
        var response = await _elasticClient.Indices.GetAsync(new GetIndexRequest(Indices.All));
        return response;
    }
// add a amethod to search data in elastic search
    public async Task<ISearchResponse<dynamic>> SearchData(string indexName, string searchQuery)
    {
        var response = await _elasticClient.SearchAsync<dynamic>(s => s
            .Index(indexName)
            .Query(q => q.Term(q=>q.)
                
            )
        );
        return response;
    }

}
