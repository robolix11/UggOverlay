# PostBuild.ps1
$assemblyInfoPath = "$PSScriptRoot\Properties\AssemblyInfo.cs"
$assembly = Get-Content $assemblyInfoPath
$version = [regex]::Match(($assembly -join "`n"), 'AssemblyVersion\("(\d+\.\d+\.\d+\.\d+)"\)').Groups[1].Value

$outputFolder = Join-Path "$PSScriptRoot\Versions" $version
New-Item -ItemType Directory -Force -Path $outputFolder | Out-Null

$zipPath = Join-Path $outputFolder "v$version.zip"
Compress-Archive -Path "$PSScriptRoot\bin\Release\*" -DestinationPath $zipPath -Force

$xml = @"
<?xml version="1.0" encoding="UTF-8"?>
<item>
  <version>$version</version>
  <url>https://github.com/robolix11/UggOverlay/releases/download/v$version/v$version.zip</url>
  <changelog></changelog>
  <mandatory>true</mandatory>
</item>
"@

Set-Content -Path (Join-Path $outputFolder 'update.xml') -Value $xml -Encoding UTF8
