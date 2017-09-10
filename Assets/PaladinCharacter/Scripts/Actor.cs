// file:	Assets\PaladinCharacter\Scripts\Actor.cs
//
// summary:	Implements the actor class

using UnityEngine;

namespace PaladinCharacter
{
    /// <summary>   Interface for actor. </summary>
    public interface IActor
    {
    }

    /// <summary>   An actor. </summary>
    public abstract class Actor : MonoBehaviour, IActor
    {
    }
}