$editorVersion = "2021.3.14f1"

# Check if the UnitySetup module is installed
if (-not (Get-Module -ListAvailable -Name UnitySetup)) {
    # Prompt to install the UnitySetup module
    Write-Host "Installing UnitySetup module..."
    Install-Module -Name UnitySetup -Scope CurrentUser -Force -AllowClobber
    Write-Host "Done"
}

# Import the UnitySetup module
Import-Module UnitySetup

# Check if the desired Unity version is installed
$unityEditor = Get-UnitySetupInstance | Select-UnitySetupInstance -Version $editorVersion
if (-not $unityEditor) {
    # Install Unity version
    Write-Host "Installing Unity $editorVersion..."

    # Note: You may need to adjust this command based on the components you need
    Find-UnitySetupInstaller -Version $editorVersion -Components Windows | Install-UnitySetupInstance

    $unityEditor = Get-UnitySetupInstance | Select-UnitySetupInstance -Version $editorVersion

    if (-not $unityEditor) {
        Write-Error "Installation failed or Unity path not found."
        Read-Host "Press Enter to exit"
        exit
    }

    Write-Host "Done"
}

& Start-UnityEditor -Version $editorVersion -Project (Get-UnityProjectInstance .\)
