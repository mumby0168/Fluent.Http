using Fluent.Http.Requests;
using FluentAssertions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Xunit;

namespace Fluent.Http.GitHub.Sample
{
    public class GitHubIssue
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }
    }

    public class GitHubIssueComment
    {

        [JsonProperty("id")] 
        public int Id { get; set; }

        [JsonProperty("issue_url")] 
        public string IssueUrl { get; set; } = string.Empty;

    }
    
    
    public class GitHubTests
    {
        [Fact]
        public async Task GitHubApiTestSample()
        {
            HttpClient client = new() { BaseAddress = new Uri("https://api.github.com/") };
            FluentHttpOptions githubFluentOptions = new() { JsonSerializerSettings = new JsonSerializerSettings() { } };
            IFluentHttpClient<GitHubTestContext> fluentClient = FluentHttpClient<GitHubTestContext>.Build(client, githubFluentOptions);

            await fluentClient
                .GetIssues("mumby0168", "Fluent.Http", async response =>
                {
                    HttpResponseMessage httpResponseMessage = response.Message;
                    
                    httpResponseMessage.Should().Be200Ok();
                    
                    List<GitHubIssue>? issues = await httpResponseMessage.Content.ReadFromJsonAsync<List<GitHubIssue>>();

                    issues.Should().NotBeNull();

                    issues!.Count.Should().BeGreaterThan(1);
                    response.Context.IssueNumber = issues.First().Number;
                })
                .GetIssueComments("mumby0168", "Fluent.Http")
                
                .ExecuteAsync();
        }

    }
}