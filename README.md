# MscVersion
Helps you check if the Microsoft Visual C++ Runtime is installed. A C# alternative to the _MSC_VER macro in C++

## Direct Links

* 14.0.23026	https://www.microsoft.com/en-gb/download/details.aspx?id=48145
* 14.0.23506	https://www.microsoft.com/en-gb/download/details.aspx?id=49984
* 14.0.24123	https://www.microsoft.com/en-gb/download/details.aspx?id=52685
* 14.0.24212	https://www.microsoft.com/en-gb/download/details.aspx?id=53587
* 14.0.24215.1	https://www.microsoft.com/en-gb/download/details.aspx?id=53840

## Installer Behaviour

* Install a previous version the installer will fail with (0x80070666) Another version of this product is already installed.
* Install a later version the installer will upgrade the current version matching the installers processor architecture (replacing the old version).
* Install and already present version and installer will offer a repair option.