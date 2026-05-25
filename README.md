# OB2PluginSample
Sample plugin for OpenBullet 2 with a dependency.

This sample targets `.NET 10` and supports two development workflows for `RuriLib`:

## 1. Develop against the OpenBullet2 source tree
If you clone this repository next to the main `OpenBullet2` repository, the plugin automatically uses a project reference to `..\OpenBullet2\RuriLib\RuriLib.csproj`.

This is the best workflow for contributors who are actively working on both repositories because:
- you compile against the current source
- you get source navigation and debugging
- you avoid manually copying SDK files around

## 2. Develop against a local SDK folder
If you do not want to clone the full `OpenBullet2` repository, place `RuriLib.dll` in `sdk\RuriLib.dll`, or set the `OpenBullet2PluginSdkDir` MSBuild property to a folder that contains it.

Example:

```powershell
dotnet build -p:OpenBullet2PluginSdkDir=C:\path\to\ob2-plugin-sdk
```

The sample marks `RuriLib` as `Private=false`, so it is used for compilation but is not copied to the plugin output. That avoids shipping a duplicate copy of a core OpenBullet 2 assembly with the plugin.

## Documentation
For user-facing plugin and external library documentation, see the docs site:
- https://docs.openbullet.dev/docs/plugins/general-info
- https://docs.openbullet.dev/docs/lolicode/external-libraries
