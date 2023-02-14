![Build and test](https://github.com/nietras/CntkProtoSharp/workflows/.NET/badge.svg)
[![Stars](https://img.shields.io/github/stars/nietras/CntkProtoSharp)](https://github.com/nietras/CntkProtoSharp/stargazers)
[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE.md)

|What        |Links and Status|
|---------------|------|
|`CntkProtoSharp`  |[![NuGet](https://img.shields.io/nuget/v/CntkProtoSharp)](https://www.nuget.org/packages/CntkProtoSharp/) [![Downloads](https://img.shields.io/nuget/dt/CntkProtoSharp)](https://www.nuget.org/packages/CntkProtoSharp/) |

# `CntkProtoSharp` library
CNTK model V2 protobuf format parsing and manipulation in C#.

# Quick Guide
Install latest version of .NET:
* PowerShell (Windows): [https://dot.net/v1/dotnet-install.ps1](https://dot.net/v1/dotnet-install.ps1)
* Bash (Linux/macOS): [https://dot.net/v1/dotnet-install.sh](https://dot.net/v1/dotnet-install.sh)

## Code
|What          |How                                         |
|--------------|---------------------------------------------------|
|Install       |`dotnet add PROJECT.csproj package CntkProtoSharp`|
|Parse         |`var model = Dictionary.Parser.ParseFromFile("ResNet20_CIFAR10_CNTK.cntk.model");`|
|Write         |`model.WriteToFile("ResNet20_CIFAR10_CNTK_TEST.cntk.model");`|
|Write as JSON |`model.WriteJsonToFile("ResNet20_CIFAR10_CNTK_TEST.cntk.json");`|

# Source Code
Base functionality is based on [https://github.com/nietras/CNTK/blob/master/Source/CNTKv2LibraryDll/proto/CNTK.proto](https://github.com/nietras/CNTK/blob/master/Source/CNTKv2LibraryDll/proto/CNTK.proto):
```
.\protoc.exe .\CNTK.proto --csharp_out=CntkProtoSharp
```
Everything else written in beautiful C# as extensions to this.

# Example Code
```csharp
using CNTK.Proto;
using CNTK.Proto.Test;

// Examples see https://github.com/microsoft/CNTK/blob/master/PretrainedModels/Image.md
var inputFilePath = @"ResNet20_CIFAR10_CNTK.cntk.model";

var model = Dictionary.Parser.ParseFromFile(inputFilePath);

var data = model.Data;

model.WriteToFile(@"ResNet20_CIFAR10_CNTK_TEST.cntk.model");
model.WriteIndentedJsonToFile(@"ResNet20_CIFAR10_CNTK_TEST.cntk.json");
```