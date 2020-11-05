using UnityEngine;

[CreateAssetMenu(fileName = "ProjectilData", menuName = "Scriptable Objects/Projectil Data")]
public class ProjectilData : ScriptableObject
{
    #region Private Fields
    
    [SerializeField]
    private float _lifeTime;
    
    [SerializeField]
    private float _force;

    [SerializeField]
    private Rigidbody _rb;

    #endregion


    #region Public Attributes

    public float LifeTime { get => _lifeTime; }
    
    public float Force { get => _force; }

    public Rigidbody Rb { get => _rb; }

    #endregion
}
