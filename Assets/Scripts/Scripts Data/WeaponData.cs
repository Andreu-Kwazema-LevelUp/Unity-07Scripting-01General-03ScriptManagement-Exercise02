using UnityEngine;

[CreateAssetMenu(fileName = "WeaponData", menuName = "Scriptable Objects/Weapon Data")]
public class WeaponData : ScriptableObject
{
    #region Private Fields

    [SerializeField]
    private GameObject projectil;

    [SerializeField]
    private int maxBullets;

    private Vector3 position;

    #endregion


    #region Public Attributes

    public GameObject Projectil { get => projectil; }
    
    public int MaxBullets { get => maxBullets; }

    public Vector3 Position { get => position; }

    #endregion
}
