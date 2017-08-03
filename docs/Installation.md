## Install
CslaExtension is a Visual Studio extension; vsix package. Download latest version from the downloads page and double click the package to install it. You must restart Visual Studio if it was open during the installation. To check if everything was installed ok, open Visual Studio -> Tools -> Extension Manages and you should see CslaExtension among installed extensions.

## Uninstall
Open Visual Studio -> Tools -> Extension Manager, locate CslaExtension and click Uninstall

## Replace T4 file when a new version is released
* install latest version
* delete old T4 (CslaTemplate.tt) file from the project
* add new CslaExtension.Template to the project (right click to EntityFramework designer -> Add code generation item -> CslaExtension.Template, or right click to the project New Item -> CslaExtension.Template)
* open the new .tt file and edit path to the .edmx file

 