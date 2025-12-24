# Note To Music - Installer Build Script
# Bu script projeyi derler ve Inno Setup installer'ını oluşturur

param(
    [string]$Configuration = "Release",
    [string]$InnoSetupPath = "C:\Program Files (x86)\Inno Setup 6\ISCC.exe"
)

Write-Host "========================================" -ForegroundColor Cyan
Write-Host "Note To Music - Installer Builder" -ForegroundColor Cyan
Write-Host "========================================" -ForegroundColor Cyan
Write-Host ""

# 1. Check prerequisites
Write-Host "[1/4] Checking prerequisites..." -ForegroundColor Yellow
if (-not (Test-Path $InnoSetupPath)) {
    Write-Host "ERROR: Inno Setup not found at: $InnoSetupPath" -ForegroundColor Red
    Write-Host "Please install Inno Setup from: https://jrsoftware.org/isdl.php" -ForegroundColor Red
    exit 1
}
Write-Host "  ✓ Inno Setup found" -ForegroundColor Green

# 2. Build the project
Write-Host ""
Write-Host "[2/4] Building project in $Configuration mode..." -ForegroundColor Yellow
$buildResult = dotnet build -c $Configuration 2>&1
if ($LASTEXITCODE -ne 0) {
    Write-Host "ERROR: Build failed!" -ForegroundColor Red
    Write-Host $buildResult
    exit 1
}
Write-Host "  ✓ Build successful" -ForegroundColor Green

# 3. Check if NoteToMusic.exe exists
Write-Host ""
Write-Host "[3/4] Verifying build output..." -ForegroundColor Yellow
$exePath = "NoteToMusic\bin\$Configuration\net8.0-windows\NoteToMusic.exe"
if (-not (Test-Path $exePath)) {
    Write-Host "ERROR: NoteToMusic.exe not found at: $exePath" -ForegroundColor Red
    exit 1
}
Write-Host "  ✓ NoteToMusic.exe found" -ForegroundColor Green

# 4. Compile Inno Setup script
Write-Host ""
Write-Host "[4/4] Compiling installer..." -ForegroundColor Yellow
$issPath = "NoteToMusic-Setup.iss"
if (-not (Test-Path $issPath)) {
    Write-Host "ERROR: Inno Setup script not found: $issPath" -ForegroundColor Red
    exit 1
}

& $InnoSetupPath $issPath
if ($LASTEXITCODE -ne 0) {
    Write-Host "ERROR: Installer compilation failed!" -ForegroundColor Red
    exit 1
}
Write-Host "  ✓ Installer created successfully" -ForegroundColor Green

# 5. Show results
Write-Host ""
Write-Host "========================================" -ForegroundColor Green
Write-Host "SUCCESS! Installer created" -ForegroundColor Green
Write-Host "========================================" -ForegroundColor Green
Write-Host ""
Write-Host "Installer location:" -ForegroundColor Cyan
Write-Host "  Setup\NoteToMusic-Setup-v1.0.0.exe" -ForegroundColor White
Write-Host ""
Write-Host "Next steps:" -ForegroundColor Cyan
Write-Host "  1. Test the installer locally" -ForegroundColor White
Write-Host "  2. Create a GitHub Release" -ForegroundColor White
Write-Host "  3. Upload the installer file" -ForegroundColor White
Write-Host ""
Write-Host "For more details, see SETUP-GUIDE.md" -ForegroundColor Yellow
