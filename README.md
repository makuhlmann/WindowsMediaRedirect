# WindowsMediaRedirect
This tool allows older Windows Media Player versions to connect to the metadata servers hosted by Microsoft.

Supported Versions:
- Windows Media Player 9 Series
- Windows Media Player 10
- Windows Media Player 11
- Windows Media Player 12 (on Windows 7, Windows 8 and newer don't need this)

## How to use
Simply copy and run the WindowsMediaRedirector.exe on the target computer. On Windows Vista and newer you may need to launch it as Administrator.

If you wish to set this tool up as a server for multiple devices in your network, simply launch it in a command line with the IP address it should listen on as the first parameter. You may also need to allow connections in the firewall.

After the application launches, it displays all the entries that need to be added in the hosts file. It should look like this:

```
127.0.0.1       redir.metaservices.microsoft.com
127.0.0.1       images.metaservices.microsoft.com
127.0.0.1       toc.music.metaservices.microsoft.com
127.0.0.1       windowsmedia.com
127.0.0.1       www.windowsmedia.com
127.0.0.1       services.windowsmedia.com
```

The hosts file can usually be found here:

- C:\WINDOWS\hosts  --  (Windows 98 and Me)
- C:\WINNT\system32\drivers\etc\hosts -- (Windows 2000)
- C:\WINDOWS\system32\drivers\etc\hosts -- (Windows XP, Vista and 7)

Please note that on Windows Vista and 7 you need administrator privileges to edit the file. The easiest way is to copy the file to the desktop, modify it, and copy it back into the etc folder.

On Windows 98 and Me the hosts file might not exist. Just rename the hosts.sam to hosts. Furthermore if you encounter issues you might need to enable DNS resolution in the TCP-IP settings within the network settings, otherwise the hosts file could be ignored.

## FAQ
### Why is this needed?
Microsoft has changed the URLs that are used to request the media information in Windows Media Player without setting up a proper redirect for the old domains that are still owned by Microsoft.

### How does this tool work?
This tool creates a small web server that redirects certain old known addresses to the new metadata servers. This works in combination with some entries to the hosts file.

### Why is Windows Media Player 7 or 8 not supported?
Older Windows Media Player versions expects an entirely differen XML format for which I could not find any examples or references.

### Why is a conversion of metadata taking place / Why are album images not always redirected
Windows Media Player 9 Series is a bit picky with the exact XML format so I had to convert it to the style it expects. Furthermore WMP 9 seems to ignore HTTP 302 responses most of the times when it tries to fetch the album image, thus it has to be downloaded and delivered by this tool.

### Why does the code look so unoptimized
The code is written to be compatible with C# 2.0 so that it can be compiled using Visual Studio 2005. This ensures that the resulting .exe is compatible with all old Windows versions that can run the .NET Framework 2.0.

### Why do the "Find Album Info" or "View Album Info" buttons not work?
This tool only fixes the automatic metadata lookup that happens the first time an Audio-CD is inserted into the CD drive. The buttons use a web interface to allow looking up for the correct information, however that service has been discontinued since many years and would be very difficult to recreate.

### Wrong metadata was downloaded / edited. How can I delete them all?
Simply delete all files in this folder:

- C:\WINDOWS\Application Data\Microsoft\Media Player --  (Windows 98 and Me)
- C:\Documents and Settings\User\Local Settings\Application Data\Microsoft\Media Player  --  (Windows 2000 and XP)
- C:\Users\User\AppData\Local\Microsoft\Media Player  --  (Windows Vista and 7)
