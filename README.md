![.editorconfig Banner](Images/Banner.png)

A very generic [.editorconfig](https://github.com/RehanSaeed/EditorConfig/blob/master/.editorconfig) file supporting the following file types:

- C# - .cs, .csx, .cake
- Visual Basic - .vb, vbx
- Script - .sh, .ps1, .psm1, .bat, .cmd
- XML - .xml, .config, .props, .targets, .nuspec, .resx, .ruleset
- JSON - .json, .json5
- YAML - .yml,  .yaml
- HTML - .htm, .html
- JavaScript - .js, .jsm, .ts, .tsx, .vue
- CSS - .css, .sass, .scss, .less
- SVG - .svg
- Markdown - .md
- Visual Studio - .sln, .csproj, .vbproj, .vcxproj, .vcxproj.filters, .proj, .projitems, .shproj
- Makefile

### .NET Code Style

Extensive code style settings for C# and VB.NET have been defined that require the latest C# features to be used.
All C# related code styles are consistent with [StyleCop's](https://github.com/DotNetAnalyzers/StyleCopAnalyzers) default styles, with the exception of the file header definition, which has been changed to a more modern format.
All .NET naming conventions are consistent with the .NET Framework Design Guideline's [Naming Guidelines](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/naming-guidelines).

# What is .editorconfig?

EditorConfig helps developers define and maintain consistent coding styles between different editors and IDEs. The EditorConfig project consists of a file format for defining coding styles and a collection of text editor plugins that enable editors to read the file format and adhere to defined styles. EditorConfig files are easily readable and they work nicely with version control systems. Find out more at [editorconfig.org](http://editorconfig.org/) and the [Visual Studio Docs](https://docs.microsoft.com/en-us/visualstudio/ide/editorconfig-code-style-settings-reference).

# How do I use It?

All you have to do is drop it into the root of your project. Then any time you open a file in Visual Studio, the .editorconfig file settings will be used to help format the document and also raise warnings if your code style and formatting does not conform. For Visual Studio Code, you can install the [EditorConfig for VS Code](https://marketplace.visualstudio.com/items?itemName=EditorConfig.EditorConfig) extension to get support.

# How can I get it?

Download the `.editorconfig` file in this repository or you can install the [.NET Boxed](https://github.com/Dotnet-Boxed/Templates) templates and use the `dotnet new` CLI to create a new `.editorconfig` file in you current directory like so:

```powershell
dotnet new --install Boxed.Templates
dotnet new editorconfig
```
