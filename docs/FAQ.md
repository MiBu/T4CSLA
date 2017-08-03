**HOW TO INSTALL NEWER VERSION**

* go to Visual Studio -> Tools ->; Extension Manager
* locate CslaExtension and click Uninstall
* shut down Visual Studio
* download new version and click install
* start Visual Studio

**REPLACE .tt FILE WITH NEW VERSION IN EXISTING PROJECTS**
* delete old TT file from project
* add new CslaExtension.Template to the project (right click to EntityFramework designer -> Add code generation item -> CslaExtension.Template)
* open new .tt file and edit path to the .edmx file
