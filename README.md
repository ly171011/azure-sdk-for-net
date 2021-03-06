# Windows Azure SDK for .NET

The Windows Azure SDK for .NET allows you to build Windows Azure applications 
that take advantage of scalable cloud computing resources.

This repository contains the open source subset of the .NET SDK. For documentation of the 
complete SDK, please see the [Windows Azure .NET Developer Center](http://www.windowsazure.com/en-us/develop/net/).

# Features

- Storage

    > Available in the separate [Storage repository](https://github.com/WindowsAzure/azure-storage-net/)

  - Tables
    - Create/Delete Tables
    - Query/Create/Read/Update/Delete Entities
  - Blobs
    - Create/Read/Update/Delete Blobs
  - Queues
    - Create/Delete Queues
    - Insert/Peek Queue Messages
    - Advanced Queue Operations

- Configuration Manager
- Management Libraries (Preview)
  - Compute
    - Virtual Machines
    - Hosted Services
  - Infrastructure
  - Media Services Management
  - Monitoring Services
  - Scheduler Client & Management
  - Service Bus Management
  - Storage
  - Windows Azure Store
  - SQL Database
  - Virtual Network
  - Web Sites
- Media Services

    > Available in the separate [Media Services repository](http://github.com/WindowsAzure/azure-sdk-for-media-services/tree/master/src/net/Client)

- Mobile Services

    > Available in the separate [Mobile Services repository](https://github.com/WindowsAzure/azure-mobile-services)

# Getting started

The complete Windows Azure SDK can be downloaded from the [Windows Azure Downloads Page](http://www.windowsazure.com/en-us/downloads/?sdk=net) and ships with support for building deployment packages, integrating with tooling, rich command line tooling, and more.

For the best development experience, developers should use the official Microsoft NuGet packages for libraries. NuGet packages are regularly updated with new functionality and hotfixes. 

## Target Frameworks

- .NET Framework 4.5 and newer
- .NET Framework 4.0
- Storage Libraries are available for Windows 8 for Windows Store development as well as Windows Phone 8

As of 10/2013, SDK 2.2 supports targeting only .NET Framework 4.0 and newer.

> Need support for previous versions of .NET such as 3.5? Version 2.1 of the Windows Azure SDK for .NET supports this version and can still be used today.
 
## Requirements

- Windows Azure Subscription: To call Windows Azure services, you need to first [create an account](https://account.windowsazure.com/Home/Index). Sign up for a free trial or use your MSDN subscriber benefits.
- Hosting: To host your .NET code in Windows Azure, you additionally need to download the full Windows Azure SDK for .NET - which includes packaging,
    emulation, and deployment tools, or use Windows Azure Web Sites to deploy ASP.NET web applications.

## Need Help?
Be sure to check out the Windows Azure [Developer Forums on MSDN](http://go.microsoft.com/fwlink/?LinkId=234489) if you have trouble with the provided code or use StackOverflow.

## Collaborate & Contribute

We gladly accept community contributions.

- Issues: Please report bugs using the Issues section of GitHub
- Forums: Interact with the development teams on StackOverflow or the Windows Azure Forums
- Source Code Contributions: Please follow the [contribution guidelines for Windows Azure open source](http://windowsazure.github.io/guidelines.html) that details information on onboarding as a contributor 

For general suggestions about Windows Azure please use our [UserVoice forum](http://www.mygreatwindowsazureidea.com/forums/34192-windows-azure-feature-voting).

# Storage Client Library

To use storage services (blog, table, queue), the storage client library provides rich APIs for interacting with the storage service.

The Storage Client Library ships with the Windows Azure SDK for .NET and also on NuGet. You'll find the latest version and hotfixes on NuGet via the `WindowsAzure.Storage` package.

## Storage source code

### v3.0+

With the release of the 3.0.0 storage client library, you can find the latest storage library (and associated issues) in the separate repo [azure-storage-net](http://github.com/WindowsAzure/azure-storage-net/).

### v2.0.1.4

The latest version of the v2.1.x storage client library is available in the azure-sdk-for-net repo under the [`v2.1.0.4` tag](https://github.com/WindowsAzure/azure-sdk-for-net/releases/tag/v2.1.0.4). 

## NuGet package install

The storage client libaries are delivered via NuGet officially by Microsoft, ready for use within your project. They are installed with the [NuGet package manager](http://www.nuget.org/) which is built into Visual Studio 2013; for earlier releases of Visual Studio, NuGet is a quick and easy extension to install.

`Install-Package WindowsAzure.Storage`

## Storage code samples

> Note:
> How-Tos focused around accomplishing specific tasks are available on the [Windows Azure .NET Developer Center](http://www.windowsazure.com/en-us/develop/net/).

### Creating a Table

First, include the classes you need (in this case we'll include the Storage and Table
and further demonstrate creating a table):

```csharp
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
```

To perform an operation on any Windows Azure resource you will first instantiate
a *client* which allows performing actions on it. The resource is known as an 
*entity*. To do so for Table you also have to authenticate your request:

```csharp
var storageAccount = CloudStorageAccount.Parse(
    CloudConfigurationManager.GetSetting("StorageConnectionString"));
var tableClient = storageAccount.CreateCloudTableClient();
```

Now, to create a table entity using the client:

```csharp
CloudTable peopleTable = tableClient.GetTableReference("people");
peopleTable.Create();
```

# Windows Azure Management Libraries

Automate, configure and command your Windows Azure deployments, infrastructure and accounts with the Windows Azure Management Libraries.

> *Preview:* At this time the Windows Azure Management Libraries are in the preview state as the teams gather feedback and prepare for the initial release. Please enjoy using the libraries and source in any capacity, but understand that there may be breaking changes with the 1.0 release.

## Download & Install

### Via Git

To get the source code of the SDK via git just type:

```bash
git clone git://github.com/WindowsAzure/azure-sdk-for-net.git
cd azure-sdk-for-net\libraries
```

### Via NuGet

Official binaries are distributed by Microsoft and available using the .NET package manager [NuGet](http://www.nuget.org/).

To get all of the management libraries setup in your project:

`Install-Package Microsoft.WindowsAzure.Management.Libraries -IncludePrerelease`

> You can also install just the management library for a service of interest. To deploy a virtual machine to the cloud, the `Microsoft.WindowsAzure.Management.Compute` package can be used, for example.

### Code Samples

This code would result with a list of the regions in the Windows Azure fabric. The location object provided in the result provides properties to define which assets are supported by each region. 

```csharp
using (ManagementClient client = CloudContext.Clients.CreateManagementClient(Credentials))
{
    var result = await client.Locations.ListAsync();
    var locations = result.Locations;
    foreach (var location in locations)
    {
        Console.WriteLine("Location: {0}", location.Name);

        foreach (var feature in location.AvailableServices)
        {
            Console.WriteLine(feature);
        }
    }
}
```

To create a storage account,The code below will create a storage account in the West US region. 

```csharp
var storageAccountName = "mystorageaccount";

using (StorageManagementClient client =
    CloudContext.Clients.CreateStorageManagementClient(Credentials))
{
    await client.StorageAccounts.CreateAsync(
        new StorageAccountCreateParameters
        {
            ServiceName = storageAccountName,
            Location = LocationNames.WestUS
        });
}
```

The code below will obtain the storage account keys to construct a connection string on the fly.

```csharp
var storageAccountName = "mystorageaccount";

using (StorageManagementClient client =
    CloudContext.Clients.CreateStorageManagementClient(Credentials))
{
    var keys = await
        client.StorageAccounts.GetKeysAsync(storageAccountName);

    string connectionString = string.Format(
        CultureInfo.InvariantCulture,
        "DefaultEndpointsProtocol=https;AccountName={0};AccountKey={1}",
        storageAccountName, keys.SecondaryKey);

    return connectionString;
}
```

The following code will create a new (empty) Cloud Service in the Windows Azure fabric. 

```csharp
var cloudServiceName = "MyCloudService";

using (ComputeManagementClient client =
    CloudContext.Clients.CreateComputeManagementClient(Credentials))
{
    await client.HostedServices.CreateAsync(
        new HostedServiceCreateParameters
        {
            ServiceName = cloudServiceName,
            Location = LocationNames.WestUS
        });
}
```

Once a storage account has been created, the Windows Storage SDK can be used to upload .CSPKG files into the storage account. Then, the cloud service could be deployed. The code below demonstrates this functionality. 

```csharp
var blobs = CloudStorageAccount.Parse(storageConnectionString).CreateCloudBlobClient();

var container = blobs.GetContainerReference("deployments");

await container.CreateIfNotExistsAsync();

await container.SetPermissionsAsync(
    new BlobContainerPermissions()
    {
        PublicAccess = BlobContainerPublicAccessType.Container
    });

var blob = container.GetBlockBlobReference("MyCloudService.cspkg");

await blob.UploadFromFileAsync("MyCloudService.cspkg", FileMode.Open);

var cloudServiceName = "MyCloudService";

using (ComputeManagementClient client =
    CloudContext.Clients.CreateComputeManagementClient(Credentials))
{
    await client.Deployments.CreateAsync(cloudServiceName,
        DeploymentSlot.Production,
        new DeploymentCreateParameters
        {
            Name = cloudServiceName + "Prod",
            Label = cloudServiceName + "Prod",
            PackageUri = blob.Uri,
            Configuration = File.ReadAllText("MyCloudService.cscfg"),
            StartDeployment = true
        });
}
```

# Learn More

- [Windows Azure .NET Developer Center](http://www.windowsazure.com/en-us/develop/net/)
- [Windows Azure SDK Reference for .NET - MSDN](http://msdn.microsoft.com/en-us/library/dd179380.aspx)
