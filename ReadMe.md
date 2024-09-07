Windows WPF Application .Net Framework 4.8.1 Bootapper using WixSharp and Wix Toolset 4.0.3

Pre-requisites:
1. Visual Studio 2022
1. .Net Framework 4.8.1
1. Wix toolset 4.0.3

Install Wix toolset 4.0.3 from https://wixtoolset.org/releases/
```
	dotnet tool install --global wix --version 4.0.3
```

Extra packages added that are needed for the project. (See packages.config)

```
  <package id="WixSharp_wix4" version="2.3.2" targetFramework="net481" />
  <package id="WixSharp_wix4.bin" version="2.3.2" targetFramework="net481" />
  <package id="WixToolset.Bal.wixext" version="4.0.3" targetFramework="net481" />
  <package id="WixToolset.Dtf.WindowsInstaller" version="4.0.3" targetFramework="net481" />
  <package id="WixToolset.Mba.Core" version="4.0.3" targetFramework="net481" />
  <package id="WixToolset.Netfx.wixext" version="4.0.3" targetFramework="net481" />
  <package id="WixToolset.UI.wixext" version="4.0.3" targetFramework="net481" />
```