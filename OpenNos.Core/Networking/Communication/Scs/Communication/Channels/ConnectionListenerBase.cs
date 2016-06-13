﻿/*
 * This file is part of the OpenNos Emulator Project. See AUTHORS file for Copyright information
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 */

using System;

namespace OpenNos.Core.Networking.Communication.Scs.Communication.Channels
{
    /// <summary>
    /// This class provides base functionality for communication listener Classs.
    /// </summary>
    public abstract class ConnectionListenerBase : IConnectionListener
    {
        #region Public Events

        /// <summary>
        /// This event is raised when a new communication channel is connected.
        /// </summary>
        public event EventHandler<CommunicationChannelEventArgs> CommunicationChannelConnected;

        #endregion

        #region Public Methods

        /// <summary>
        /// Starts listening incoming connections.
        /// </summary>
        public abstract void Start();

        /// <summary>
        /// Stops listening incoming connections.
        /// </summary>
        public abstract void Stop();

        #endregion

        #region Protected Methods

        /// <summary>
        /// Raises CommunicationChannelConnected event.
        /// </summary>
        /// <param name="client"></param>
        protected virtual void OnCommunicationChannelConnected(ICommunicationChannel client)
        {
            var handler = CommunicationChannelConnected;
            if (handler != null)
            {
                handler(this, new CommunicationChannelEventArgs(client));
            }
        }

        #endregion
    }
}