@echo off
chcp 65001 >nul
echo © CAPSULE CORP. SCRIPTS ©

echo:
echo:

echo Total lines of code in this project:
powershell -Command "& {(gci -include *.cs,*.xaml -recurse | select-string .).Count;}"
timeout 3