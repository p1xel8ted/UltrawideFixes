@echo off
setlocal enabledelayedexpansion

:: Directory for processed images when specific files are processed
set "GLOBAL_PROCESSED_DIR=Processed"

:: Check if the script was called with any arguments
if "%~1"=="" (
    echo No arguments provided. Processing images in the script's directory.
    :: Use the script's directory as the image directory
    set "IMAGE_DIR=%~dp0"
    set "PROCESSED_DIR=!IMAGE_DIR!!GLOBAL_PROCESSED_DIR!"
    if not exist "!PROCESSED_DIR!" mkdir "!PROCESSED_DIR!"
    goto :process_images
)

:process_next_arg
if "%~1"=="" goto :eof

:: Check if the argument is a directory or a file
if exist "%~1\*" (
    :: Argument is a directory
    set "IMAGE_DIR=%~1"
    set "PROCESSED_DIR=!IMAGE_DIR!\Processed"
    echo Processing directory: !IMAGE_DIR!
    goto :process_images
) else (
    :: Argument is a file
    set "IMAGE_DIR=%~dp1"
    set "PROCESSED_DIR=!IMAGE_DIR!!GLOBAL_PROCESSED_DIR!"
    echo Processing file: %~nx1
    if not exist "!PROCESSED_DIR!" mkdir "!PROCESSED_DIR!"
    magick "%~1" -resize 18.75%% "!PROCESSED_DIR!\%~n1_main.png"
    shift
    goto :process_next_arg
)

:process_images
:: Initialize a counter to track processed images
set /a count=0

:: Process each specified image format in the directory
for %%x in (jpg jpeg png gif bmp) do (
    for %%I in ("!IMAGE_DIR!\*.%%x") do (
        echo Processing: %%~nxI.%%x
        :: Resize the image and save it in the Processed directory
        magick "%%I" -resize 18.75%% "!PROCESSED_DIR!\%%~nI_main.png"
        if !errorlevel! neq 0 (
            echo Error processing %%I
        ) else (
            set /a count+=1
        )
    )
)

echo Done resizing images. !count! images processed.
pause

:: Shift to the next argument and process
shift
goto :process_next_arg
