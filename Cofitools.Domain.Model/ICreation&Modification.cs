﻿
using System;

namespace Ovasoft.Cofitools.Domain.Model;

/// <summary>The interface provides properties that indicate the creation date of an entity and the identity of its creator.<br /></summary>
/// <typeparam name="TUserId">Type of Id</typeparam>
/// <typeparam name="TUser">Type of User entity</typeparam>
public interface ICreatedBy<TUserId, TUser>
  where TUserId : struct
  where TUser : class, IEntityBase
{
    /// <summary>Gets or sets the creation date.</summary>
    /// <value>The creation date.</value>
    /// <autogeneratedoc />
    /// TODO Edit XML Comment Template for CreationDate
    DateTime CreationDate { get; set; }
    /// <summary>Gets or sets the created by user identifier.</summary>
    /// <value>The created by user identifier.</value>
    /// <autogeneratedoc />
    /// TODO Edit XML Comment Template for CreatedByUserId
    TUserId CreatedByUserId { get; set; }
    /// <summary>Gets or sets the created by user.</summary>
    /// <value>The created by user.</value>
    /// <autogeneratedoc />
    /// TODO Edit XML Comment Template for CreatedByUser
    TUser CreatedByUser { get; set; }
}

/// <summary>The interface provides properties that indicate the date of creation of an object and the identity of its creator. The User Id is an int by default.<br /></summary>
/// <typeparam name="TUser">The type of the user.</typeparam>
/// <autogeneratedoc />
/// TODO Edit XML Comment Template for ICreatedBy`1
public interface ICreatedBy<TUser>: ICreatedBy<int, TUser> where TUser : class, IEntityBase { }

/// <summary>The interface provides information about the date of the last modification of the object, as well as the identification data of the user who made the change.<br /></summary>
/// <typeparam name="TUserId">The type of the user identifier.</typeparam>
/// <typeparam name="TUser">The type of the user.</typeparam>
/// <autogeneratedoc />
/// TODO Edit XML Comment Template for IModifiedBy`2
public interface IModifiedBy<TUserId, TUser>
    where TUserId : struct
    where TUser : class, IEntityBase
{
    /// <summary>The date of last modification</summary>
    /// <autogeneratedoc />
    /// TODO Edit XML Comment Template for ModificationDate
    DateTime ModificationDate { get; set; }
    /// <summary>Gets or sets the modified by user identifier.</summary>
    /// <value>The modified by user identifier.</value>
    /// <autogeneratedoc />
    /// TODO Edit XML Comment Template for ModifiedByUserId
    TUserId ModifiedByUserId { get; set; }
    /// <summary>Gets or sets the modified by user.</summary>
    /// <value>The modified by user.</value>
    /// <autogeneratedoc />
    /// TODO Edit XML Comment Template for ModifiedByUser
    TUser ModifiedByUser { get; set; }
}

/// <summary>
/// The interface provides information about the date of the last modification of the object, as well as the identification data of the user who made the change. User Id is int by default<br /></summary>
/// <typeparam name="TUser">Type of User entity.</typeparam>
/// <autogeneratedoc />
/// TODO Edit XML Comment Template for IModifiedBy`1
public interface IModifiedBy<TUser>: IModifiedBy<int, TUser> where TUser : class, IEntityBase { }

