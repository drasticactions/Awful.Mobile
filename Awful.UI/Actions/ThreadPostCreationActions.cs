﻿// <copyright file="ThreadPostActions.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Awful.Core.Entities.PostIcons;
using Awful.Core.Entities.Smilies;
using Awful.Core.Entities.Threads;
using Awful.Core.Managers;
using Awful.Core.Managers.JSON;
using Awful.Core.Utilities;
using Awful.Database.Context;
using Awful.Database.Entities;
using Awful.Webview;
using Awful.Webview.Entities.Themes;

namespace Awful.UI.Actions
{
    /// <summary>
    /// Thread Creation Post Actions.
    /// </summary>
    public class ThreadPostCreationActions
    {
        private SmileManager smileManager;
        private PostIconManager postIconManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadPostCreationActions"/> class.
        /// </summary>
        /// <param name="client">AwfulClient.</param>
        public ThreadPostCreationActions(AwfulClient client)
        {
            this.smileManager = new SmileManager(client);
            this.postIconManager = new PostIconManager(client);
        }

        /// <summary>
        /// Get Smile List.
        /// </summary>
        /// <param name="token">Cancelation Token.</param>
        /// <returns>List of Smile Category.</returns>
        public async Task<SmileCategoryList> GetSmileListAsync(CancellationToken token = default)
        {
            return await this.smileManager.GetSmileListAsync(token).ConfigureAwait(false);
        }

        /// <summary>
        /// Get Forum Post Icons for given Forum.
        /// </summary>
        /// <param name="forumId">Forum ID.</param>
        /// <param name="token">Cancelation Token.</param>
        /// <returns>List of Forum Post Icons.</returns>
        public async Task<PostIconList> GetForumPostIconsAsync(int forumId, CancellationToken token = default)
        {
            return await this.postIconManager.GetForumPostIconsAsync(forumId, token).ConfigureAwait(false);
        }

        /// <summary>
        /// Get Private Message Post Icons.
        /// </summary>
        /// <param name="token">Cancelation Token.</param>
        /// <returns>List of Private Message Post Icons.</returns>
        public async Task<PostIconList> GetPrivateMessagePostIconsAsync(CancellationToken token = default)
        {
            return await this.postIconManager.GetPrivateMessagePostIconsAsync(token).ConfigureAwait(false);
        }
    }
}
