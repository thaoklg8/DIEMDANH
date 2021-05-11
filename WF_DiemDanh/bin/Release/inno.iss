; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "My Program"
#define MyAppVersion "1.5"
#define MyAppPublisher "My Company, Inc."
#define MyAppURL "http://www.example.com/"
#define MyAppExeName "WF_DiemDanh.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{39E7B2EA-7997-40A5-960E-D3C7DEC4A403}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\{#MyAppName}
DisableProgramGroupPage=yes
; Uncomment the following line to run in non administrative install mode (install for current user only.)
;PrivilegesRequired=lowest
OutputBaseFilename=mysetup
Compression=lzma
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "D:\CODE\DIEMDANH\WF_DiemDanh\bin\Release\WF_DiemDanh.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\CODE\DIEMDANH\WF_DiemDanh\bin\Release\DatabaseSINHVIEN.accdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\CODE\DIEMDANH\WF_DiemDanh\bin\Release\DatabaseSINHVIEN.laccdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\CODE\DIEMDANH\WF_DiemDanh\bin\Release\DuongDanAccess.txt"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\CODE\DIEMDANH\WF_DiemDanh\bin\Release\FireSharp.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\CODE\DIEMDANH\WF_DiemDanh\bin\Release\Microsoft.Threading.Tasks.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\CODE\DIEMDANH\WF_DiemDanh\bin\Release\Microsoft.Threading.Tasks.Extensions.Desktop.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\CODE\DIEMDANH\WF_DiemDanh\bin\Release\Microsoft.Threading.Tasks.Extensions.Desktop.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\CODE\DIEMDANH\WF_DiemDanh\bin\Release\Microsoft.Threading.Tasks.Extensions.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\CODE\DIEMDANH\WF_DiemDanh\bin\Release\Microsoft.Threading.Tasks.Extensions.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\CODE\DIEMDANH\WF_DiemDanh\bin\Release\Microsoft.Threading.Tasks.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\CODE\DIEMDANH\WF_DiemDanh\bin\Release\Newtonsoft.Json.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\CODE\DIEMDANH\WF_DiemDanh\bin\Release\Newtonsoft.Json.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\CODE\DIEMDANH\WF_DiemDanh\bin\Release\NuGet.Common.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\CODE\DIEMDANH\WF_DiemDanh\bin\Release\NuGet.Common.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\CODE\DIEMDANH\WF_DiemDanh\bin\Release\NuGet.Configuration.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\CODE\DIEMDANH\WF_DiemDanh\bin\Release\NuGet.Configuration.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\CODE\DIEMDANH\WF_DiemDanh\bin\Release\NuGet.Frameworks.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\CODE\DIEMDANH\WF_DiemDanh\bin\Release\NuGet.Frameworks.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\CODE\DIEMDANH\WF_DiemDanh\bin\Release\NuGet.Packaging.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\CODE\DIEMDANH\WF_DiemDanh\bin\Release\NuGet.Packaging.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\CODE\DIEMDANH\WF_DiemDanh\bin\Release\NuGet.Protocol.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\CODE\DIEMDANH\WF_DiemDanh\bin\Release\NuGet.Protocol.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\CODE\DIEMDANH\WF_DiemDanh\bin\Release\NuGet.Versioning.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\CODE\DIEMDANH\WF_DiemDanh\bin\Release\NuGet.Versioning.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\CODE\DIEMDANH\WF_DiemDanh\bin\Release\System.Data.OleDb.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\CODE\DIEMDANH\WF_DiemDanh\bin\Release\System.Data.OleDb.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\CODE\DIEMDANH\WF_DiemDanh\bin\Release\System.Net.Http.Extensions.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\CODE\DIEMDANH\WF_DiemDanh\bin\Release\System.Net.Http.Extensions.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\CODE\DIEMDANH\WF_DiemDanh\bin\Release\System.Net.Http.Primitives.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\CODE\DIEMDANH\WF_DiemDanh\bin\Release\System.Net.Http.Primitives.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\CODE\DIEMDANH\WF_DiemDanh\bin\Release\VisioForge.Controls.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\CODE\DIEMDANH\WF_DiemDanh\bin\Release\VisioForge.Controls.UI.Dialogs.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\CODE\DIEMDANH\WF_DiemDanh\bin\Release\VisioForge.Controls.UI.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\CODE\DIEMDANH\WF_DiemDanh\bin\Release\VisioForge.MediaFramework.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\CODE\DIEMDANH\WF_DiemDanh\bin\Release\VisioForge.Shared.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\CODE\DIEMDANH\WF_DiemDanh\bin\Release\VisioForge.Tools.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\CODE\DIEMDANH\WF_DiemDanh\bin\Release\VisioForge.Types.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\CODE\DIEMDANH\WF_DiemDanh\bin\Release\WF_DiemDanh.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\CODE\DIEMDANH\WF_DiemDanh\bin\Release\WF_DiemDanh.pdb"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent
