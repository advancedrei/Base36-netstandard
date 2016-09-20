@echo off
echo Would you like to push the packages to NuGet when finished?
set /p choice="Enter y/n: "

del *.nupkg
@echo on
".nuget/nuget.exe" pack Base36.nuspec -symbols
if /i %choice% equ y (
    ".nuget/nuget.exe" push Base36.*.nupkg -Source https://www.nuget.org/api/v2/package
)
pause