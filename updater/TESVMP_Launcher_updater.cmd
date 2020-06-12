@echo off
IF EXIST "TESVMP_Launcher.exe" (
taskkill /IM TESVMP_Launcher.exe
del TESVMP_Launcher.exe
ren TESVMP_Launcher1.exe TESVMP_Launcher.exe
timeout 3
start TESVMP_Launcher.exe
)
IF EXIST "SkyrimLauncher.exe" (
taskkill /IM SkyrimLauncher.exe
ren SkyrimLauncher.exe SkyrimLauncher_%random%_old.exe
ren TESVMP_Launcher1.exe SkyrimLauncher.exe
timeout 3
start SkyrimLauncher.exe
)
IF EXIST "SkyrimSELauncher.exe" (
taskkill /IM SkyrimSELauncher.exe
ren SkyrimSELauncher.exe SkyrimSELauncher_%random%_old.exe
ren TESVMP_Launcher1.exe SkyrimSELauncher.exe
timeout 3
start SkyrimSELauncher.exe
)
