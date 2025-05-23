﻿using InventorySystem.Items.Pickups;
using LabApi.Events.Arguments.Interfaces;
using LabApi.Features.Wrappers;
using System;

namespace LabApi.Events.Arguments.PlayerEvents;

/// <summary>
/// Represents the arguments for the <see cref="Handlers.PlayerEvents.DroppedItem"/> event.
/// </summary>
public class PlayerDroppedItemEventArgs : EventArgs, IPlayerEvent, IPickupEvent
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PlayerDroppedItemEventArgs"/> class.
    /// </summary>
    /// <param name="player">The player who dropped the item.</param>
    /// <param name="pickup">The item pickup.</param>
    public PlayerDroppedItemEventArgs(ReferenceHub player, ItemPickupBase pickup)
    {
        Player = Player.Get(player);
        Pickup = Pickup.Get(pickup);
    }

    /// <summary>
    /// Gets the player who dropped the item.
    /// </summary>
    public Player Player { get; }

    /// <summary>
    /// Gets the item pickup.
    /// </summary>
    public Pickup Pickup { get; }
}