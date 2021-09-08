<!-- markdownlint-capture -->
<!-- markdownlint-disable -->

# Code Metrics

This file is dynamically maintained by a bot, *please do not* edit this by hand. It represents various [code metrics](https://aka.ms/dotnet/code-metrics), such as cyclomatic complexity, maintainability index, and so on.

<div id='fluent-http-dog-api-integration-tests'></div>

## Fluent.Http.Dog.Api.Integration.Tests :heavy_check_mark:

The *Fluent.Http.Dog.Api.Integration.Tests.csproj* project file contains:

- 4 namespaces.
- 4 named types.
- 147 total lines of source code.
- Approximately 68 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

<details>
<summary>
  <strong id="fluent-http-dog-api-integration-tests-abstractions">
    Fluent.Http.Dog.Api.Integration.Tests.Abstractions :heavy_check_mark:
  </strong>
</summary>
<br>

The `Fluent.Http.Dog.Api.Integration.Tests.Abstractions` namespace contains 1 named types.

- 1 named types.
- 18 total lines of source code.
- Approximately 3 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

<details>
<summary>
  <strong id="dogapiintegrationtest">
    DogApiIntegrationTest :heavy_check_mark:
  </strong>
</summary>
<br>

- The `DogApiIntegrationTest` contains 4 members.
- 15 total lines of source code.
- Approximately 3 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [9](https://github.com/mumby0168/Fluent.Http/blob/main/samples/Fluent.Http.Dog.Api.Integration.Tests/Abstractions/DogApiIntegrationTest.cs#L9 "DogApiIntegrationTest.DogApiIntegrationTest()") | 80 | 1 :heavy_check_mark: | 0 | 4 | 6 / 3 |
| Property | [18](https://github.com/mumby0168/Fluent.Http/blob/main/samples/Fluent.Http.Dog.Api.Integration.Tests/Abstractions/DogApiIntegrationTest.cs#L18 "HttpClient DogApiIntegrationTest.Client") | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | [20](https://github.com/mumby0168/Fluent.Http/blob/main/samples/Fluent.Http.Dog.Api.Integration.Tests/Abstractions/DogApiIntegrationTest.cs#L20 "TodoWebApplicationFactory DogApiIntegrationTest.Factory") | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | [16](https://github.com/mumby0168/Fluent.Http/blob/main/samples/Fluent.Http.Dog.Api.Integration.Tests/Abstractions/DogApiIntegrationTest.cs#L16 "IServiceProvider DogApiIntegrationTest.ServiceProvider") | 100 | 1 :heavy_check_mark: | 0 | 1 | 1 / 0 |

<a href="#fluent-http-dog-api-integration-tests-abstractions">:top: back to Fluent.Http.Dog.Api.Integration.Tests.Abstractions</a>

</details>

</details>

<details>
<summary>
  <strong id="fluent-http-dog-api-integration-tests-extensions">
    Fluent.Http.Dog.Api.Integration.Tests.Extensions :heavy_check_mark:
  </strong>
</summary>
<br>

The `Fluent.Http.Dog.Api.Integration.Tests.Extensions` namespace contains 1 named types.

- 1 named types.
- 25 total lines of source code.
- Approximately 17 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

<details>
<summary>
  <strong id="dogapiextensions">
    DogApiExtensions :heavy_check_mark:
  </strong>
</summary>
<br>

- The `DogApiExtensions` contains 5 members.
- 22 total lines of source code.
- Approximately 17 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [11](https://github.com/mumby0168/Fluent.Http/blob/main/samples/Fluent.Http.Dog.Api.Integration.Tests/Extensions/DogApiExtensions.cs#L11 "IFluentHttpClient DogApiExtensions.CreateDog(IFluentHttpClient client, Func<DogModel> dog, Func<HttpResponseMessage, Task>? response = null)") | 79 | 1 :heavy_check_mark: | 0 | 8 | 2 / 3 |
| Method | [25](https://github.com/mumby0168/Fluent.Http/blob/main/samples/Fluent.Http.Dog.Api.Integration.Tests/Extensions/DogApiExtensions.cs#L25 "IFluentHttpClient DogApiExtensions.DeleteDog(IFluentHttpClient client, Func<string> id, Func<HttpResponseMessage, Task>? response = null)") | 80 | 1 :heavy_check_mark: | 0 | 7 | 2 / 3 |
| Method | [22](https://github.com/mumby0168/Fluent.Http/blob/main/samples/Fluent.Http.Dog.Api.Integration.Tests/Extensions/DogApiExtensions.cs#L22 "IFluentHttpClient DogApiExtensions.GetDog(IFluentHttpClient client, Func<string> id, Func<HttpResponseMessage, Task>? response = null)") | 80 | 1 :heavy_check_mark: | 0 | 7 | 2 / 3 |
| Method | [28](https://github.com/mumby0168/Fluent.Http/blob/main/samples/Fluent.Http.Dog.Api.Integration.Tests/Extensions/DogApiExtensions.cs#L28 "IFluentHttpClient DogApiExtensions.GetDogs(IFluentHttpClient client, Func<HttpResponseMessage, Task>? response = null)") | 80 | 1 :heavy_check_mark: | 0 | 6 | 2 / 3 |
| Method | [14](https://github.com/mumby0168/Fluent.Http/blob/main/samples/Fluent.Http.Dog.Api.Integration.Tests/Extensions/DogApiExtensions.cs#L14 "IFluentHttpClient DogApiExtensions.IncrementDogsAge(IFluentHttpClient client, Func<DogModel> dog, Func<HttpResponseMessage, Task>? response = null)") | 73 | 1 :heavy_check_mark: | 0 | 8 | 7 / 5 |

<a href="#fluent-http-dog-api-integration-tests-extensions">:top: back to Fluent.Http.Dog.Api.Integration.Tests.Extensions</a>

</details>

</details>

<details>
<summary>
  <strong id="fluent-http-dog-api-integration-tests-factories">
    Fluent.Http.Dog.Api.Integration.Tests.Factories :heavy_check_mark:
  </strong>
</summary>
<br>

The `Fluent.Http.Dog.Api.Integration.Tests.Factories` namespace contains 1 named types.

- 1 named types.
- 15 total lines of source code.
- Approximately 4 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

<details>
<summary>
  <strong id="todowebapplicationfactory">
    TodoWebApplicationFactory :heavy_check_mark:
  </strong>
</summary>
<br>

- The `TodoWebApplicationFactory` contains 1 members.
- 12 total lines of source code.
- Approximately 4 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [11](https://github.com/mumby0168/Fluent.Http/blob/main/samples/Fluent.Http.Dog.Api.Integration.Tests/Factories/TodoWebApplicationFactory.cs#L11 "void TodoWebApplicationFactory.ConfigureWebHost(IWebHostBuilder builder)") | 83 | 1 :heavy_check_mark: | 0 | 4 | 9 / 4 |

<a href="#fluent-http-dog-api-integration-tests-factories">:top: back to Fluent.Http.Dog.Api.Integration.Tests.Factories</a>

</details>

</details>

<details>
<summary>
  <strong id="fluent-http-dog-api-integration-tests">
    Fluent.Http.Dog.Api.Integration.Tests :heavy_check_mark:
  </strong>
</summary>
<br>

The `Fluent.Http.Dog.Api.Integration.Tests` namespace contains 1 named types.

- 1 named types.
- 89 total lines of source code.
- Approximately 44 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

<details>
<summary>
  <strong id="dogapitests">
    DogApiTests :heavy_check_mark:
  </strong>
</summary>
<br>

- The `DogApiTests` contains 4 members.
- 86 total lines of source code.
- Approximately 44 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Field | [18](https://github.com/mumby0168/Fluent.Http/blob/main/samples/Fluent.Http.Dog.Api.Integration.Tests/DogApiTests.cs#L18 "IRepository<DogModel> DogApiTests._dogRepository") | 100 | 0 :heavy_check_mark: | 0 | 2 | 1 / 0 |
| Method | [20](https://github.com/mumby0168/Fluent.Http/blob/main/samples/Fluent.Http.Dog.Api.Integration.Tests/DogApiTests.cs#L20 "DogApiTests.DogApiTests()") | 95 | 1 :heavy_check_mark: | 0 | 4 | 1 / 1 |
| Method | [23](https://github.com/mumby0168/Fluent.Http/blob/main/samples/Fluent.Http.Dog.Api.Integration.Tests/DogApiTests.cs#L23 "Task DogApiTests.CreateDogThenTryAndCreateAnotherWithSameNameBreadShouldReturnBadRequestUsingRawApi()") | 57 | 1 :heavy_check_mark: | 0 | 7 | 31 / 17 |
| Method | [55](https://github.com/mumby0168/Fluent.Http/blob/main/samples/Fluent.Http.Dog.Api.Integration.Tests/DogApiTests.cs#L55 "Task DogApiTests.ExerciseApiCreateReadUpdateReadAgainThenDeleteADogThenEnsureNoDogs()") | 52 | 1 :heavy_check_mark: | 0 | 8 | 47 / 26 |

<a href="#fluent-http-dog-api-integration-tests">:top: back to Fluent.Http.Dog.Api.Integration.Tests</a>

</details>

</details>

<a href="#fluent-http-dog-api-integration-tests">:top: back to Fluent.Http.Dog.Api.Integration.Tests</a>

<div id='fluent-http-dog-api'></div>

## Fluent.Http.Dog.Api :heavy_check_mark:

The *Fluent.Http.Dog.Api.csproj* project file contains:

- 3 namespaces.
- 4 named types.
- 137 total lines of source code.
- Approximately 45 lines of executable code.
- The highest cyclomatic complexity is 5 :heavy_check_mark:.

<details>
<summary>
  <strong id="fluent-http-dog-api">
    Fluent.Http.Dog.Api :heavy_check_mark:
  </strong>
</summary>
<br>

The `Fluent.Http.Dog.Api` namespace contains 2 named types.

- 2 named types.
- 42 total lines of source code.
- Approximately 10 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

<details>
<summary>
  <strong id="program">
    Program :heavy_check_mark:
  </strong>
</summary>
<br>

- The `Program` contains 2 members.
- 12 total lines of source code.
- Approximately 3 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [17](https://github.com/mumby0168/Fluent.Http/blob/main/samples/Fluent.Http.Dog.Api/Program.cs#L17 "IHostBuilder Program.CreateHostBuilder(string[] args)") | 91 | 1 :heavy_check_mark: | 0 | 2 | 6 / 2 |
| Method | [14](https://github.com/mumby0168/Fluent.Http/blob/main/samples/Fluent.Http.Dog.Api/Program.cs#L14 "void Program.Main(string[] args)") | 97 | 1 :heavy_check_mark: | 0 | 2 | 2 / 1 |

<a href="#fluent-http-dog-api">:top: back to Fluent.Http.Dog.Api</a>

</details>

<details>
<summary>
  <strong id="startup">
    Startup :heavy_check_mark:
  </strong>
</summary>
<br>

- The `Startup` contains 2 members.
- 24 total lines of source code.
- Approximately 7 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [24](https://github.com/mumby0168/Fluent.Http/blob/main/samples/Fluent.Http.Dog.Api/Startup.cs#L24 "void Startup.Configure(IApplicationBuilder app, IWebHostEnvironment env)") | 78 | 1 :heavy_check_mark: | 0 | 3 | 12 / 4 |
| Method | [15](https://github.com/mumby0168/Fluent.Http/blob/main/samples/Fluent.Http.Dog.Api/Startup.cs#L15 "void Startup.ConfigureServices(IServiceCollection services)") | 81 | 1 :heavy_check_mark: | 0 | 2 | 8 / 3 |

<a href="#fluent-http-dog-api">:top: back to Fluent.Http.Dog.Api</a>

</details>

</details>

<details>
<summary>
  <strong id="fluent-http-dog-api-controllers">
    Fluent.Http.Dog.Api.Controllers :heavy_check_mark:
  </strong>
</summary>
<br>

The `Fluent.Http.Dog.Api.Controllers` namespace contains 1 named types.

- 1 named types.
- 84 total lines of source code.
- Approximately 32 lines of executable code.
- The highest cyclomatic complexity is 5 :heavy_check_mark:.

<details>
<summary>
  <strong id="dogcontroller">
    DogController :heavy_check_mark:
  </strong>
</summary>
<br>

- The `DogController` contains 7 members.
- 81 total lines of source code.
- Approximately 32 lines of executable code.
- The highest cyclomatic complexity is 5 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Field | [16](https://github.com/mumby0168/Fluent.Http/blob/main/samples/Fluent.Http.Dog.Api/Controllers/DogController.cs#L16 "IRepository<DogModel> DogController._repository") | 100 | 0 :heavy_check_mark: | 0 | 2 | 1 / 0 |
| Method | [18](https://github.com/mumby0168/Fluent.Http/blob/main/samples/Fluent.Http.Dog.Api/Controllers/DogController.cs#L18 "DogController.DogController(IRepository<DogModel> repository)") | 96 | 1 :heavy_check_mark: | 0 | 2 | 1 / 1 |
| Method | [79](https://github.com/mumby0168/Fluent.Http/blob/main/samples/Fluent.Http.Dog.Api/Controllers/DogController.cs#L79 "ValueTask<IActionResult> DogController.DeleteDog(string dogId)") | 75 | 1 :heavy_check_mark: | 0 | 8 | 14 / 5 |
| Method | [25](https://github.com/mumby0168/Fluent.Http/blob/main/samples/Fluent.Http.Dog.Api/Controllers/DogController.cs#L25 "ValueTask<IActionResult> DogController.GetDog(string dogId)") | 77 | 1 :heavy_check_mark: | 0 | 8 | 12 / 4 |
| Method | [21](https://github.com/mumby0168/Fluent.Http/blob/main/samples/Fluent.Http.Dog.Api/Controllers/DogController.cs#L21 "ValueTask<IActionResult> DogController.GetDogs()") | 86 | 1 :heavy_check_mark: | 0 | 6 | 3 / 2 |
| Method | [38](https://github.com/mumby0168/Fluent.Http/blob/main/samples/Fluent.Http.Dog.Api/Controllers/DogController.cs#L38 "ValueTask<IActionResult> DogController.NewDog(DogModel dog)") | 63 | 5 :heavy_check_mark: | 0 | 8 | 23 / 9 |
| Method | [62](https://github.com/mumby0168/Fluent.Http/blob/main/samples/Fluent.Http.Dog.Api/Controllers/DogController.cs#L62 "ValueTask<IActionResult> DogController.UpdateDog(DogModel dog)") | 63 | 3 :heavy_check_mark: | 0 | 8 | 16 / 9 |

<a href="#fluent-http-dog-api-controllers">:top: back to Fluent.Http.Dog.Api.Controllers</a>

</details>

</details>

<details>
<summary>
  <strong id="fluent-http-dog-api-models">
    Fluent.Http.Dog.Api.Models :heavy_check_mark:
  </strong>
</summary>
<br>

The `Fluent.Http.Dog.Api.Models` namespace contains 1 named types.

- 1 named types.
- 11 total lines of source code.
- Approximately 3 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

<details>
<summary>
  <strong id="dogmodel">
    DogModel :heavy_check_mark:
  </strong>
</summary>
<br>

- The `DogModel` contains 3 members.
- 8 total lines of source code.
- Approximately 3 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Property | [11](https://github.com/mumby0168/Fluent.Http/blob/main/samples/Fluent.Http.Dog.Api/Models/DogModel.cs#L11 "int DogModel.Age") | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Property | [7](https://github.com/mumby0168/Fluent.Http/blob/main/samples/Fluent.Http.Dog.Api/Models/DogModel.cs#L7 "string DogModel.Breed") | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Property | [9](https://github.com/mumby0168/Fluent.Http/blob/main/samples/Fluent.Http.Dog.Api/Models/DogModel.cs#L9 "string DogModel.Name") | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 1 |

<a href="#fluent-http-dog-api-models">:top: back to Fluent.Http.Dog.Api.Models</a>

</details>

</details>

<a href="#fluent-http-dog-api">:top: back to Fluent.Http.Dog.Api</a>

<div id='fluent-http'></div>

## Fluent.Http :heavy_check_mark:

The *Fluent.Http.csproj* project file contains:

- 2 namespaces.
- 9 named types.
- 348 total lines of source code.
- Approximately 59 lines of executable code.
- The highest cyclomatic complexity is 3 :heavy_check_mark:.

<details>
<summary>
  <strong id="fluent-http-abstractions">
    Fluent.Http.Abstractions :heavy_check_mark:
  </strong>
</summary>
<br>

The `Fluent.Http.Abstractions` namespace contains 3 named types.

- 3 named types.
- 68 total lines of source code.
- Approximately 6 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

<details>
<summary>
  <strong id="ifluenthttpclient">
    IFluentHttpClient :heavy_check_mark:
  </strong>
</summary>
<br>

- The `IFluentHttpClient` contains 5 members.
- 37 total lines of source code.
- Approximately 6 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [43](https://github.com/mumby0168/Fluent.Http/blob/main/src/Fluent.Http/Abstractions/IFluentHttpClient.cs#L43 "Task IFluentHttpClient.ExecuteAsync()") | 100 | 1 :heavy_check_mark: | 0 | 1 | 4 / 0 |
| Method | [22](https://github.com/mumby0168/Fluent.Http/blob/main/src/Fluent.Http/Abstractions/IFluentHttpClient.cs#L22 "IFluentHttpClient IFluentHttpClient.Request(Func<Task<HttpRequestMessage>> request, Func<HttpResponseMessage, Task>? response = null)") | 87 | 1 :heavy_check_mark: | 0 | 7 | 7 / 2 |
| Method | [30](https://github.com/mumby0168/Fluent.Http/blob/main/src/Fluent.Http/Abstractions/IFluentHttpClient.cs#L30 "IFluentHttpClient IFluentHttpClient.Request(Func<HttpRequestMessage> request, Func<HttpResponseMessage, Task>? response = null)") | 87 | 1 :heavy_check_mark: | 0 | 6 | 7 / 2 |
| Method | [38](https://github.com/mumby0168/Fluent.Http/blob/main/src/Fluent.Http/Abstractions/IFluentHttpClient.cs#L38 "IFluentHttpClient IFluentHttpClient.Step(Func<Task> step, Func<Task>? postStep = null)") | 87 | 1 :heavy_check_mark: | 0 | 3 | 7 / 2 |
| Property | [14](https://github.com/mumby0168/Fluent.Http/blob/main/src/Fluent.Http/Abstractions/IFluentHttpClient.cs#L14 "List<IFluentStep> IFluentHttpClient.Steps") | 100 | 1 :heavy_check_mark: | 0 | 2 | 5 / 0 |

<a href="#fluent-http-abstractions">:top: back to Fluent.Http.Abstractions</a>

</details>

<details>
<summary>
  <strong id="ifluentstep">
    IFluentStep :heavy_check_mark:
  </strong>
</summary>
<br>

- The `IFluentStep` contains 1 members.
- 11 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [14](https://github.com/mumby0168/Fluent.Http/blob/main/src/Fluent.Http/Abstractions/IFluentStep.cs#L14 "Task IFluentStep.ExecuteAsync()") | 100 | 1 :heavy_check_mark: | 0 | 1 | 5 / 0 |

<a href="#fluent-http-abstractions">:top: back to Fluent.Http.Abstractions</a>

</details>

<details>
<summary>
  <strong id="ifluentvalidationstep">
    IFluentValidationStep :heavy_check_mark:
  </strong>
</summary>
<br>

- The `IFluentValidationStep` contains 1 members.
- 11 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [14](https://github.com/mumby0168/Fluent.Http/blob/main/src/Fluent.Http/Abstractions/IFluentValidationStep.cs#L14 "Task IFluentValidationStep.ValidateAsync()") | 100 | 1 :heavy_check_mark: | 0 | 1 | 5 / 0 |

<a href="#fluent-http-abstractions">:top: back to Fluent.Http.Abstractions</a>

</details>

</details>

<details>
<summary>
  <strong id="fluent-http">
    Fluent.Http :heavy_check_mark:
  </strong>
</summary>
<br>

The `Fluent.Http` namespace contains 6 named types.

- 6 named types.
- 280 total lines of source code.
- Approximately 53 lines of executable code.
- The highest cyclomatic complexity is 3 :heavy_check_mark:.

<details>
<summary>
  <strong id="fluenthttpclient">
    FluentHttpClient :heavy_check_mark:
  </strong>
</summary>
<br>

- The `FluentHttpClient` contains 8 members.
- 49 total lines of source code.
- Approximately 18 lines of executable code.
- The highest cyclomatic complexity is 3 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Field | [13](https://github.com/mumby0168/Fluent.Http/blob/main/src/Fluent.Http/FluentHttpClient.cs#L13 "HttpClient FluentHttpClient._client") | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Method | [15](https://github.com/mumby0168/Fluent.Http/blob/main/src/Fluent.Http/FluentHttpClient.cs#L15 "FluentHttpClient.FluentHttpClient(HttpClient? client)") | 95 | 2 :heavy_check_mark: | 0 | 3 | 1 / 1 |
| Method | [17](https://github.com/mumby0168/Fluent.Http/blob/main/src/Fluent.Http/FluentHttpClient.cs#L17 "IFluentHttpClient FluentHttpClient.Build(HttpClient? client = null)") | 84 | 1 :heavy_check_mark: | 0 | 3 | 2 / 2 |
| Method | [45](https://github.com/mumby0168/Fluent.Http/blob/main/src/Fluent.Http/FluentHttpClient.cs#L45 "Task FluentHttpClient.ExecuteAsync()") | 76 | 3 :heavy_check_mark: | 0 | 5 | 13 / 4 |
| Method | [24](https://github.com/mumby0168/Fluent.Http/blob/main/src/Fluent.Http/FluentHttpClient.cs#L24 "IFluentHttpClient FluentHttpClient.Request(Func<Task<HttpRequestMessage>> request, Func<HttpResponseMessage, Task>? response = null)") | 77 | 1 :heavy_check_mark: | 0 | 13 | 6 / 3 |
| Method | [31](https://github.com/mumby0168/Fluent.Http/blob/main/src/Fluent.Http/FluentHttpClient.cs#L31 "IFluentHttpClient FluentHttpClient.Request(Func<HttpRequestMessage> request, Func<HttpResponseMessage, Task>? response = null)") | 76 | 1 :heavy_check_mark: | 0 | 12 | 6 / 4 |
| Method | [38](https://github.com/mumby0168/Fluent.Http/blob/main/src/Fluent.Http/FluentHttpClient.cs#L38 "IFluentHttpClient FluentHttpClient.Step(Func<Task> step, Func<Task>? postStep = null)") | 78 | 1 :heavy_check_mark: | 0 | 8 | 6 / 3 |
| Property | [21](https://github.com/mumby0168/Fluent.Http/blob/main/src/Fluent.Http/FluentHttpClient.cs#L21 "List<IFluentStep> FluentHttpClient.Steps") | 100 | 1 :heavy_check_mark: | 0 | 2 | 2 / 1 |

<a href="#fluent-http">:top: back to Fluent.Http</a>

</details>

<details>
<summary>
  <strong id="fluenthttpconstants">
    FluentHttpConstants :heavy_check_mark:
  </strong>
</summary>
<br>

- The `FluentHttpConstants` contains 2 members.
- 16 total lines of source code.
- Approximately 2 lines of executable code.
- The highest cyclomatic complexity is 0 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Field | [11](https://github.com/mumby0168/Fluent.Http/blob/main/src/Fluent.Http/FluentHttpConstants.cs#L11 "string FluentHttpConstants.ApplicationJson") | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | [16](https://github.com/mumby0168/Fluent.Http/blob/main/src/Fluent.Http/FluentHttpConstants.cs#L16 "string FluentHttpConstants.HttpMethodPatch") | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |

<a href="#fluent-http">:top: back to Fluent.Http</a>

</details>

<details>
<summary>
  <strong id="fluenthttpstep">
    FluentHttpStep :heavy_check_mark:
  </strong>
</summary>
<br>

- The `FluentHttpStep` contains 7 members.
- 36 total lines of source code.
- Approximately 7 lines of executable code.
- The highest cyclomatic complexity is 3 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Field | [13](https://github.com/mumby0168/Fluent.Http/blob/main/src/Fluent.Http/FluentHttpStep.cs#L13 "HttpClient FluentHttpStep._client") | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | [14](https://github.com/mumby0168/Fluent.Http/blob/main/src/Fluent.Http/FluentHttpStep.cs#L14 "Func<Task<HttpRequestMessage>> FluentHttpStep._messageFunc") | 100 | 0 :heavy_check_mark: | 0 | 3 | 1 / 0 |
| Field | [15](https://github.com/mumby0168/Fluent.Http/blob/main/src/Fluent.Http/FluentHttpStep.cs#L15 "Func<HttpResponseMessage, Task>? FluentHttpStep._responseFunc") | 100 | 0 :heavy_check_mark: | 0 | 4 | 1 / 0 |
| Method | [24](https://github.com/mumby0168/Fluent.Http/blob/main/src/Fluent.Http/FluentHttpStep.cs#L24 "FluentHttpStep.FluentHttpStep(HttpClient client, Func<Task<HttpRequestMessage>> messageFunc, Func<HttpResponseMessage, Task>? responseFunc = null)") | 74 | 1 :heavy_check_mark: | 0 | 8 | 12 / 4 |
| Method | [34](https://github.com/mumby0168/Fluent.Http/blob/main/src/Fluent.Http/FluentHttpStep.cs#L34 "Task FluentHttpStep.ExecuteAsync()") | 92 | 1 :heavy_check_mark: | 0 | 7 | 5 / 1 |
| Field | [16](https://github.com/mumby0168/Fluent.Http/blob/main/src/Fluent.Http/FluentHttpStep.cs#L16 "HttpResponseMessage FluentHttpStep.ResponseMessage") | 93 | 0 :heavy_check_mark: | 0 | 1 | 1 / 1 |
| Method | [41](https://github.com/mumby0168/Fluent.Http/blob/main/src/Fluent.Http/FluentHttpStep.cs#L41 "Task FluentHttpStep.ValidateAsync()") | 94 | 3 :heavy_check_mark: | 0 | 5 | 6 / 1 |

<a href="#fluent-http">:top: back to Fluent.Http</a>

</details>

<details>
<summary>
  <strong id="fluentstep">
    FluentStep :heavy_check_mark:
  </strong>
</summary>
<br>

- The `FluentStep` contains 5 members.
- 31 total lines of source code.
- Approximately 5 lines of executable code.
- The highest cyclomatic complexity is 3 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Field | [13](https://github.com/mumby0168/Fluent.Http/blob/main/src/Fluent.Http/FluentStep.cs#L13 "Func<Task>? FluentStep._postStep") | 100 | 0 :heavy_check_mark: | 0 | 3 | 1 / 0 |
| Field | [12](https://github.com/mumby0168/Fluent.Http/blob/main/src/Fluent.Http/FluentStep.cs#L12 "Func<Task> FluentStep._step") | 100 | 0 :heavy_check_mark: | 0 | 2 | 1 / 0 |
| Method | [20](https://github.com/mumby0168/Fluent.Http/blob/main/src/Fluent.Http/FluentStep.cs#L20 "FluentStep.FluentStep(Func<Task> step, Func<Task>? postStep = null)") | 77 | 1 :heavy_check_mark: | 0 | 3 | 10 / 3 |
| Method | [30](https://github.com/mumby0168/Fluent.Http/blob/main/src/Fluent.Http/FluentStep.cs#L30 "Task FluentStep.ExecuteAsync()") | 100 | 1 :heavy_check_mark: | 0 | 3 | 5 / 1 |
| Method | [36](https://github.com/mumby0168/Fluent.Http/blob/main/src/Fluent.Http/FluentStep.cs#L36 "Task FluentStep.ValidateAsync()") | 100 | 3 :heavy_check_mark: | 0 | 4 | 5 / 1 |

<a href="#fluent-http">:top: back to Fluent.Http</a>

</details>

<details>
<summary>
  <strong id="httprequestmessagebuilder">
    HttpRequestMessageBuilder :heavy_check_mark:
  </strong>
</summary>
<br>

- The `HttpRequestMessageBuilder` contains 7 members.
- 66 total lines of source code.
- Approximately 12 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [68](https://github.com/mumby0168/Fluent.Http/blob/main/src/Fluent.Http/HttpRequestMessageBuilder.cs#L68 "HttpRequestMessage HttpRequestMessageBuilder.Build()") | 100 | 1 :heavy_check_mark: | 0 | 1 | 6 / 1 |
| Property | [16](https://github.com/mumby0168/Fluent.Http/blob/main/src/Fluent.Http/HttpRequestMessageBuilder.cs#L16 "HttpRequestMessage HttpRequestMessageBuilder.Message") | 100 | 1 :heavy_check_mark: | 0 | 1 | 4 / 1 |
| Method | [71](https://github.com/mumby0168/Fluent.Http/blob/main/src/Fluent.Http/HttpRequestMessageBuilder.cs#L71 "HttpRequestMessageBuilder.implicit operator HttpRequestMessage(HttpRequestMessageBuilder builder)") | 97 | 1 :heavy_check_mark: | 0 | 1 | 2 / 1 |
| Method | [36](https://github.com/mumby0168/Fluent.Http/blob/main/src/Fluent.Http/HttpRequestMessageBuilder.cs#L36 "HttpRequestMessageBuilder HttpRequestMessageBuilder.WithJsonBody<TBody>(TBody body, JsonSerializerSettings? jsonSerializerSettings = null)") | 77 | 1 :heavy_check_mark: | 0 | 6 | 12 / 3 |
| Method | [47](https://github.com/mumby0168/Fluent.Http/blob/main/src/Fluent.Http/HttpRequestMessageBuilder.cs#L47 "HttpRequestMessageBuilder HttpRequestMessageBuilder.WithMethod(HttpMethod method)") | 88 | 1 :heavy_check_mark: | 0 | 3 | 10 / 2 |
| Method | [58](https://github.com/mumby0168/Fluent.Http/blob/main/src/Fluent.Http/HttpRequestMessageBuilder.cs#L58 "HttpRequestMessageBuilder HttpRequestMessageBuilder.WithMethod(string method)") | 88 | 1 :heavy_check_mark: | 0 | 3 | 10 / 2 |
| Method | [23](https://github.com/mumby0168/Fluent.Http/blob/main/src/Fluent.Http/HttpRequestMessageBuilder.cs#L23 "HttpRequestMessageBuilder HttpRequestMessageBuilder.WithUrl(string url)") | 88 | 1 :heavy_check_mark: | 0 | 3 | 10 / 2 |

<a href="#fluent-http">:top: back to Fluent.Http</a>

</details>

<details>
<summary>
  <strong id="httprequestmessagefactory">
    HttpRequestMessageFactory :heavy_check_mark:
  </strong>
</summary>
<br>

- The `HttpRequestMessageFactory` contains 7 members.
- 65 total lines of source code.
- Approximately 9 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [38](https://github.com/mumby0168/Fluent.Http/blob/main/src/Fluent.Http/HttpRequestMessageFactory.cs#L38 "HttpRequestMessageBuilder HttpRequestMessageFactory.Delete()") | 100 | 1 :heavy_check_mark: | 0 | 2 | 6 / 1 |
| Method | [31](https://github.com/mumby0168/Fluent.Http/blob/main/src/Fluent.Http/HttpRequestMessageFactory.cs#L31 "HttpRequestMessageBuilder HttpRequestMessageFactory.Get()") | 100 | 1 :heavy_check_mark: | 0 | 2 | 6 / 1 |
| Method | [45](https://github.com/mumby0168/Fluent.Http/blob/main/src/Fluent.Http/HttpRequestMessageFactory.cs#L45 "HttpRequestMessageBuilder HttpRequestMessageFactory.Patch()") | 96 | 1 :heavy_check_mark: | 0 | 2 | 6 / 1 |
| Method | [17](https://github.com/mumby0168/Fluent.Http/blob/main/src/Fluent.Http/HttpRequestMessageFactory.cs#L17 "HttpRequestMessageBuilder HttpRequestMessageFactory.Post()") | 100 | 1 :heavy_check_mark: | 0 | 2 | 6 / 1 |
| Method | [55](https://github.com/mumby0168/Fluent.Http/blob/main/src/Fluent.Http/HttpRequestMessageFactory.cs#L55 "HttpRequestMessageBuilder HttpRequestMessageFactory.Post<TBody>(TBody body, JsonSerializerSettings? settings = null)") | 82 | 1 :heavy_check_mark: | 0 | 4 | 11 / 2 |
| Method | [24](https://github.com/mumby0168/Fluent.Http/blob/main/src/Fluent.Http/HttpRequestMessageFactory.cs#L24 "HttpRequestMessageBuilder HttpRequestMessageFactory.Put()") | 100 | 1 :heavy_check_mark: | 0 | 2 | 6 / 1 |
| Method | [67](https://github.com/mumby0168/Fluent.Http/blob/main/src/Fluent.Http/HttpRequestMessageFactory.cs#L67 "HttpRequestMessageBuilder HttpRequestMessageFactory.Put<TBody>(TBody body, JsonSerializerSettings? settings = null)") | 82 | 1 :heavy_check_mark: | 0 | 4 | 11 / 2 |

<a href="#fluent-http">:top: back to Fluent.Http</a>

</details>

</details>

<a href="#fluent-http">:top: back to Fluent.Http</a>

<div id='fluent-http-tests'></div>

## Fluent.Http.Tests :heavy_check_mark:

The *Fluent.Http.Tests.csproj* project file contains:

- 2 namespaces.
- 6 named types.
- 325 total lines of source code.
- Approximately 113 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

<details>
<summary>
  <strong id="fluent-http-tests-models">
    Fluent.Http.Tests.Models :heavy_check_mark:
  </strong>
</summary>
<br>

The `Fluent.Http.Tests.Models` namespace contains 1 named types.

- 1 named types.
- 8 total lines of source code.
- Approximately 1 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

<details>
<summary>
  <strong id="person">
    Person :heavy_check_mark:
  </strong>
</summary>
<br>

- The `Person` contains 2 members.
- 6 total lines of source code.
- Approximately 1 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Property | [5](https://github.com/mumby0168/Fluent.Http/blob/main/tests/Fluent.Http.Tests/Models/Person.cs#L5 "int Person.Id") | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | [7](https://github.com/mumby0168/Fluent.Http/blob/main/tests/Fluent.Http.Tests/Models/Person.cs#L7 "string Person.Name") | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 1 |

<a href="#fluent-http-tests-models">:top: back to Fluent.Http.Tests.Models</a>

</details>

</details>

<details>
<summary>
  <strong id="fluent-http-tests">
    Fluent.Http.Tests :heavy_check_mark:
  </strong>
</summary>
<br>

The `Fluent.Http.Tests` namespace contains 5 named types.

- 5 named types.
- 317 total lines of source code.
- Approximately 112 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

<details>
<summary>
  <strong id="fluenthttpclienttests">
    FluentHttpClientTests :heavy_check_mark:
  </strong>
</summary>
<br>

- The `FluentHttpClientTests` contains 6 members.
- 106 total lines of source code.
- Approximately 44 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Field | [15](https://github.com/mumby0168/Fluent.Http/blob/main/tests/Fluent.Http.Tests/FluentHttpClientTests.cs#L15 "HttpClient FluentHttpClientTests._client") | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | [14](https://github.com/mumby0168/Fluent.Http/blob/main/tests/Fluent.Http.Tests/FluentHttpClientTests.cs#L14 "MockHttpMessageHandler FluentHttpClientTests._handler") | 93 | 0 :heavy_check_mark: | 0 | 1 | 1 / 1 |
| Method | [17](https://github.com/mumby0168/Fluent.Http/blob/main/tests/Fluent.Http.Tests/FluentHttpClientTests.cs#L17 "FluentHttpClientTests.FluentHttpClientTests()") | 85 | 1 :heavy_check_mark: | 0 | 4 | 5 / 2 |
| Method | [24](https://github.com/mumby0168/Fluent.Http/blob/main/tests/Fluent.Http.Tests/FluentHttpClientTests.cs#L24 "Task FluentHttpClientTests.ExecuteAsync_AsyncHttpRequest_RunsCorrectly()") | 61 | 1 :heavy_check_mark: | 0 | 6 | 31 / 14 |
| Method | [56](https://github.com/mumby0168/Fluent.Http/blob/main/tests/Fluent.Http.Tests/FluentHttpClientTests.cs#L56 "Task FluentHttpClientTests.ExecuteAsync_HttpRequest_RunsCorrectly()") | 61 | 1 :heavy_check_mark: | 0 | 6 | 31 / 14 |
| Method | [88](https://github.com/mumby0168/Fluent.Http/blob/main/tests/Fluent.Http.Tests/FluentHttpClientTests.cs#L88 "Task FluentHttpClientTests.ExecuteAsync_SimpleStep_RunsCorrectly()") | 62 | 1 :heavy_check_mark: | 0 | 6 | 30 / 13 |

<a href="#fluent-http-tests">:top: back to Fluent.Http.Tests</a>

</details>

<details>
<summary>
  <strong id="fluenthttpsteptests">
    FluentHttpStepTests :heavy_check_mark:
  </strong>
</summary>
<br>

- The `FluentHttpStepTests` contains 5 members.
- 40 total lines of source code.
- Approximately 14 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Field | [13](https://github.com/mumby0168/Fluent.Http/blob/main/tests/Fluent.Http.Tests/FluentHttpStepTests.cs#L13 "HttpClient FluentHttpStepTests._client") | 100 | 0 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Field | [12](https://github.com/mumby0168/Fluent.Http/blob/main/tests/Fluent.Http.Tests/FluentHttpStepTests.cs#L12 "MockHttpMessageHandler FluentHttpStepTests._handler") | 93 | 0 :heavy_check_mark: | 0 | 1 | 1 / 1 |
| Method | [15](https://github.com/mumby0168/Fluent.Http/blob/main/tests/Fluent.Http.Tests/FluentHttpStepTests.cs#L15 "FluentHttpStepTests.FluentHttpStepTests()") | 95 | 1 :heavy_check_mark: | 0 | 3 | 1 / 1 |
| Method | [18](https://github.com/mumby0168/Fluent.Http/blob/main/tests/Fluent.Http.Tests/FluentHttpStepTests.cs#L18 "Task FluentHttpStepTests.ExecuteAsync_HttpRequest_GetsHttpResponse()") | 75 | 1 :heavy_check_mark: | 0 | 7 | 14 / 5 |
| Method | [33](https://github.com/mumby0168/Fluent.Http/blob/main/tests/Fluent.Http.Tests/FluentHttpStepTests.cs#L33 "Task FluentHttpStepTests.ValidateAsync_ResponseMessage_ValidatesCorrectly()") | 71 | 1 :heavy_check_mark: | 0 | 7 | 17 / 7 |

<a href="#fluent-http-tests">:top: back to Fluent.Http.Tests</a>

</details>

<details>
<summary>
  <strong id="fluentsteptests">
    FluentStepTests :heavy_check_mark:
  </strong>
</summary>
<br>

- The `FluentStepTests` contains 3 members.
- 44 total lines of source code.
- Approximately 16 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [11](https://github.com/mumby0168/Fluent.Http/blob/main/tests/Fluent.Http.Tests/FluentStepTests.cs#L11 "Task FluentStepTests.ExecuteAsync_Step_Runs()") | 74 | 1 :heavy_check_mark: | 0 | 4 | 14 / 6 |
| Method | [41](https://github.com/mumby0168/Fluent.Http/blob/main/tests/Fluent.Http.Tests/FluentStepTests.cs#L41 "Task FluentStepTests.ValidateAsync_NullPostStep_RunsWithNoError()") | 85 | 1 :heavy_check_mark: | 0 | 4 | 7 / 3 |
| Method | [26](https://github.com/mumby0168/Fluent.Http/blob/main/tests/Fluent.Http.Tests/FluentStepTests.cs#L26 "Task FluentStepTests.ValidateAsync_PostStep_Runs()") | 72 | 1 :heavy_check_mark: | 0 | 4 | 14 / 7 |

<a href="#fluent-http-tests">:top: back to Fluent.Http.Tests</a>

</details>

<details>
<summary>
  <strong id="httprequestmessagebuildertests">
    HttpRequestMessageBuilderTests :heavy_check_mark:
  </strong>
</summary>
<br>

- The `HttpRequestMessageBuilderTests` contains 5 members.
- 62 total lines of source code.
- Approximately 19 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [62](https://github.com/mumby0168/Fluent.Http/blob/main/tests/Fluent.Http.Tests/HttpRequestMessageBuilderTests.cs#L62 "void HttpRequestMessageBuilderTests.Build_Message_ReturnsMessage()") | 82 | 1 :heavy_check_mark: | 0 | 4 | 10 / 3 |
| Method | [13](https://github.com/mumby0168/Fluent.Http/blob/main/tests/Fluent.Http.Tests/HttpRequestMessageBuilderTests.cs#L13 "Task HttpRequestMessageBuilderTests.WithJsonBody_Object_SetsBody()") | 68 | 1 :heavy_check_mark: | 0 | 7 | 14 / 7 |
| Method | [28](https://github.com/mumby0168/Fluent.Http/blob/main/tests/Fluent.Http.Tests/HttpRequestMessageBuilderTests.cs#L28 "void HttpRequestMessageBuilderTests.WithMethod_HttpMethod_SetsMethod()") | 84 | 1 :heavy_check_mark: | 0 | 4 | 10 / 3 |
| Method | [39](https://github.com/mumby0168/Fluent.Http/blob/main/tests/Fluent.Http.Tests/HttpRequestMessageBuilderTests.cs#L39 "void HttpRequestMessageBuilderTests.WithMethod_StringHttpMethod_SetsMethod()") | 82 | 1 :heavy_check_mark: | 0 | 4 | 10 / 3 |
| Method | [51](https://github.com/mumby0168/Fluent.Http/blob/main/tests/Fluent.Http.Tests/HttpRequestMessageBuilderTests.cs#L51 "void HttpRequestMessageBuilderTests.WithUrl_Url_SetsRealativeUri()") | 82 | 1 :heavy_check_mark: | 0 | 4 | 10 / 3 |

<a href="#fluent-http-tests">:top: back to Fluent.Http.Tests</a>

</details>

<details>
<summary>
  <strong id="httprequestmessagefactorytests">
    HttpRequestMessageFactoryTests :heavy_check_mark:
  </strong>
</summary>
<br>

- The `HttpRequestMessageFactoryTests` contains 7 members.
- 50 total lines of source code.
- Approximately 19 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | [27](https://github.com/mumby0168/Fluent.Http/blob/main/tests/Fluent.Http.Tests/HttpRequestMessageFactoryTests.cs#L27 "void HttpRequestMessageFactoryTests.Delete___ReturnsDeleteMessage()") | 100 | 1 :heavy_check_mark: | 0 | 2 | 3 / 1 |
| Method | [19](https://github.com/mumby0168/Fluent.Http/blob/main/tests/Fluent.Http.Tests/HttpRequestMessageFactoryTests.cs#L19 "void HttpRequestMessageFactoryTests.Get___ReturnsGetMessage()") | 100 | 1 :heavy_check_mark: | 0 | 2 | 3 / 1 |
| Method | [31](https://github.com/mumby0168/Fluent.Http/blob/main/tests/Fluent.Http.Tests/HttpRequestMessageFactoryTests.cs#L31 "void HttpRequestMessageFactoryTests.Patch___ReturnsPatchMessage()") | 100 | 1 :heavy_check_mark: | 0 | 2 | 3 / 1 |
| Method | [15](https://github.com/mumby0168/Fluent.Http/blob/main/tests/Fluent.Http.Tests/HttpRequestMessageFactoryTests.cs#L15 "void HttpRequestMessageFactoryTests.Post___ReturnsPostMessage()") | 100 | 1 :heavy_check_mark: | 0 | 2 | 3 / 1 |
| Method | [36](https://github.com/mumby0168/Fluent.Http/blob/main/tests/Fluent.Http.Tests/HttpRequestMessageFactoryTests.cs#L36 "Task HttpRequestMessageFactoryTests.Post_JsonObject_SetsPostRequestCorrectly()") | 68 | 1 :heavy_check_mark: | 0 | 6 | 12 / 7 |
| Method | [23](https://github.com/mumby0168/Fluent.Http/blob/main/tests/Fluent.Http.Tests/HttpRequestMessageFactoryTests.cs#L23 "void HttpRequestMessageFactoryTests.Put___ReturnsPutMessage()") | 100 | 1 :heavy_check_mark: | 0 | 2 | 3 / 1 |
| Method | [49](https://github.com/mumby0168/Fluent.Http/blob/main/tests/Fluent.Http.Tests/HttpRequestMessageFactoryTests.cs#L49 "Task HttpRequestMessageFactoryTests.Put_JsonObject_SetsPutRequestCorrectly()") | 68 | 1 :heavy_check_mark: | 0 | 6 | 12 / 7 |

<a href="#fluent-http-tests">:top: back to Fluent.Http.Tests</a>

</details>

</details>

<a href="#fluent-http-tests">:top: back to Fluent.Http.Tests</a>

## Metric definitions

  - **Maintainability index**: Measures ease of code maintenance. Higher values are better.
  - **Cyclomatic complexity**: Measures the number of branches. Lower values are better.
  - **Depth of inheritance**: Measures length of object inheritance hierarchy. Lower values are better.
  - **Class coupling**: Measures the number of classes that are referenced. Lower values are better.
  - **Lines of source code**: Exact number of lines of source code. Lower values are better.
  - **Lines of executable code**: Approximates the lines of executable code. Lower values are better.

*This file is maintained by a bot.*

<!-- markdownlint-restore -->
