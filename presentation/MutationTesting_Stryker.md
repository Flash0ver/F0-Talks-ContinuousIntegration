# Passing arguments to your sample project

### Install
.NET Core tool via _NuGet.org_
[dotnet-stryker](https://www.nuget.org/packages/dotnet-stryker/)

#### .NET Core global tool
```
dotnet tool install -g dotnet-stryker
```

#### .NET Core local tool
```
dotnet new tool-manifest
```
```
dotnet tool install dotnet-stryker
```
```
dotnet tool restore
```

### Use
```
dotnet stryker
```
```
dotnet stryker --help
```

### [Configuration](https://github.com/stryker-mutator/stryker-net/blob/master/docs/Configuration.md)

### [Reporters](https://github.com/stryker-mutator/stryker-net/blob/master/docs/Reporters.md)

#### Global and local tools
- [Install a global tool](https://docs.microsoft.com/en-us/dotnet/core/tools/global-tools#install-a-global-tool)
- [Install a local tool](https://docs.microsoft.com/en-us/dotnet/core/tools/global-tools#install-a-local-tool)

---
###### [Tools](./MutationTesting_Tools.md) < | > [Q&A](./QA.md)
