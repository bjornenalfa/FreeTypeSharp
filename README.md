# FreeTypeSharp
![Build status](https://github.com/ryancheung/FreeTypeSharp/workflows/.NET%20Core/badge.svg)
[![Nuget](https://img.shields.io/nuget/v/FreeTypeSharp.Core)](https://www.nuget.org/packages/FreeTypeSharp.Core/)

A moden managed FreeType2 library based on the freetype2 code in the [ultraviolet](https://github.com/tlgkccampbell/ultraviolet/tree/develop/Source/Ultraviolet.FreeType2) project.

FreeTypeSharp intends to provides cross-platform bindings for:

- NET Standard 2.0
- NET Core 3.1
- Xamarin.Android
- Xamarin.iOS

# Installation

### NET Standard 2.0 & NET Core 3.1

`dotnet add package FreeTypeSharp.Core`

### Xamarin.iOS

`dotnet add package FreeTypeSharp.iOS`

### Xamarin.Android

`dotnet add package FreeTypeSharp.Android`

# Usage

There's no magic(abstraction) based on the original C freetype API. All managed API are almost identical with the original freetype C API. Import the namespace `FreeTypeSharp.Native` and then you can play the font rendering as what you do in C.

Optionally, a facade `FT_FaceRecFacade` was provided to handle some basic job. Feel free to use it.

# Credits

- https://github.com/tlgkccampbell/ultraviolet
- https://github.com/Robmaister/SharpFont/
