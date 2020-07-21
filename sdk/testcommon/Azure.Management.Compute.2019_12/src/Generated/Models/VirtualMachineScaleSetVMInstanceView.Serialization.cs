// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class VirtualMachineScaleSetVMInstanceView : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PlatformUpdateDomain))
            {
                writer.WritePropertyName("platformUpdateDomain");
                writer.WriteNumberValue(PlatformUpdateDomain.Value);
            }
            if (Optional.IsDefined(PlatformFaultDomain))
            {
                writer.WritePropertyName("platformFaultDomain");
                writer.WriteNumberValue(PlatformFaultDomain.Value);
            }
            if (Optional.IsDefined(RdpThumbPrint))
            {
                writer.WritePropertyName("rdpThumbPrint");
                writer.WriteStringValue(RdpThumbPrint);
            }
            if (Optional.IsDefined(VmAgent))
            {
                writer.WritePropertyName("vmAgent");
                writer.WriteObjectValue(VmAgent);
            }
            if (Optional.IsDefined(MaintenanceRedeployStatus))
            {
                writer.WritePropertyName("maintenanceRedeployStatus");
                writer.WriteObjectValue(MaintenanceRedeployStatus);
            }
            if (Optional.IsCollectionDefined(Disks))
            {
                writer.WritePropertyName("disks");
                writer.WriteStartArray();
                foreach (var item in Disks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Extensions))
            {
                writer.WritePropertyName("extensions");
                writer.WriteStartArray();
                foreach (var item in Extensions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(BootDiagnostics))
            {
                writer.WritePropertyName("bootDiagnostics");
                writer.WriteObjectValue(BootDiagnostics);
            }
            if (Optional.IsCollectionDefined(Statuses))
            {
                writer.WritePropertyName("statuses");
                writer.WriteStartArray();
                foreach (var item in Statuses)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PlacementGroupId))
            {
                writer.WritePropertyName("placementGroupId");
                writer.WriteStringValue(PlacementGroupId);
            }
            writer.WriteEndObject();
        }

        internal static VirtualMachineScaleSetVMInstanceView DeserializeVirtualMachineScaleSetVMInstanceView(JsonElement element)
        {
            Optional<int> platformUpdateDomain = default;
            Optional<int> platformFaultDomain = default;
            Optional<string> rdpThumbPrint = default;
            Optional<VirtualMachineAgentInstanceView> vmAgent = default;
            Optional<MaintenanceRedeployStatus> maintenanceRedeployStatus = default;
            Optional<IList<DiskInstanceView>> disks = default;
            Optional<IList<VirtualMachineExtensionInstanceView>> extensions = default;
            Optional<VirtualMachineHealthStatus> vmHealth = default;
            Optional<BootDiagnosticsInstanceView> bootDiagnostics = default;
            Optional<IList<InstanceViewStatus>> statuses = default;
            Optional<string> placementGroupId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("platformUpdateDomain"))
                {
                    platformUpdateDomain = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("platformFaultDomain"))
                {
                    platformFaultDomain = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("rdpThumbPrint"))
                {
                    rdpThumbPrint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmAgent"))
                {
                    vmAgent = VirtualMachineAgentInstanceView.DeserializeVirtualMachineAgentInstanceView(property.Value);
                    continue;
                }
                if (property.NameEquals("maintenanceRedeployStatus"))
                {
                    maintenanceRedeployStatus = MaintenanceRedeployStatus.DeserializeMaintenanceRedeployStatus(property.Value);
                    continue;
                }
                if (property.NameEquals("disks"))
                {
                    List<DiskInstanceView> array = new List<DiskInstanceView>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DiskInstanceView.DeserializeDiskInstanceView(item));
                    }
                    disks = array;
                    continue;
                }
                if (property.NameEquals("extensions"))
                {
                    List<VirtualMachineExtensionInstanceView> array = new List<VirtualMachineExtensionInstanceView>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualMachineExtensionInstanceView.DeserializeVirtualMachineExtensionInstanceView(item));
                    }
                    extensions = array;
                    continue;
                }
                if (property.NameEquals("vmHealth"))
                {
                    vmHealth = VirtualMachineHealthStatus.DeserializeVirtualMachineHealthStatus(property.Value);
                    continue;
                }
                if (property.NameEquals("bootDiagnostics"))
                {
                    bootDiagnostics = BootDiagnosticsInstanceView.DeserializeBootDiagnosticsInstanceView(property.Value);
                    continue;
                }
                if (property.NameEquals("statuses"))
                {
                    List<InstanceViewStatus> array = new List<InstanceViewStatus>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InstanceViewStatus.DeserializeInstanceViewStatus(item));
                    }
                    statuses = array;
                    continue;
                }
                if (property.NameEquals("placementGroupId"))
                {
                    placementGroupId = property.Value.GetString();
                    continue;
                }
            }
            return new VirtualMachineScaleSetVMInstanceView(Optional.ToNullable(platformUpdateDomain), Optional.ToNullable(platformFaultDomain), rdpThumbPrint.Value, vmAgent.Value, maintenanceRedeployStatus.Value, Optional.ToList(disks), Optional.ToList(extensions), vmHealth.Value, bootDiagnostics.Value, Optional.ToList(statuses), placementGroupId.Value);
        }
    }
}
