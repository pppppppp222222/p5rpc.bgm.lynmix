# Set Working Directory
Split-Path $MyInvocation.MyCommand.Path | Push-Location
[Environment]::CurrentDirectory = $PWD

Remove-Item "$env:RELOADEDIIMODS/p5rpc.bgm.lynmix/*" -Force -Recurse
dotnet publish "./p5rpc.bgm.lynmix.csproj" -c Release -o "$env:RELOADEDIIMODS/p5rpc.bgm.lynmix" /p:OutputPath="./bin/Release" /p:ReloadedILLink="true"

# Restore Working Directory
Pop-Location