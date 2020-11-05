using UnityEngine;

[CreateAssetMenu(fileName = "CharacterData", menuName = "Scriptable Objects/Character Data")]
public class CharacterData : ScriptableObject
{
    #region Private Fields

    [SerializeField]
    private int _speed;

    #endregion


    #region Public Attributes

    public int Speed { get => _speed; set => _speed = value; }

    #endregion
}
