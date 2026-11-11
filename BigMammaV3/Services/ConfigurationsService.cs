using BigMammaV3.Configurations;
using BigMammaV3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BigMammaV3.Services;

public class ConfigurationsService
{
    private readonly IJsonService _jsonService;
    private readonly string _filepath;

    public ConfigurationsService(IJsonService jsonService, string filepath)
    {
        _jsonService = jsonService;
        _filepath = filepath;
    }

    public AppSettings Load()
    {
        return _jsonService.Read<AppSettings>(_filepath) ?? throw new InvalidOperationException("Could not load application settings");
    }
    public void Save(AppSettings settings)
    {
        _jsonService.Write<AppSettings>(_filepath, settings);
    }
}
