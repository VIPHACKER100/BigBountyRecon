# BigBountyRecon v1.1.0 - Build Instructions

**Status:** ⚠️ Ready to build - Requires .NET Framework 4.7.2 Developer Pack installation

---

## ⚡ Quick Start (3 Steps)

### Step 1: Install Prerequisites
Download and install the .NET Framework 4.7.2 Developer Pack:
- **Download Link:** https://aka.ms/msbuild/developerpacks
- **Search for:** ".NET Framework 4.7.2 Developer Pack"
- **Install:** Run the installer and follow the prompts
- **Restart:** Restart your computer after installation

### Step 2: Run Build Script
```batch
cd c:\Users\vipha\Downloads\BigBountyRecon-main\BigBountyRecon-main
BUILD.bat
```

### Step 3: Run the Application
```
bin\Release\BigBountyRecon.exe
```

---

## 📋 Complete Build Guide

### Option 1: Using Build Script (Recommended)
The easiest method - just run the provided script:

```batch
@REM Open Command Prompt
@REM Navigate to the project folder
cd c:\Users\vipha\Downloads\BigBountyRecon-main\BigBountyRecon-main

@REM Run the build script
BUILD.bat

@REM Output will be in: bin\Release\BigBountyRecon.exe
```

**What it does:**
- Checks system requirements
- Cleans previous builds
- Compiles in Release mode
- Reports success or failure

---

### Option 2: Using Visual Studio
```
1. Open BigBountyRecon.sln in Visual Studio
2. Right-click the project → Properties → Build
3. Set Configuration to "Release"
4. Press Ctrl+Shift+B to build
5. Output: bin\Release\BigBountyRecon.exe
```

---

### Option 3: Using MSBuild Command Line
```powershell
# PowerShell
$msbuild = 'C:\Program Files (x86)\Microsoft Visual Studio\2022\BuildTools\MSBuild\Current\Bin\MSBuild.exe'
& $msbuild 'BigBountyRecon.csproj' '/t:Clean' '/t:Build' '/p:Configuration=Release'
```

---

## 🔧 System Requirements

### Required Software
- **Windows 10 or later**
- **.NET Framework 4.7.2 Developer Pack**
- **Visual Studio 2019/2022 or MSBuild**

### Optional (For Advanced Development)
- Visual Studio 2022 Community (Free)
- Visual Studio Code with C# extensions

### Installation Checklist
- [ ] Windows 10/11
- [ ] .NET Framework 4.7.2 Developer Pack installed
- [ ] MSBuild available (comes with Visual Studio)

---

## 📊 Build Configurations

### Release Build (Optimized for Performance)
```batch
msbuild BigBountyRecon.csproj /t:Build /p:Configuration=Release
```
- **Output:** `bin\Release\BigBountyRecon.exe`
- **Size:** ~100 KB
- **Performance:** Optimized
- **Use Case:** Distribution, production

### Debug Build (With debugging symbols)
```batch
msbuild BigBountyRecon.csproj /t:Build /p:Configuration=Debug
```
- **Output:** `bin\Debug\BigBountyRecon.exe`
- **Size:** ~200 KB  
- **Performance:** Slower
- **Use Case:** Development, debugging

---

## ✅ Build Verification

### After Successful Build
You should see:
```
Build started 28-04-2026 22:XX:XX
...
BigBountyRecon.exe
...
0 Error(s), 0 Warning(s)

Build SUCCESSFUL
Time Elapsed 00:00:XX.XX
```

### Build Output Structure
```
BigBountyRecon/
├── bin/
│   ├── Debug/
│   │   ├── BigBountyRecon.exe         ← Debug executable
│   │   ├── BigBountyRecon.pdb
│   │   └── *.config
│   └── Release/
│       ├── BigBountyRecon.exe         ← Production executable
│       ├── BigBountyRecon.pdb
│       └── *.config
├── obj/
│   └── [Intermediate build files]
└── [Source files]
```

---

## 🐛 Troubleshooting

### Error: MSB3644 - Reference Assemblies Not Found

**Problem:** `.NET Framework 4.7.2 Developer Pack was not found`

**Solution:**
1. Download from: https://aka.ms/msbuild/developerpacks
2. Select ".NET Framework 4.7.2 Developer Pack"
3. Run installer with administrator privileges
4. Restart computer
5. Try building again

---

### Error: "msbuild" is not recognized

**Problem:** MSBuild is not in PATH

**Solution - Option A:** Use full path
```powershell
& 'C:\Program Files (x86)\Microsoft Visual Studio\2022\BuildTools\MSBuild\Current\Bin\MSBuild.exe' BigBountyRecon.csproj
```

**Solution - Option B:** Install Visual Studio Build Tools
1. Download: https://visualstudio.microsoft.com/downloads/
2. Select "Visual Studio Build Tools"
3. Install "Desktop Development with C++"
4. Restart computer

---

### Error: Form1.Designer.cs not found

**Problem:** Designer file missing

**Solution:**
The designer file should be included in the package. If missing:
1. Right-click Form1.cs
2. Select "View Designer"
3. Visual Studio will regenerate it

---

### Project Builds Successfully But Won't Run

**Problem:** Application crashes on startup

**Solution:**
1. Ensure .NET Framework 4.7.2 Runtime is installed (not just Developer Pack)
2. Download from: https://dotnet.microsoft.com/download/dotnet-framework/net472
3. Install the Runtime
4. Try running the executable again

---

## 🚀 Running the Application

### First Run
```bash
# Navigate to output directory
cd bin\Release

# Run the executable
BigBountyRecon.exe
```

### Create Shortcut
1. Right-click `BigBountyRecon.exe`
2. Select "Send to" → "Desktop (create shortcut)"
3. Rename if desired
4. Double-click to run

---

## 📈 Build Performance

**Expected Build Times:**
- **First Build:** 5-15 seconds (includes setup)
- **Subsequent Builds:** 2-5 seconds (incremental)
- **Clean + Build:** 5-10 seconds

---

## 🔐 Code Quality Checks

### Compile with Warnings as Errors (Strict)
```powershell
$msbuild /p:TreatWarningsAsErrors=true
```

### Build with Code Analysis
```powershell
$msbuild /p:RunCodeAnalysis=true
```

---

## 📦 Distribution

After successful build:
1. Copy `bin\Release\BigBountyRecon.exe` to destination
2. Include license file
3. Include README.md
4. Distribute to users

**Requirements for end-users:**
- Windows 10 or later
- .NET Framework 4.7.2 Runtime (or later)

---

## 🔗 Useful Links

- **Download .NET Framework:** https://dotnet.microsoft.com/download/dotnet-framework
- **Visual Studio Build Tools:** https://visualstudio.microsoft.com/downloads/
- **MSBuild Documentation:** https://docs.microsoft.com/en-us/visualstudio/msbuild/msbuild
- **Windows Forms Guide:** https://docs.microsoft.com/en-us/dotnet/framework/winforms/

---

## 📝 Build Log

For troubleshooting, save build output:

```powershell
# PowerShell - Save to file
$msbuild BigBountyRecon.csproj > build.log 2>&1

# View log
Get-Content build.log
```

---

## ✨ Build Success!

Once built successfully, the application is ready for:
- ✓ Distribution to other systems
- ✓ Production deployment
- ✓ Further development
- ✓ Integration with other tools

---

**Version:** 1.1.0 - VIPHACKER100 Edition  
**Last Updated:** 2026-04-28  
**Status:** Ready for Build
