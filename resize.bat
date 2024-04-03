@echo off
setlocal enabledelayedexpansion

:: Check if a folder was provided as an argument
if "%~1"=="" (
    echo No folder provided. Please drag and drop a folder onto this batch file.
    pause
    exit /b
)

:: Use the provided folder as the image directory
set "IMAGE_DIR=%~1"

echo Processing images in: %IMAGE_DIR%

:: Loop through each specified image format in the directory
for %%x in (jpg, jpeg, png, gif, bmp) do (
    for %%I in ("%IMAGE_DIR%\*.%%x") do (
        echo Processing: %%~nxI.%%x
        :: Resize the image and save as PNG, overwriting the original
        magick convert "%%I" -resize 25%% "%IMAGE_DIR%\%%~nI.png"
    )
)

echo Done resizing images.
pause