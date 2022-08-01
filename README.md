# csharp
Introduction to C#.NET

## dotnet in terminal / pwsh
add this to /andi/.bashrc
```bash
export PATH=$PATH:$HOME/.dotnet
export DOTNET_ROOT=$HOME/.dotnet```

same for sudo
https://superuser.com/questions/927512/how-to-set-path-for-sudo-commands

```powershell
sudo pwsh
$Env:PATH += ';/home/andi/.dotnet'
```

## install local https certificate on linux
https://docs.microsoft.com/en-us/aspnet/core/security/enforcing-ssl?view=aspnetcore-6.0&tabs=visual-studio#trust-the-aspnet-core-https-development-certificate-on-windows-and-macos
