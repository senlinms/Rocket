﻿using Rocket.API.Commands;
using Rocket.API.Configuration;
using Rocket.API.DependencyInjection;
using Rocket.API.Eventing;

namespace Rocket.API
{
    /// <summary>
    ///     A game specific implemention of RocketMod. Implementations are responsible for providing game specific features.
    /// </summary>
    public interface IHost : IEventEmitter, IConfigurationContext, IService
    {
        /// <summary>
        ///     The game instance ID.
        /// </summary>
        string InstanceId { get; }

        /// <summary>
        ///     Gets the console. <br />
        ///     <b>Might return null.</b>
        /// </summary>
        IConsole Console { get; }

        /// <summary>
        ///     Initializes the implementation.
        /// </summary>
        /// <param name="runtime">The RocketMod runtime.</param>
        void Init(IRuntime runtime);

        /// <summary>
        ///     Shuts the implementation down.
        /// </summary>
        void Shutdown();

        /// <summary>
        ///     Reloads the implementation.
        /// </summary>
        void Reload();
    }
}