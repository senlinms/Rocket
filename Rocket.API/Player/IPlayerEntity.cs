﻿using System.Numerics;
using Rocket.API.Entities;

namespace Rocket.API.Player
{
    /// <summary>
    ///     Represents a player entity.
    /// </summary>
    public interface IPlayerEntity: IEntity
    {
        /// <summary>
        ///     The player instance.
        /// </summary>
        IPlayer Player { get; }

        /// <summary>
        ///     Teleports the player to the given position.
        /// </summary>
        /// <param name="position">The position to teleport to.</param>
        /// <returns><b>True</b> if the teleport was succesful, otherwise; <b>false</b>.</returns>
        bool Teleport(Vector3 position);
    }
}