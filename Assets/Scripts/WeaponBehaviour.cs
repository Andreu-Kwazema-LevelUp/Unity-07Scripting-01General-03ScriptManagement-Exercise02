using UnityEngine;

public class WeaponBehaviour : MonoBehaviour
{
    #region Private Fields

    [SerializeField]
    private WeaponData _weaponData;

    #endregion


    #region Public Methods

    public void Fire()
    {
        var projectile = Instantiate(_weaponData.Projectil, transform.position, Quaternion.identity);

        var mouseInput = Input.mousePosition;
        mouseInput.z = 10;

        var mousePosition = Camera.main.ScreenToWorldPoint(mouseInput);
        mousePosition.z = 0;

        projectile.GetComponent<ProjectilBehaviour>().Translate(mousePosition);
    }

    #endregion
}
