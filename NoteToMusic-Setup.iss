; Note To Music (NTM) - Inno Setup Script
; This script creates a professional installer for the NoteToMusic application
; Created: 2025-12-24

#define MyAppName "Note To Music"
#define MyAppVersion "1.0.2"
#define MyAppPublisher "Yiğit Emre Erten"
#define MyAppURL "https://github.com/yigitemrertn/NTM2"
#define MyAppExeName "NoteToMusic.exe"
#define MyAppAssocName MyAppName + " File"
#define MyAppAssocExt ".ntm"
#define MyAppAssocKey StringChange(MyAppAssocName, " ", "") + MyAppAssocExt

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{0BF6B0C1-531B-43EF-9C2B-60DDA4FE3DA6}}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\{#MyAppName}
DisableProgramGroupPage=yes
LicenseFile=LICENSE
; Uncomment the following line to run in non administrative install mode (install for current user only.)
PrivilegesRequired=lowest
PrivilegesRequiredOverridesAllowed=dialog
OutputDir=Setup
OutputBaseFilename=NoteToMusic-Setup-v{#MyAppVersion}
;SetupIconFile=NoteToMusic\icon.ico  ; Uncomment this line if you add an icon.ico file to the NoteToMusic folder
Compression=lzma2/max
SolidCompression=yes
WizardStyle=modern
ArchitecturesAllowed=x64compatible
ArchitecturesInstallIn64BitMode=x64compatible

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "turkish"; MessagesFile: "compiler:Languages\Turkish.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
; Self-contained application (includes .NET 8 runtime)
Source: "NoteToMusic\bin\Release\net8.0-windows\win-x64\publish\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs

; Audiveris dependency (full installation folder)
Source: "Dependencies\Audiveris\*"; DestDir: "{app}\Dependencies\Audiveris"; Flags: ignoreversion recursesubdirs createallsubdirs

; NOTE: Don't use "Flags: ignoreversion" on any shared system files

; Documentation
Source: "README.md"; DestDir: "{app}"; Flags: ignoreversion isreadme
Source: "LICENSE"; DestDir: "{app}"; Flags: ignoreversion

; Assets folder (optional - uncomment if you want to include default assets)
; Source: "NoteToMusic\bin\Release\net8.0-windows\Assets\*"; DestDir: "{app}\Assets"; Flags: ignoreversion recursesubdirs createallsubdirs

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

[Code]
procedure CurStepChanged(CurStep: TSetupStep);
begin
  if CurStep = ssPostInstall then
  begin
    // Create Assets folder structure if it doesn't exist
    if not DirExists(ExpandConstant('{app}\Assets')) then
      CreateDir(ExpandConstant('{app}\Assets'));
    if not DirExists(ExpandConstant('{app}\Assets\Notes')) then
      CreateDir(ExpandConstant('{app}\Assets\Notes'));
    if not DirExists(ExpandConstant('{app}\Assets\Soundfonts')) then
      CreateDir(ExpandConstant('{app}\Assets\Soundfonts'));
    if not DirExists(ExpandConstant('{app}\Assets\Musics')) then
      CreateDir(ExpandConstant('{app}\Assets\Musics'));
    if not DirExists(ExpandConstant('{app}\Assets\Temp')) then
      CreateDir(ExpandConstant('{app}\Assets\Temp'));
  end;
end;
