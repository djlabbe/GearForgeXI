#!/bin/bash

# Copy React build from ffxicomp-client/dist to API's wwwroot
echo "🔁 Copying frontend build to wwwroot..."
rm -rf FFXIComp.API/wwwroot
mkdir -p FFXIComp.API/wwwroot
cp -R ffxicomp-client/dist/* FFXIComp.API/wwwroot/

# Launch the .NET API
echo "🚀 Starting .NET app..."
cd FFXIComp.API
dotnet FFXIComp.API.dll