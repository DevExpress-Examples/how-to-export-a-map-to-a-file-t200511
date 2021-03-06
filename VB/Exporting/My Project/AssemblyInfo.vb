﻿' Developer Express Code Central Example:
' How to export a map to a file
' 
' To export a map to a file use one of the following methods.
' -
' MapControl.ExportToHtml
' (https://documentation.devexpress.com/#WPF/DevExpressXpfMapMapControl_ExportToHtmltopic)
' - exports a map to a Html file
' - MapControl.ExportToImage
' (https://documentation.devexpress.com/#WPF/DevExpressXpfMapMapControl_ExportToImagetopic)
' - exports a map as an image.
' - MapControl.ExportToMht
' (https://documentation.devexpress.com/#WPF/DevExpressXpfMapMapControl_ExportToMhttopic)
' - exports a map to a Mht file.
' - MapControl.ExportToPdf
' (https://documentation.devexpress.com/#WPF/DevExpressXpfMapMapControl_ExportToPdftopic)
' - exports a map to a Pdf file.
' - MapControl.ExportToRtf
' (https://documentation.devexpress.com/#WPF/DevExpressXpfMapMapControl_ExportToRtftopic)
' - exports a map to a Rtf file.
' - MapControl.ExportToXls
' (https://documentation.devexpress.com/#WPF/DevExpressXpfMapMapControl_ExportToXlstopic)
' - exports a map to a Xls file.
' - MapControl.ExportToXlsx
' (https://documentation.devexpress.com/#WPF/DevExpressXpfMapMapControl_ExportToXlsxtopic)
' - exports a map to a Xlsx file.
' - MapControl.ExportToXps
' (https://documentation.devexpress.com/#WPF/DevExpressXpfMapMapControl_ExportToXpstopic)
' - exports a map to a Xps file.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=T200511

Imports System.Reflection
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows

' General Information about an assembly is controlled through the following 
' set of attributes. Change these attribute values to modify the information
' associated with an assembly.
<Assembly: AssemblyTitle("Exporting")>
<Assembly: AssemblyDescription("")>
<Assembly: AssemblyConfiguration("")>
<Assembly: AssemblyCompany("")>
<Assembly: AssemblyProduct("Exporting")>
<Assembly: AssemblyCopyright("Copyright ©  2015")>
<Assembly: AssemblyTrademark("")>
<Assembly: AssemblyCulture("")>

' Setting ComVisible to false makes the types in this assembly not visible 
' to COM components.  If you need to access a type in this assembly from 
' COM, set the ComVisible attribute to true on that type.
<Assembly: ComVisible(False)>

'In order to begin building localizable applications, set 
'<UICulture>CultureYouAreCodingWith</UICulture> in your .csproj file
'inside a <PropertyGroup>.  For example, if you are using US english
'in your source files, set the <UICulture> to en-US.  Then uncomment
'the NeutralResourceLanguage attribute below.  Update the "en-US" in
'the line below to match the UICulture setting in the project file.

'[assembly: NeutralResourcesLanguage("en-US", UltimateResourceFallbackLocation.Satellite)]


<Assembly: ThemeInfo(ResourceDictionaryLocation.None, ResourceDictionaryLocation.SourceAssembly)> 'where the generic resource dictionary is located - where theme specific resource dictionaries are located
    '(used if a resource is not found in the page, 
    ' or application resource dictionaries)
    '(used if a resource is not found in the page, 
    ' app, or any theme specific resource dictionaries)


' Version information for an assembly consists of the following four values:
'
'      Major Version
'      Minor Version 
'      Build Number
'      Revision
'
' You can specify all the values or you can default the Build and Revision Numbers 
' by using the '*' as shown below:
' [assembly: AssemblyVersion("1.0.*")]
<Assembly: AssemblyVersion("1.0.0.0")>
<Assembly: AssemblyFileVersion("1.0.0.0")>
