// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> Unresolved dependency. </summary>
    public partial class MoverUnresolvedDependency
    {
        /// <summary> Initializes a new instance of MoverUnresolvedDependency. </summary>
        internal MoverUnresolvedDependency()
        {
        }

        /// <summary> Initializes a new instance of MoverUnresolvedDependency. </summary>
        /// <param name="count"> Gets or sets the count. </param>
        /// <param name="id"> Gets or sets the arm id of the dependency. </param>
        internal MoverUnresolvedDependency(int? count, ResourceIdentifier id)
        {
            Count = count;
            Id = id;
        }

        /// <summary> Gets or sets the count. </summary>
        public int? Count { get; }
        /// <summary> Gets or sets the arm id of the dependency. </summary>
        public ResourceIdentifier Id { get; }
    }
}
