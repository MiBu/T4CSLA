**Project Description**
Visual Studio extension and T4 templates for generation of CSLA objects from ADO.NET Entity Framework model.

![CSLA LOGO](Home_csla_logo1_42.png)
[More about CSLA framework.](http://www.lhotka.net/cslanet/)


If you are new to this project, you should read the [Introduction](Introduction) first.

## NEWS
**2012-03-14**
Started work on a new version:
- Added support for DbContext. You can download the VSIX from the Downloads page. I've also added a  new project to the source code to test DbContext compatibility.


**2010-10-17 - Version 1.0.1**
Version 1.0.1 is available for download. Changes since ver. 1.0:
- Many-to-many support
- Bugfix: when adding item template to the project which contains no edmx file, user can choose edmx file from disk

**2010-10-08 - Version 1.0.**
After 6 months of development and testing we have released the version 1.0. There are only few bugfixes since Beta 3 which is already being used in the production.
Plan for the 1.1. version is to implement inheritance support.


**2010-09-15 - Beta3 released**
Beta3 is now available for download.
This is primarly released to test a new "packaging" machanism for the VSIX file, hoping to solve what seems to be a Locale related bug.

We invite people who might still be having problems to give us a detailed description of their setup in the discussions.

**2010-07-13 - Beta2 released**
Beta2 is available for download. In following days we will review the documentation and update the Demo project.
Changes since Beta1:
# CSLA 4.0 RC0 support
# Choosing a namespace for each object individually
# Wizard for selection of EF model when adding new t4 template
# Choosing a transaction type
# Bugfixes
# Code refactoring

**2010-07-12 - Preparing Beta2**
We are preparing the Beta2 release. It will be available for download today.

**2010-07-01 - New source code folder structure (development and release branches)**

**2010-06-08 - New ver. of Quick Setup Guide for Silverlight 4**
Under documentation you can find updated version of this document with files (config and C#) so you don't need to copy-paste part-by-part from PDF.

**UPDATE 2010-05-14 - DOCUMENTATION**
Under documentation you can find Quick Setup Guide for CSLA .NET for Silverlight 4 using 3-tier application model
with binary message encoding and compression. We are working on MVVM Silverlight 4 sample application...

**UPDATE 2010-05-12**
New release with many changes and bugfixes. For details see Source Code log.
Currently we are implementing missing features, building a Silverlight demo app, and updating the documentation.

**UPDATE 2010-05-07**
Bugfix release is uploaded. If you've downloaded an early version, see documetation FAQ. Demo project is also updated, now you can add and edit orders.

**UPDATE 2010-05-06 - BETA 1**
CslaExtension Beta1 is available for download. 
Later today we'll upload Beta1 demo that we used to test concepts. Documentation is still under construction, but you can find some info in QuickReference and BuildingDemo documents under the Documentation tab. 


**UPDATE 2010-05-04**
Almost done!
We are preparing Beta1, hope it will be available for download tomorrow. We'll try to follow CSLA releases as much as possible, so for this release we are using CSLA 4.0. Beta 1. Right now, we are finishing T4 template, VS extension is done, demo project is good enough for Beta1 and documentation is already available. 
~Josip

**UPDATE 2010-04-27**
Next week we will upload Beta1 version. There are many improvements and changes. We are no more using the Documentation property to generate CSLA classes, but instead we developed a VS extension that adds properties to Entities in the Entity Framework designer (special thanks to mrclucmorin). T4 template is being refactored, and modified in order to support new CSLA 4.0. features.

New features:
- Custom properties in Entity Framework designer
- Visual Studio Extension simple setup
- Visual Studio project item template (File -> Add New CSLA Template)
- Silverlight support (multiple files)


**UPDATE 2010-04-10**
This project is currently being developed in order to support new features in CSLA 4.0 and Entity Framework 4.0. 
Detailed roadmap will be published here in a few days.
Thank you for your interest in this project.