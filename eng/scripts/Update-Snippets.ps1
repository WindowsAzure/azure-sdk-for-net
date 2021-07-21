[CmdletBinding()]
param (
    [Parameter(Position=0)]
    [ValidateNotNullOrEmpty()]
    [string] $ServiceDirectory,

    [Parameter()]
    [switch] $StrictMode
)

$root = "$PSScriptRoot/../../sdk"

# special casing * here because single invocation of SnippetGenerator is much faster than
# running it per service directory
if ($ServiceDirectory -and ($ServiceDirectory -ne "*")) {
    $root += '/' + $ServiceDirectory
}

if (-not (Test-Path env:TF_BUILD)) { $StrictMode = $true }

$ProgressPreference = "SilentlyContinue"
$ToolsFeed = "https://pkgs.dev.azure.com/azure-sdk/public/_packaging/azure-sdk-tools/nuget/v2"
$ToolsFeedName = "azure-sdk-tools-feed"
Register-PSRepository -Name $ToolsFeedName -SourceLocation $ToolsFeed -ScriptSourceLocation $ToolsFeed -InstallationPolicy Trusted -ErrorAction SilentlyContinue
$generatorPackage = Install-Package SnippetGenerator -Scope CurrentUser -Source LocalToolsNugetFeed -Destination . -Force
$generatorAssembly = ".\$($generatorPackage.Name).$($generatorPackage.Version)\tools\net5.0\SnippetGenerator.dll"
Write-Host $generatorAssembly

if (Test-Path $generatorAssembly)
{
    if($StrictMode) {
        Resolve-Path "$root" | %{ dotnet $generatorAssembly -b "$_" -sm}
    } else {
        Resolve-Path "$root" | %{ dotnet $generatorAssembly -b "$_" }
    }
}
else
{
    Write-Error "Could not find assembly at ${generatorAssembly}"
    exit 1
}
