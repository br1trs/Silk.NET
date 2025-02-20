// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.Vulkan;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.NV
{
    [Extension("VK_NV_external_memory_capabilities")]
    public unsafe partial class NVExternalMemoryCapabilities : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_NV_external_memory_capabilities";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalImageFormatPropertiesNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceExternalImageFormatProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0)] ImageType type, [Count(Count = 0)] ImageTiling tiling, [Count(Count = 0)] ImageUsageFlags usage, [Count(Count = 0)] ImageCreateFlags flags, [Count(Count = 0)] ExternalMemoryHandleTypeFlagsNV externalHandleType, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ExternalImageFormatPropertiesNV* pExternalImageFormatProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalImageFormatPropertiesNV", Convention = CallingConvention.Winapi)]
        public partial Result GetPhysicalDeviceExternalImageFormatProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0)] ImageType type, [Count(Count = 0)] ImageTiling tiling, [Count(Count = 0)] ImageUsageFlags usage, [Count(Count = 0)] ImageCreateFlags flags, [Count(Count = 0)] ExternalMemoryHandleTypeFlagsNV externalHandleType, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ExternalImageFormatPropertiesNV pExternalImageFormatProperties);

        public NVExternalMemoryCapabilities(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

