/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Project } from '../internal/project';

function removeCd(path: string): string {
  return path.startsWith('./') ? path.replace('./', '') : path;
}
export async function generateCsproj(project: Project) {
  const release = project.azure ? `    <SignAssembly>true</SignAssembly>
    <DelaySign>true</DelaySign>
    <AssemblyOriginatorKeyFile>MSSharedLibKey.snk</AssemblyOriginatorKeyFile>
    <DefineConstants>TRACE;RELEASE;NETSTANDARD;SIGN</DefineConstants>` :
    '    <DefineConstants>TRACE;RELEASE;NETSTANDARD</DefineConstants>';

  const assemblyinfo = project.azure ? `  <PropertyGroup>
    <GeneratedAssemblyInfoFile>${project.assemblyInfoPath}</GeneratedAssemblyInfoFile>
    <Company>${project.assemblyCompany}</Company>
    <Product>${project.assemblyProduct}</Product>
    <CopyRight>${project.assemblyCopyright}</CopyRight>
    <AssemblyTitle>${project.assemblyProduct} - ${project.title}</AssemblyTitle>
  </PropertyGroup>
  <ItemGroup>
    <AssemblyAttribute Include="System.Runtime.InteropServices.ComVisibleAttribute">
      <_Parameter1>false</_Parameter1>
    </AssemblyAttribute>
    <AssemblyAttribute Include="System.CLSCompliantAttribute">
      <_Parameter1>false</_Parameter1>
    </AssemblyAttribute>
  </ItemGroup>` : '';

  project.state.writeFile(project.csproj, `<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <Version>${project.moduleVersion}</Version>
    <LangVersion>7.1</LangVersion>
    <TargetFramework>netstandard2.0</TargetFramework>
    <OutputType>Library</OutputType>
    <AssemblyName>${project.dllName}</AssemblyName>
    <RootNamespace>${project.projectNamespace}</RootNamespace>
    <CopyLocalLockFileAssemblies>true</CopyLocalLockFileAssemblies>
    <AppendTargetFrameworkToOutputPath>false</AppendTargetFrameworkToOutputPath>
    <OutputPath>${project.binFolder}</OutputPath>
    <PublishDir>$(OutputPath)</PublishDir>
    <NuspecFile>${project.moduleName}.nuspec</NuspecFile>
    <NoPackageAnalysis>true</NoPackageAnalysis>
    <!-- Some methods are marked async and don't have an await in them -->
    <!-- warning CS1591: Missing XML comment for publicly visible type or member -->
    <NoWarn>1998, 1591</NoWarn>
    <TreatWarningsAsErrors>true</TreatWarningsAsErrors>
    <WarningsAsErrors />
  </PropertyGroup>
  ${assemblyinfo}
  <PropertyGroup Condition="'$(Configuration)|$(Platform)'=='Debug|AnyCPU'">
    <DelaySign>false</DelaySign>
    <DefineConstants>TRACE;DEBUG;NETSTANDARD</DefineConstants>
  </PropertyGroup>

  <PropertyGroup Condition="'$(Configuration)|$(Platform)'=='Release|AnyCPU'">
${release}
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="PowerShellStandard.Library" Version="5.1.0" />
    <PackageReference Include="Microsoft.CSharp" Version="4.4.1" />
  </ItemGroup>

  <PropertyGroup>
    <DefaultItemExcludes>$(DefaultItemExcludes);${removeCd(project.resourcesFolder)}/**</DefaultItemExcludes>
  </PropertyGroup>

</Project>`, undefined, 'source-file-csharp');
}
