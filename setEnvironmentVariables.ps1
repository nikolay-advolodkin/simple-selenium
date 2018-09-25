Param(
[string]$sauceUserName,
[string]$sauceAccessKey
)
Write-Host "sauce.userName that was passed in from Azure DevOps=>$sauceUserName"
Write-Host "sauce.accessKey that was passed in from Azure DevOps=>$sauceAccessKey"

[Environment]::SetEnvironmentVariable("SAUCE_USERNAME", "$sauceUserName", "User")
[Environment]::SetEnvironmentVariable("SAUCE_KEY", "$sauceAccessKey)", "User")
Write-Host "Here are the variables that were stored in SAUCE_KEY=>"$Env:SAUCE_KEY
Write-Host "Here are the variables that were stored=>"$Env:SAUCE_ACCESS_KEY
Write-Host "Here are the variables that were stored in SAUCE_USERNAME=>"$Env:SAUCE_USERNAME
