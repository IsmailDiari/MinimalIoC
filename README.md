# MinimalIoC
A minimal IoC implementation using AutoFac for .Net core projects.  
This solution automates the registration of dependencies of type <Interface,Implementation> (**the basic commonly used case**).  
You can extend its behavior to support custom configurations(defines scopes, custom dependencies registration,...).  
I integrated two UI implementations, one for .Net core 6 using the new single file template and a second for previous versions of .Net core with a program.cs file and startup.cs file.  
# Unit Tests
I did not set unit tests here, it is bad I know! Maybe for the next release.
