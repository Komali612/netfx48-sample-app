# netfx48-sample-app

A minimal **ASP.NET MVC application targeting .NET Framework 4.8**, used as a
smoke-test target for the `netfx48-ci-agent`. It deliberately ships **no CI
workflow** — the agent is expected to discover it, generate a GitHub Actions CI
pipeline, and open a pull request adding `.github/workflows/…-ci.yml`.

## Shape
- `netfx48-sample-app.csproj` — `<TargetFrameworkVersion>v4.8`, web-application
  project (MVC), builds with MSBuild
- `packages.config` — classic NuGet dependencies (`net48`): ASP.NET MVC 5.2.9 + deps
- `Web.config`, `Global.asax`, `App_Start/RouteConfig.cs`, `Controllers/HomeController.cs`,
  `Views/Home/Index.cshtml`
- No `.github/workflows/` — that's the agent's job

## Build locally (Windows, VS Build Tools)
```pwsh
nuget restore netfx48-sample-app.csproj -PackagesDirectory packages
msbuild netfx48-sample-app.csproj /p:Configuration=Release /p:Platform=AnyCPU
```
