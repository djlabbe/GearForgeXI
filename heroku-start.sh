#!/bin/bash

# Copy frontend
echo "📦 Copying React build to wwwroot..."
rm -rf FFXIComp.API/wwwroot
mkdir -p FFXIComp.API/wwwroot
cp -R ffxicomp-client/dist/* FFXIComp.API/wwwroot/

# Publish .NET app to a temporary folder
echo "🔨 Publishing backend..."
dotnet publish FFXIComp.API/FFXIComp.API.csproj -c Release -o FFXIComp.API/publish

# Run the app
echo "🚀 Launching backend..."
cd FFXIComp.API/publish
dotnet FFXIComp.API.dll