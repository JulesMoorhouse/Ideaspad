Imports System.Reflection
Imports System.Runtime.InteropServices

' General Information about an assembly is controlled through the following 
' set of attributes. Change these attribute values to modify the information
' associated with an assembly.

' Review the values of the assembly attributes

<Assembly: AssemblyTitle("Ideaspad 2008. �Mindwarp Consultancy Ltd")> 
<Assembly: AssemblyDescription("Ideaspad 2008")> 
<Assembly: AssemblyCompany("Mindwarp Consultancy Ltd")> 
<Assembly: AssemblyProduct("Ideaspad 2008")> 
<Assembly: AssemblyCopyright("Copyright� Mindwarp Consultancy Ltd. 2008")>  '2004
<Assembly: AssemblyTrademark("")> 
<Assembly: CLSCompliant(True)> 
<Assembly: AssemblyKeyFile("..\..\..\IdeasPad\ideaspad.snk")> 
<Assembly: Guid("EAC54603-0485-4365-A707-F747337AC4F2")> 

' Version information for an assembly consists of the following four values:
'
'      Major Version
'      Minor Version 
'      Build Number
'      Revision
'
' You can specify all the values or you can default the Build and Revision Numbers 
' by using the '*' as shown below:

'##########################################################################
'######### REMEBER TO CHANGE THE LOCALISATION DLLS NUMBER TOO !!!! ########
'#########   REMEMBER TO ADD IDEASPAD 200N TO BUG REPORT.PHP       ######## 
'##########################################################################
'<Assembly: AssemblyVersion("1.0.*")> 
'<Assembly: AssemblyVersion("1.1.6.0")> 
<Assembly: AssemblyVersion("1.2.0.0")> 
'1.0.0.5 JM 08/03/2003 - Estimate
'1.0.0.6 JM 20/03/2003
'1.0.0.7 JM 23/03/2003
'1.0.0.8 JM 31/03/2003
'1.0.1.0 JM 25/04/2003 TBC
'1.0.2.0 JM 21/05/2003
'1.0.3.0 JM 24/05/2003 After this TBC
'1.0.4.0 JM 27/10/2003
'1.0.4.1 JM 04/11/2003 
'1.0.4.2 JM 07/11/2003 
'1.0.4.3 JM 07/11/2003 - fixed drag drop bug, top level root move, mouse move re-select topic bug, need to increment resource DLLs too
'1.0.4.4 
'1.0.4.5 'yet again, didn't check for german resouse dlls
'1.0.4.6 'to be confirmed, not released yet, added icons to findindb screen
'1.0.4.7 'Data Fix for Lou Problem
'1.0.4.8 
'        
'1.1.0.0 'highlight, extra toolbar, compress rtf
'1.1.1.0 
'1.1.2.0 'New toolbar, and graidents etc
'1.1.3.0 
'1.1.4.0 ?
'1.1.5.0 TBC, after 
'1.1.6.0 'Fixes to Beside03 and general rebuild after kidsmasprint
'1.1.7.0 'Following bureport, wehn someone uses single quote in lock flag
'1.1.8.0 'extra debug comments to try and chase some problems, also fixes for bug report send and mins used
'1.1.9.0 'Added LastSQL for Bug report, also used gYear to implement 2004 => 2005, but need to do this file as well next years
'1.1.9.1 'uwe.paetzold@uporga.de repotered problem, added more debug comments to try and trace
'1.1.9.2 'checking latest error
'1.1.9.3 'Long user name, lock flag error 
'1.1.9.4 'Long user name, lock flag error to 16 
'1.1.9.5 'added Registry crash dump trap and changed 2005 to 2006 
'1.1.9.6 // JM 10/01/2007 10 - Changed to 2007
'1.1.9.7 // JM 13/06/2007 164 - after bug fixes
'1.2.0.0 // jm 18/10/2007 291 - Lots of bug fixes
'##########################################################################
'######### REMEBER TO CHANGE THE LOCALISATION DLLS NUMBER TOO !!!! ########
'##########################################################################

<Assembly: ObfuscateBlock("frmDBChoice")>  'uses Resourcemanager
<Assembly: ObfuscateBlock("branchprops")>  'uses Resourcemanager
<Assembly: ObfuscateBlock("findindb")>  'uses Resourcemanager
<Assembly: ObfuscateBlock("Export")>  'uses Resourcemanager
<Assembly: ObfuscateBlock("Import")>  'uses Resourcemanager
<Assembly: ObfuscateBlock("TemplateSelection")>  'uses Resourcemanager 
<Assembly: ObfuscateBlock("TemplateSearch")>  'uses Resourcemanager
<Assembly: ObfuscateBlock("TemplateExport")>  'uses Resourcemanager
<Assembly: ObfuscateBlock("options")>  'uses Resourcemanager
<Assembly: ObfuscateBlock("RapidEntry")>  'uses Resourcemanager
<Assembly: ObfuscateBlock("frmLicenseManager")>  'uses Resourcemanager
<Assembly: ObfuscateBlock("frmStartup")>  'uses Resourcemanager
<Assembly: ObfuscateBlock("frmMaint")>  'uses Resourcemanager
<Assembly: ObfuscateBlock("SelectivePrint")>  'uses Resourcemanager
<Assembly: ObfuscateBlock("frmPad")>  'uses Resourcemanager
<Assembly: ObfuscateBlock("frmRemind")>  'uses Resourcemanager
<Assembly: ObfuscateBlock("frmAbout")>  'uses Resourcemanager
<Assembly: ObfuscateBlock("FindResults")>  
<Assembly: ObfuscateBlock("FindInDBDetails")>  
<Assembly: ObfuscateBlock("RapidEntryDefaults")>  'uses Resourcemanager

'<Assembly: ObfuscateBlock("Licensing")>  
'<Assembly: ObfuscateBlock("ipsplash")>  
<Assembly: ObfuscateBlock("InternalLink")>  
