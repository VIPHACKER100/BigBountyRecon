@echo off
REM BigBountyRecon v1.1.0 - Build Script by VIPHACKER100
REM This script will build the BigBountyRecon project

echo.
echo ============================================================
echo    BigBountyRecon v1.1.0 - Build Script
echo    Powered by VIPHACKER100
echo ============================================================
echo.

REM Check if .NET Framework 4.7.2 Developer Pack is installed
echo Checking system requirements...
if not exist "C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.2" (
    echo.
    echo ERROR: .NET Framework 4.7.2 Developer Pack not found!
    echo.
    echo To fix this:
    echo 1. Download: https://aka.ms/msbuild/developerpacks
    echo 2. Search for ".NET Framework 4.7.2 Developer Pack"
    echo 3. Install and restart this script
    echo.
    pause
    exit /b 1
)

echo [OK] .NET Framework 4.7.2 found
echo.

REM Set the project path
set PROJECT_PATH=c:\Users\vipha\Downloads\BigBountyRecon-main\BigBountyRecon-main\BigBountyRecon.csproj

REM Check if MSBuild is available
for /f "tokens=*" %%A in ('where msbuild.exe 2^>nul') do set MSBUILD=%%A

if not defined MSBUILD (
    REM Try Visual Studio 2022 BuildTools
    set "MSBUILD=C:\Program Files (x86)\Microsoft Visual Studio\2022\BuildTools\MSBuild\Current\Bin\MSBuild.exe"
)

if not exist "%MSBUILD%" (
    REM Try Visual Studio 2019
    set "MSBUILD=C:\Program Files (x86)\Microsoft Visual Studio\2019\BuildTools\MSBuild\Current\Bin\MSBuild.exe"
)

if not exist "%MSBUILD%" (
    echo ERROR: MSBuild not found!
    echo Please install Visual Studio BuildTools or Visual Studio Community
    pause
    exit /b 1
)

echo [OK] MSBuild found: %MSBUILD%
echo.

REM Clean previous builds
echo Cleaning previous build...
"%MSBUILD%" "%PROJECT_PATH%" /t:Clean /p:Configuration=Release >nul 2>&1
echo [OK] Clean complete
echo.

REM Build Release configuration
echo Building Release configuration...
"%MSBUILD%" "%PROJECT_PATH%" /t:Build /p:Configuration=Release

if %ERRORLEVEL% equ 0 (
    echo.
    echo ============================================================
    echo    BUILD SUCCESSFUL!
    echo ============================================================
    echo.
    echo Output: c:\Users\vipha\Downloads\BigBountyRecon-main\BigBountyRecon-main\bin\Release\BigBountyRecon.exe
    echo.
    pause
) else (
    echo.
    echo ============================================================
    echo    BUILD FAILED!
    echo ============================================================
    echo.
    echo Please check the error messages above.
    echo.
    pause
    exit /b 1
)
