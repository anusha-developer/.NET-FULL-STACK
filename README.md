# .NET-FULL-STACK
C# .NET WEB API  with Angular
steps to install Cors
==============================
Step1:Go to visual Code 
step2:Go to tools
step3:Go to NuGet package Manager
step4:Go to package manager console
step5::Open  console and Install-Package Microsoft.AspNet.WebApi.Cors
step6:open WebApicConfig.cs
step7:Write code    config.EnableCors(new EnableCorsAttribute("*", "*", "GET,POST,PUT,DELETE"));

