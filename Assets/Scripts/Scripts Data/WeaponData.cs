using UnityEngine;

[CreateAssetMenu(fileName = "WeaponData", menuName = "Scriptable Objects/Weapon Data")]
public class WeaponData : ScriptableObject
{
    #region Private Fields

    [SerializeField]
    private GameObject projectil;

    [SerializeField]
    private int maxBullets;

    [SerializeField]
    private Vector3 position;

    #endregion


    #region Public Attributes

    public GameObject Projectil { get => projectil; set => projectil = value; }
    
    public int MaxBullets { get => maxBullets; set => maxBullets = value; }

    public Vector3 Position { get => position; set => position = value; }

    #endregion
}
