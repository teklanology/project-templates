# Visual Studio Project Templates

[Visual Studio](https://visualstudio.microsoft.com/) extension that uses templates to quickly create new projects for Tekla Structures macros

## Features

* Create a new project from one of the following templates:
  * Script macro (what I refer to a macro without a form dialog)
* Project can then be written & debugged in Visual Studio
* .cs file can then be copied to the model/drawing macro folder to be used from Macros list

## Install

In Visual Studio, search "teklanology.project-templates-01"
Alternatively download vsix file from [Visual Studio Marketplace](https://marketplace.visualstudio.com/items?itemName=teklanology.project-templates-01) or [GitHub](https://github.com/teklanology/project-templates/releases/latest)

## Release Notes

See [CHANGELOG](https://github.com/teklanology/project-templates/tree/master/CHANGELOG.md) for release notes.

## Usage

Upon launching Visual Studio, select the required template, input the details and create the project. The template will then name the project and .cs file accordingly, and import the NuGet package for the Tekla Structures version you have selected.

## Road map

* Support for using code from recorded macros
* Additional templates for WinForms, model/drawing plugins
* Support for additional versions of Tekla Structures
* Support for additional versions of Visual Studio