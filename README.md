# BaikalNetHub

## CodeFirst DomainModel

The package implements the Entity Framework Code First pattern at the level of database entity relationship abstraction and includes interfaces for domain models. The project contains interfaces designed to implement the navigation properties of entities.
These abstract concepts are designed to be used within the context of an application built using the Onion architecture and the Entity Framework, but they can also be applied to other architectures and frameworks.



#### IEntityBase

... is base interface for database-mapped classes that doesn't have any properties or methods, it just tells you that a class is mapped to a database. IEntity<TEntityId>, which is a generic interface, inherits from this base interface, so any class that uses IEntity<TEntityId> will also use interface IEntityBase. That means you don't need to check every possible implementations of IEntity<TEntityId> when you're selecting a class, you can just check if it's an implementation of IEntityBase instead.

#### IEntity<TEntityId>

... is a generic interface for database-mapped classes that inherits from the EntityBase interface. So, any class that implements IEntity also implements EntityBase at the same time. That means you don't need to check for all possible implementations when selecting a class - you can just check if it's an IEntityBase implementation. 

###### *Type parameters*

The TEntityId parameter specifies the type of the entity identifier, and its value is constrained to a structure type.

###### *Methods & properties*

Property Id gets or sets the entity Id.

#### IEntity

... inherits the IEntity<TEntityID> interface where type parameter is integer by default.

#### IParent<TParentId, TParent>

```
<member name="T:BaikalNetHub.CodeFirst.Domain.Model.IParent`2">
    <summary>The interface implements the navigation property of the child entity.</summary>
    <typeparam name="TParentId">The type of the parent identifier.</typeparam>
    <typeparam name="TParent">The type of the parent.</typeparam>
</member>
<member name="P:BaikalNetHub.CodeFirst.Domain.Model.IParent`2.ParentId">
    <summary>Gets or sets the parent identifier.</summary>
    <value>The parent identifier.</value>
</member>
<member name="P:BaikalNetHub.CodeFirst.Domain.Model.IParent`2.Parent">
    <summary>Gets or sets the parent.</summary>
    <value>The parent as entity.</value>
</member>
<member name="T:BaikalNetHub.CodeFirst.Domain.Model.IParent`1">
    <summary>The interface implements the navigation property of the child entity when the type Id is int.</summary>
    <typeparam name="TParent">The type of the parent.</typeparam>
</member>
```





#### public interface IChild<TChild>

This interface provides only one property, called Children. This property is specific to entities that is a parent. Child objects are returned or assigned as an IEnumerable list of entities.

1. The interface provides properties that indicate the creation date of an entity and the identity of its creator.  
   
   Type of Id
   
   Type of User entity
   
   Gets or sets the creation date.
   
   The creation date.
   
   TODO Edit XML Comment Template for CreationDate
   
   Gets or sets the created by user identifier.
   
   The created by user identifier.
   
   TODO Edit XML Comment Template for CreatedByUserId
   
   Gets or sets the created by user.
   
   The created by user.
   
   TODO Edit XML Comment Template for CreatedByUser

2. The interface provides properties that indicate the date of creation of an object and the identity of its creator. The User Id is an int by default.  
   
   The type of the user.
   
   TODO Edit XML Comment Template for ICreatedBy`1
   
   The interface provides information about the date of the last modification of the object, as well as the identification data of the user who made the change.  
   
   The type of the user identifier.
   
   The type of the user.
   
   TODO Edit XML Comment Template for IModifiedBy`2
   
   The date of last modification
   
   TODO Edit XML Comment Template for ModificationDate
   
   Gets or sets the modified by user identifier.
   
   The modified by user identifier.
   
   TODO Edit XML Comment Template for ModifiedByUserId
   
   Gets or sets the modified by user.
   
   The modified by user.
   
   TODO Edit XML Comment Template for ModifiedByUser

3. 

4. The interface provides information about the date of the last modification of the object, as well as the identification data of the user who made the change. User Id is int by default  
   
   Type of User entity.
   
   TODO Edit XML Comment Template for IModifiedBy`1
   
   Base interface for database-mapped classes.
   
   This base interface doesn't have any properties or methods, it just tells you that a class is mapped to a database.
   
   IEntity<TEntityId>, which is a generic interface, inherits from this base interface, so any class that
   
   uses IEntity<TEntityId> will also use interface IEntityBase. That means you don't need to check every possible implementations
   
   of IEntity<TEntityId> when you're selecting a class, you can just check if it's an implementation of IEntityBase instead.
   
   TODO Edit XML Comment Template for IEntity
   
   Generic interface for database-mapped classes.
   
   The type of the entity identifier.
   
   IEntity<TEntityId> is a generic interface that's inherited from the EntityBase interface.
   
   So, any class that implements IEntity also implements EntityBase at the same time.
   
   That means you don't need to check for all possible implementations when selecting a class - you can
   
   just see if it's an IEntityBase implementation.
   
   TODO Edit XML Comment Template for IEntity`1
   
   Gets or sets the Entity Id. The default interface for database-mapped classes when the Id type is int.
   
   IEntity is a special case of generic interface IEntity<TEntityId> a that's inherited from the EntityBase interface.
   
   So, any class that implements IEntity also implements EntityBase at the same time.
   
   That means you don't need to check for all possible implementations when selecting a class - you can
   
   just see if it's an IEntityBase implementation.
   
   TODO Edit XML Comment Template for IEntity`1
   
   The interface implements the navigation property of the child entity.
   
   The type of the parent identifier.
   
   The type of the parent.
   
   TODO Edit XML Comment Template for IParent`2
   
   Gets or sets the parent identifier.
   
   The parent identifier.
   
   TODO Edit XML Comment Template for ParentId
   
   Gets or sets the parent.
   
   The parent as entity.
   
   TODO Edit XML Comment Template for Parent
   
   The interface implements the navigation property of the child entity when the type Id is int.
   
   The type of the parent.
   
   TODO Edit XML Comment Template for IParent`1