# NoteToMusic Self-Contained Build Script
# Builds the application with bundled .NET 8 runtime and creates installer

Write-Host "========================================" -ForegroundColor Cyan
Write-Host "NoteToMusic Self-Contained Build Script" -ForegroundColor Cyan
Write-Host "========================================" -ForegroundColor Cyan
Write-Host ""

# Step 1: Clean previous builds
Write-Host "[1/5] Cleaning previous builds..." -ForegroundColor Yellow
dotnet clean -c Release
if ($LASTEXITCODE -ne 0) {
    Write-Host "Clean failed!" -ForegroundColor Red
    exit 1
}
Write-Host "Clean completed" -ForegroundColor Green
Write-Host ""

# Step 2: Restore NuGet packages
Write-Host "[2/5] Restoring NuGet packages..." -ForegroundColor Yellow
dotnet restore
if ($LASTEXITCODE -ne 0) {
    Write-Host "Restore failed!" -ForegroundColor Red
    exit 1
}
Write-Host "Restore completed" -ForegroundColor Green
Write-Host ""

# Step 3: Build solution
Write-Host "[3/5] Building solution..." -ForegroundColor Yellow
dotnet build -c Release
if ($LASTEXITCODE -ne 0) {
    Write-Host "Build failed!" -ForegroundColor Red
    exit 1
}
Write-Host "Build completed" -ForegroundColor Green
Write-Host ""

# Step 4: Publish self-contained
Write-Host "[4/5] Publishing self-contained application..." -ForegroundColor Yellow
Write-Host "  - Bundling .NET 8 runtime" -ForegroundColor Gray
Write-Host "  - Creating single file executable" -ForegroundColor Gray

dotnet publish NoteToMusic\NoteToMusic.csproj -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true

if ($LASTEXITCODE -ne 0) {
    Write-Host "Publish failed!" -ForegroundColor Red
    exit 1
}
Write-Host "Publish completed" -ForegroundColor Green
Write-Host ""

# Step 5: Create installer with Inno Setup
Write-Host "[5/5] Creating installer with Inno Setup..." -ForegroundColor Yellow

$innoPath = "C:\Program Files (x86)\Inno Setup 6\ISCC.exe"
if (-not (Test-Path $innoPath)) {
    Write-Host "Inno Setup not found at: $innoPath" -ForegroundColor Red
    Write-Host "  Please install Inno Setup from: https://jrsoftware.org/isdl.php" -ForegroundColor Yellow
    exit 1
}

& $innoPath "NoteToMusic-Setup.iss"
if ($LASTEXITCODE -ne 0) {
    Write-Host "Installer creation failed!" -ForegroundColor Red
    exit 1
}
Write-Host "Installer created" -ForegroundColor Green
Write-Host ""

Write-Host "========================================" -ForegroundColor Cyan
Write-Host "Build Complete!" -ForegroundColor Green
Write-Host "========================================" -ForegroundColor Cyan
Write-Host ""
Write-Host "Installer location: .\Output\NoteToMusicSetup.exe" -ForegroundColor White
Write-Host ""
