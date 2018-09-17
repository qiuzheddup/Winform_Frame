for /f "usebackq tokens=1* delims=/" %%a in (`dir /s /b /a:d ^| findstr /i "\\obj$"`) do rmdir /s /q "%%a"
for /f "usebackq tokens=1* delims=/" %%a in (`dir /s /b /a:d ^| findstr /i "\\bin$"`) do rmdir /s /q "%%a"
del /s /q /a:h *.suo
del /s /q *.user
