param (
    [string]$Feature
)

if (-not $Feature) {
    Write-Host "Usage: .\create-feature.ps1 FeatureName"
    exit 1
}

$basePath = "..\\Features\\$Feature"
New-Item -ItemType Directory -Force -Path "$basePath\\Models" | Out-Null

@"
public class ${Feature}ViewModel { }
"@ | Set-Content "$basePath\\${Feature}ViewModel.cs"

@"
public interface I${Feature}Service { }
"@ | Set-Content "$basePath\\I${Feature}Service.cs"

@"
public class ${Feature}Service : I${Feature}Service { }
"@ | Set-Content "$basePath\\${Feature}Service.cs"

@"
public class ${Feature}Model { }
"@ | Set-Content "$basePath\\Models\\${Feature}Model.cs"

Write-Host "✅ Feature '$Feature' created under App/Features."
