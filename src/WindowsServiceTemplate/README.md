# Install

Before you can use the WindowsServiceTemplate, you need to install the service.
To do so (thanks to [Alexey Obukhov](https://stackoverflow.com/a/37992650)):

1. Build the project.
2. Right click on project and select 'Open Folder in File Explorer'. Go to the `bin\Debug` folder.
3. Run `install.bat` - it will prompt for elevated priviliges.

# Uninstall

Run `uninstall.bat` from the same `bin\Debug` folder.

# To Debug

You need to install the service in order to debug it. You cannot run it with `F5` from within Visual Studio.


1. Run Visual Studio with elevated privileges
2. Select *Debug* -> *Attach to Process...*
3. Check *Show processes from all users*
4. In the list find and select *WindowsServiceTemplate*.

