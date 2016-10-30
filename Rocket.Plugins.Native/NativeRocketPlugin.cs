﻿using Rocket.API;
using Rocket.API.Plugins;
using System.Reflection;

namespace Rocket.Plugins.Native
{
    public class NativeRocketPlugin : RocketPluginBase
    {
        public NativeRocketPlugin() : base(NativeRocketPluginManager.Instance)
        {

        }
    }

    public class NativeRocketPlugin<RocketPluginConfiguration> : RocketPluginBase<RocketPluginConfiguration> where RocketPluginConfiguration : class, IRocketPluginConfiguration
    {
        public NativeRocketPlugin() : base(NativeRocketPluginManager.Instance)
        {

        }
    }
}