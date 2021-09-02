using Fluent.Http.Abstractions;
using System;
using System.Threading.Tasks;

namespace Fluent.Http.GitHub.Sample
{
    public static class GitHubTestsExtensions
    {

        public static IFluentHttpClient<GitHubTestContext> GetIssues(this IFluentHttpClient<GitHubTestContext> client, string owner, string repository, Func<Response<GitHubTestContext>, Task>? responseValidator = null)
        {
            
        }
        
        public static IFluentHttpClient<GitHubTestContext> GetIssueComments(this IFluentHttpClient<GitHubTestContext> client, string owner, string repository, Func<Response<GitHubTestContext>, Task>? responseValidator = null)
        {
            
        }
    }
}