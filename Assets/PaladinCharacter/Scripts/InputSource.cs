// file:	Assets\PaladinCharacter\Scripts\InputSource.cs
//
// summary:	Implements the input source class

using UnityEngine;

namespace PaladinCharacter
{
    /// <summary>   Interface for input source. </summary>
    public interface IInputSource
    {
    }

    /// <summary>   An input source. </summary>
    public abstract class InputSource : MonoBehaviour, IInputSource
    {
    }
}