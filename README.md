# MscVersion

Helps you check if the Microsoft Visual C++ Runtime is installed. A C# alternative to the _MSC_VER macro in C++

## NuGet Package

* https://www.nuget.org/packages/MscVersion/

## Detected Versions

The `MscVersion` library detects the following versions of the Microsoft Visual C++ Runtime. 

* Visual Studio 2005
* Visual Studio 2008
* Visual Studio 2010
* Visual Studio 2012
* Visual Studio 2013
* Visual Studio 2015
* Visual Studio 2017
* Visual Studio 2019

## Direct Links to VC++ Runtime Installers

### Visual Studio 2015
* 14.0.23026 - https://www.microsoft.com/en-gb/download/details.aspx?id=48145
* 14.0.23506 - https://www.microsoft.com/en-gb/download/details.aspx?id=49984
* 14.0.23918 - [x86](http://download.microsoft.com/download/f/3/9/f39b30ec-f8ef-4ba3-8cb4-e301fcf0e0aa/vc_redist.x86.exe) | [x64](http://download.microsoft.com/download/4/c/b/4cbd5757-0dd4-43a7-bac0-2a492cedbacb/vc_redist.x64.exe)
* 14.0.24123 - https://www.microsoft.com/en-gb/download/details.aspx?id=52685
* 14.0.24210 - Unknown
* 14.0.24212 - https://www.microsoft.com/en-gb/download/details.aspx?id=53587
* 14.0.24215 - Unknown
* 14.0.24215.1 - https://www.microsoft.com/en-gb/download/details.aspx?id=53840

## Installer Behaviour

* When trying to install an earlier version of VC++ than is alreday installed, the installer will fail with the error: (0x80070666) Another version of this product is already installed.
* When trying to install a version of VC++ newer than is already installed, the installer will upgrade the current version (matching the installers processor architecture, replacing the older version).
* When trying to install a version of VC++ which matches an already present version, the installer will offer the user a repair option.