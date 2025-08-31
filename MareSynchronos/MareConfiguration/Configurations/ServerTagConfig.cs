﻿using UnsungSync.MareConfiguration.Models;

namespace UnsungSync.MareConfiguration.Configurations;

public class ServerTagConfig : IMareConfiguration
{
    public Dictionary<string, ServerTagStorage> ServerTagStorage { get; set; } = new(StringComparer.OrdinalIgnoreCase);
    public int Version { get; set; } = 0;
}