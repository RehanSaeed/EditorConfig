![Editor Config Logo](https://raw.githubusercontent.com/RehanSaeed/EditorConfig/master/logo.png)

# Editor Config

A very generic [.editorconfig](https://github.com/RehanSaeed/EditorConfig/blob/master/.editorconfig) file supporting the following file types:

- C# - .cs, .csx, .cake
- Visual Basic - .vb
- Script - .sh, .ps1, .psm1, .bat, .cmd
- XML - .xml, .config, .props, .targets, .nuspec, .resx, .ruleset
- JSON - .json, .json5
- YAML - .yml,  .yaml
- HTML - .htm, .html
- JavaScript - .js, .ts
- CSS - .css, .scss, .less
- Markdown - .md
- Visual Studio - .sln, .csproj, .vbproj, .vcxproj, .vcxproj.filters, .proj, .projitems, .shproj

Extensive code style settings for C# and VB.NET have been defined that require the latest C# features to be used. Also, all C# related code styles are consistent with [StyleCop's](https://github.com/DotNetAnalyzers/StyleCopAnalyzers) default styles.

# What is Editor Config

EditorConfig helps developers define and maintain consistent coding styles between different editors and IDEs. The EditorConfig project consists of a file format for defining coding styles and a collection of text editor plugins that enable editors to read the file format and adhere to defined styles. EditorConfig files are easily readable and they work nicely with version control systems. Find out more at [editorconfig.org](http://editorconfig.org/) and the [Visual Studio Docs](https://docs.microsoft.com/en-us/visualstudio/ide/editorconfig-code-style-settings-reference).

# How do I use It?

All you have to do is drop it into the root of your project. Then any time you open a file in Visual Studio, the .editorconfig file settings will be used to help format the document and also raise warnings if your code style and formatting does not conform. For Visual Studio Code, you can install the [EditorConfig for VS Code](https://marketplace.visualstudio.com/items?itemName=EditorConfig.EditorConfig) extension to get support.
