﻿![Clover logo](https://www.clover.com/assets/images/public-site/press/clover_primary_gray_rgb.png)

# Clover SDK for Windows POS integration

## Version

Current version: 3.0.0

## Overview

This SDK enables your Windows point-of-sale (POS) system to communicate with a [Clover® payment device](https://www.clover.com/pos-hardware/). Learn more about [Clover integrations](https://www.clover.com/integrations).

**Platforms supported:**
  * Windows 10
  * Windows 8
  
**.NET Frameworks supported:**
  * .NET 4.5 (specifically, .NET 4.5.2)
  * .NET 4.0 "backwards compatibility"

**Note**: Support for .NET 4.0 will be removed from the Clover Connector package in a future release.
  
## Connecting to a Clover device 

The Windows project includes three options for connecting to a Clover device. 

1. .NET DLL - CloverConnector.DLL can be used directly by a .NET application. This option requires .NET 4.0 or 4.5.
2. Clover Connector REST API Service - This option requires your POS to implement a REST service in order to receive callbacks.
3. Clover Connector WebSocket API Service - This option requires your POS to implement a WebSocket client in order to communicate with the service and receive callbacks.

**Note**: The REST and WebSocket API services are deprecated and will be removed from the Clover Connector package in a future release.

To work with the project effectively, you will need:
- A computer or virtual machine running Windows. The SDK supports Windows 10, Windows 8, and Windows 7.
- An IDE, such as [Visual Studio](https://www.visualstudio.com/downloads/).
- To experience transactions end-to-end from the merchant and customer perspectives, we also recommend ordering a [Clover DevKit](http://cloverdevkit.com/collections/devkits/products/clover-mini-dev-kit).

## NuGet Package

Use NuGet references to easily include Remote Pay Windows in your .NET project
https://www.nuget.org/packages/Clover.RemotePayWindows

```cmd
Install-Package Clover.RemotePayWindows -Version 3.0.0
```

## Installing the SDK and Services

There are two sets of binaries supplied, targeting different .NET Frameworks, the .NET 4.5 and .NET 4.0 backwards compatible.

* The .NET 4.5 binaries are able to use TLS 1.2 network security when talking to Clover Devices using [Secure Network Pay Display](https://docs.clover.com/build/secure-network-pay-display/).
* The .NET 4.0 binaries are the same platform as the previous releases of the Clover Windows SDK, and are provided for backwards compatibility.


There are several installers for each .NET Framework Target.

### For development:

  * CloverSDKSetup.exe - This setup executable will set up the .NET 4.5, .NET 4.0, and sample applications in Program Files for development work.

### For deployment:

  * CloverRESTServiceSetup.exe - This file installs the REST Clover Connector Service and the USB driver for the Clover device.
  * CloverWebSocketServiceSetup.exe - This file installs the WebSocket Clover Connector Service and the USB driver for the Clover device.
  * CloverUsbDrivers.zip - This file contains the 14 x64 and x86 USB driver MSI installers for local installation and for product deployment

## Building the SDK

The SDK has the following structure. 

```
.
├── examples                           # Contains the C# Example application
│	└── CloverExamplePOS
│	└── exampleMessages
├── lib
│	└── CloverConnector                # CloverConnector module code
│	└── CloverWindowsSDK               # C# port of Clover Android SDK classes
│	└── CloverWindowsTransport         # Transport definitions (USB, WebSocket)
├── packages                           # Contains third-party dependencies
│	└── lib
└── services
	└── CloverWindowsSDKRESTService    # Source for the Windows REST Service
	└── CloverWindowsWebSocketService  # Source for the Windows WebSocket Service
	└── shared                         # Contains code shared by the Services
```

## Working with the Example POS

To build and run the example POS application using .NET and VisualStudio 2015:
 1. Open **Clover.sln**
 2. Build all projects
 3. Select the **CloverExamplePOS**
 4. Click **Run**

## Setting up a virtual machine (Mac, etc.)

1. Install [VMWare Fusion](https://www.vmware.com/products/fusion.html). (NOTE: VirtualBox will not see the device properly.)
2. Run the driver installers.

## Debugging

To debug the device in TCP/IP using Android Debug Bridge (adb):
1. Plug the device into a laptop, then select **Connect to Mac**. This will set the device up for debugging on port 5555.
2. Enter `>adb tcpip 5555` on the command line.

NOTE: If you see the message `error: more than one device and emulator`, you will need to specify the device by ID. To do this: 

3. Enter `>adb devices` on the command line. This will retrieve a list of available devices similar to the one below.

	```
	List of devices attached
	C010UC43040345	device
	C030UQ50550081	device
	```

4. Modify the command from step 2 to include the ID for the device you want to set up. 
	
	**Example:** `>adb -s C030UQ50550081 tcpip 5555`
	
	This should cause the device to disconnect. 
	
5. Select **Connect to Windows**.
6. Reconnect to the device using this command:
	
	`>adb connect 192.168.1.3:5555`

7. Enter `adb logcat`, or connect with the debugger via IP.

	Example: `>adb devices`
	
	Your results will look like this: 
	
	```
	List of devices attached
	C010UC43040345	device
	192.168.1.3:5555 device
	```
## Additional resources 

- [Release Notes](https://github.com/clover/remote-pay-windows/releases)
- [Secure Network Pay Display](https://docs.clover.com/build/secure-network-pay-display/)
- [Tutorial for the Windows SDK](https://docs.clover.com/build/getting-started-with-cloverconnector/?sdk=windows)
- [API Documentation](http://clover.github.io/remote-pay-windows/3.0.0/cloverconnector/html/index.html)
- [Clover Developer Community](https://community.clover.com/index.html)