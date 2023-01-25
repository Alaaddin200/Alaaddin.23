﻿< Project Sdk = "Microsoft.NET.Sdk" >

  < PropertyGroup >
    < OutputType > WinExe </ OutputType >
    < TargetFramework > net6.0 - windows </ TargetFramework >
    < Nullable > enable </ Nullable >
    < UseWindowsForms > true </ UseWindowsForms >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < Compile Update = "Properties\Resources.Designer.cs" >
      < DesignTime > True </ DesignTime >
      < AutoGen > True </ AutoGen >
      < DependentUpon > Resources.resx </ DependentUpon >
    </ Compile >
  </ ItemGroup >

  < ItemGroup >
    < EmbeddedResource Update = "Properties\Resources.resx" >
      < Generator > ResXFileCodeGenerator </ Generator >
      < LastGenOutput > Resources.Designer.cs </ LastGenOutput >
    </ EmbeddedResource >
  </ ItemGroup >

</ Project >