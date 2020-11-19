; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
AppName=BackupSolution.NET
AppVerName=BackupSolution.NET 0.4
AppPublisher=Ferla Daniele
AppPublisherURL=http://www.desdinova.it
AppSupportURL=http://www.desdinova.it
AppUpdatesURL=http://www.desdinova.it
DefaultDirName={pf}\BackupSolution.NET
DefaultGroupName=BackupSolution.NET 0.4
OutputBaseFilename=BackupSolution.NET
Compression=lzma
SolidCompression=true
AppCopyright=2008 by Ferla Daniele
WizardImageFile=C:\Program Files\Inno Setup 5\WizModernImage-IS.bmp
WizardSmallImageFile=C:\Program Files\Inno Setup 5\WizModernSmallImage-IS.bmp
AppVersion=0.4
UninstallDisplayIcon={app}\BackupSolution.NET.exe
UninstallDisplayName=BackupSolution.NET 0.4
LicenseFile=D:\Projects\C#\BackupSolution.NET\License.txt

[Languages]
Name: english; MessagesFile: compiler:Default.isl

[Tasks]
Name: desktopicon; Description: {cm:CreateDesktopIcon}; GroupDescription: {cm:AdditionalIcons}; Flags: unchecked

[Files]
; NOTE: Don't use "Flags: ignoreversion" on any shared system files
Source: bin\Release\BackupSolution.NET.exe; DestDir: {app}; Flags: ignoreversion
Source: History.txt; DestDir: {app}
Source: License.txt; DestDir: {app}

[Icons]
Name: {group}\BackupSolution.NET; Filename: {app}\BackupSolution.NET.exe
Name: {group}\{cm:UninstallProgram,BackupSolution.NET}; Filename: {uninstallexe}
Name: {commondesktop}\BackupSolution.NET; Filename: {app}\BackupSolution.NET.exe; Tasks: desktopicon

[Run]
Filename: {app}\BackupSolution.NET.exe; Description: {cm:LaunchProgram,XNBModelBuilder}; Flags: nowait postinstall skipifsilent
