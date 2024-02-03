# target path
$path = ".\ModFiles"

New-Item -Type Directory -Path ".\ModFiles" -Force | Out-Null

Copy-Item -Path ".\icon.png" -Destination "$($path)\icon.png"
Copy-Item -Path ".\README.md" -Destination "$($path)\README.md"
Copy-Item -Path ".\manifest.json" -Destination "$($path)\manifest.json"
Copy-Item -Path ".\bin\Release\JetpackLearning.dll" -Destination "$($path)\JetpackLearning.dll"

$files = Get-ChildItem -Path $path
Compress-Archive -Path $files -DestinationPath "mod.zip" -Force