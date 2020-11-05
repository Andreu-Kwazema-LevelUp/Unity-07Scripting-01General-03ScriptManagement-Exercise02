using UnityEngine;

public class WeaponController : MonoBehaviour
{
    #region Private Fields

    [SerializeField]
    private WeaponBehaviour _weaponBehaviour;

    #endregion


    #region Unity Lifecycle

    private void Update()
    {
        InputFire();
    }

    #endregion


    #region Private Methods

    private void InputFire()
    {
        if (Input.GetButtonDown("Fire1"))
            _weaponBehaviour?.Fire();
    }

    #endregion
}
