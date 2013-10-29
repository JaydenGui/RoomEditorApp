using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle( "Revit Room Editor Add-In" )]
[assembly: AssemblyDescription( "Cloud based furniture and equipment editor" )]
[assembly: AssemblyConfiguration( "" )]
[assembly: AssemblyCompany( "Autodesk Inc." )]
[assembly: AssemblyProduct( "Revit Room Editor Add-In" )]
[assembly: AssemblyCopyright( "Copyright 2013 � Jeremy Tammik Autodesk Inc." )]
[assembly: AssemblyTrademark( "" )]
[assembly: AssemblyCulture( "" )]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible( false )]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid( "321044f7-b0b2-4b1c-af18-e71a19252be0" )]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]

//
// History:
// 2013-10-21 - 2014.0.0.10 - implemented RoomEditorApp and migrated GetLoops source from Revit 2013 to 2014
// 2013-10-28 - 2014.0.0.11 - replaced GetLoops namespace by RoomEditorApp and installed CouchDB
// 2013-10-28 - 2014.0.0.12 - added icon resources to project
// 2013-10-29 - 2014.0.0.13 - explored this is slower in Revit 2014 than in 2013 and removed call to SetRaiseWithoutDelay
//
[assembly: AssemblyVersion( "2014.0.0.13" )]
[assembly: AssemblyFileVersion( "2014.0.0.13" )]