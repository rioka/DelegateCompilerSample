# DelegateDecompilerSample

Working an old application, I found out that after upgrading `DelegateDecompiler` from v0.18.1 to v0.28.0 (latest version available when I upgrade package), I found out some code was no longer working, and an exception was thrown.


I then decided to isolate the problem in this sample project, and opened an [issue](https://github.com/hazzik/DelegateDecompiler/issues/162). Issue was eventually fixed (thanks [hazzik](https://github.com/hazzik)).

## What's in this repository

|Project|Description|
|-|-|
|`DelegateCompilerSample.Core`|Library with core components|
|`DelegateCompilerSample.Use0_18_1`|Sample application using `v0.18.1`|
|`DelegateCompilerSample.Use0_28_0`|Sample application using `v0.28.0`|
|`DelegateCompilerSample.Use0_28_2`|Sample application using `v0.28.2`|

The 3 applications share most of the code (via `DelegateCompilerSample.Core` and links), non shared parts being just a "copy & paste" exercise.

## Caveats

Since different versions of `EntityFramework` are used (v6.1.3 and v6.4.4), when running `Enable-Migrations` (or `Add-Migrations`) after `DelegateCompilerSample.Use0_28_2` was created resulted in an error

> Exception calling "LoadFrom" with "1" argument(s): "Could not load file or assembly 
'file:///D:\****\DelegateCompilerSample\packages\EntityFramework.6.4.4\tools\EntityFramework.PowerShell.Utility.dll' or one of its dependencies. The system 
cannot find the file specified."

This is somehow a known issue when running pre-v6.3 and post-v6.3 `EntityFramework` versions in the same solution. To fix that, `DelegateCompilerSample.Use0_18_1` was temporarily unloaded from solution, then reloaded again.