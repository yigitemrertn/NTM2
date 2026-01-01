# Audiveris Dependency

This folder should contain `Audiveris.exe` for bundling with the installer.

## How to Add Audiveris

1. Download Audiveris from the official source
2. Place `Audiveris.exe` in this `Dependencies` folder
3. Run `build-installer.ps1` to create the installer

The installer will automatically include Audiveris and the application will find it without user configuration.

## Note

If Audiveris.exe is not present when building the installer, users will be prompted to manually select it on first run.
