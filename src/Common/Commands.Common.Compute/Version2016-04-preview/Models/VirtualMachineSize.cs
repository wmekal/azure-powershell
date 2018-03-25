// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Common.Compute.Version2016_04_preview.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes the properties of a VM size.
    /// </summary>
    public partial class VirtualMachineSize
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineSize class.
        /// </summary>
        public VirtualMachineSize()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineSize class.
        /// </summary>
        /// <param name="name">The name of the virtual machine size.</param>
        /// <param name="numberOfCores">The number of cores supported by the
        /// virtual machine size.</param>
        /// <param name="osDiskSizeInMB">The OS disk size, in MB, allowed by
        /// the virtual machine size.</param>
        /// <param name="resourceDiskSizeInMB">The resource disk size, in MB,
        /// allowed by the virtual machine size.</param>
        /// <param name="memoryInMB">The amount of memory, in MB, supported by
        /// the virtual machine size.</param>
        /// <param name="maxDataDiskCount">The maximum number of data disks
        /// that can be attached to the virtual machine size.</param>
        public VirtualMachineSize(string name = default(string), int? numberOfCores = default(int?), int? osDiskSizeInMB = default(int?), int? resourceDiskSizeInMB = default(int?), int? memoryInMB = default(int?), int? maxDataDiskCount = default(int?))
        {
            Name = name;
            NumberOfCores = numberOfCores;
            OsDiskSizeInMB = osDiskSizeInMB;
            ResourceDiskSizeInMB = resourceDiskSizeInMB;
            MemoryInMB = memoryInMB;
            MaxDataDiskCount = maxDataDiskCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the virtual machine size.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the number of cores supported by the virtual machine
        /// size.
        /// </summary>
        [JsonProperty(PropertyName = "numberOfCores")]
        public int? NumberOfCores { get; set; }

        /// <summary>
        /// Gets or sets the OS disk size, in MB, allowed by the virtual
        /// machine size.
        /// </summary>
        [JsonProperty(PropertyName = "osDiskSizeInMB")]
        public int? OsDiskSizeInMB { get; set; }

        /// <summary>
        /// Gets or sets the resource disk size, in MB, allowed by the virtual
        /// machine size.
        /// </summary>
        [JsonProperty(PropertyName = "resourceDiskSizeInMB")]
        public int? ResourceDiskSizeInMB { get; set; }

        /// <summary>
        /// Gets or sets the amount of memory, in MB, supported by the virtual
        /// machine size.
        /// </summary>
        [JsonProperty(PropertyName = "memoryInMB")]
        public int? MemoryInMB { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of data disks that can be attached
        /// to the virtual machine size.
        /// </summary>
        [JsonProperty(PropertyName = "maxDataDiskCount")]
        public int? MaxDataDiskCount { get; set; }

    }
}
