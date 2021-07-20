# Generated code configuration

Run `dotnet build /t:GenerateCode` to generate code.

``` yaml
azure-arm: true
library-name: MachineLearningServices
namespace: Azure.ResourceManager.MachineLearningServices
require: https://raw.githubusercontent.com/Azure/azure-rest-api-specs/0d57823261fcdd0e5528a57f727ad4c693b692b1/specification/machinelearningservices/resource-manager/readme.md
tag: package-2021-03-01-preview

modelerfour:
  lenient-model-deduplication: true
clear-output-folder: true
skip-csproj: true
payload-flattening-threshold: 2

operation-group-to-resource-type:
  WorkspaceFeatures: Microsoft.MachineLearningServices/workspaces/features
  Usages: Microsoft.MachineLearningServices/locations/usages
  VirtualMachineSizes: Microsoft.MachineLearningServices/locations/vmSizes
  Quotas: Microsoft.MachineLearningServices/locations/quotas
  WorkspaceSkus: Microsoft.MachineLearningServices/workspaces/skus
  PrivateLinkResources: Microsoft.MachineLearningServices/workspaces/privateLinkResources
  StorageAccount: Microsoft.MachineLearningServices/workspaces/storageAccounts
operation-group-to-resource:
  Quotas: NonResource # POST and GET
operation-group-to-parent:
  Quotas: subscriptions
directive:
  - from: swagger-document
    where: $.definitions.ComputeNodesInformation.properties
    transform: delete $.nextLink;
    reason: Duplicated "nextLink" property defined in schema 'AmlComputeNodesInformation' and 'ComputeNodesInformation'
```
