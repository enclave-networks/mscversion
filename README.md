# MscVersion
Helps you check if the Microsoft Visual C++ Runtime is installed. A C# alternative to the _MSC_VER macro in C++

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

## Direct Links

### Visual Studio 2015
* 14.0.23026 - https://www.microsoft.com/en-gb/download/details.aspx?id=48145
* 14.0.23506 - https://www.microsoft.com/en-gb/download/details.aspx?id=49984
* 14.0.23918 - [x86](http://download.microsoft.com/download/f/3/9/f39b30ec-f8ef-4ba3-8cb4-e301fcf0e0aa/vc_redist.x86.exe) | [x64](http://download.microsoft.com/download/4/c/b/4cbd5757-0dd4-43a7-bac0-2a492cedbacb/vc_redist.x64.exe)
* 14.0.24123 - https://www.microsoft.com/en-gb/download/details.aspx?id=52685
* 14.0.24210 - ?
* 14.0.24212 - https://www.microsoft.com/en-gb/download/details.aspx?id=53587
* 14.0.24215 - ?
* 14.0.24215.1 - https://www.microsoft.com/en-gb/download/details.aspx?id=53840

## Installer Behaviour

* Install a previous version the installer will fail with (0x80070666) Another version of this product is already installed.
* Install a later version the installer will upgrade the current version matching the installers processor architecture (replacing the old version).
* Install and already present version and installer will offer a repair option.