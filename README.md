# LpDumper
Makes [LinqPad's][1] `Dump()` method available in Visual Studio

#How to use?
- include a reference to [LpDumper nuget packge][2] 
- call `Dump()` or `DumpFile()` on any object
- for Console apps, add [STAThread] attribute to `Main()` method, for web applications, use `DumpFile()` extension method

[1]:http://linqpad.net
[2]:https://www.nuget.org/packages/LpDumper/1.0.0
