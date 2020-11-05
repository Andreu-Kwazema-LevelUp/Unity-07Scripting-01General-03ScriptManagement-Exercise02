using UnityEngine;

[CreateAssetMenu(fileName = "ProjectilData", menuName = "Scriptable Objects/Projectil Data")]
public class ProjectilData : ScriptableObject
{
    #region Private Fields
    
    [SerializeField]
    private float _lifeTime;
    
    [SerializeField]
    private float _force;
    
    #endregion


    #region Public Attributes

    public float LifeTime { get => _lifeTime; set => _lifeTime = value; }
    
    public float Force { get => _force; set => _force = value; }
    
    #endregion
}
