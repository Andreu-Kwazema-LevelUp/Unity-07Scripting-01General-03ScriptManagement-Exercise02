using UnityEngine;

public class WeaponBehaviour : MonoBehaviour
{
    #region Private Fields

    [SerializeField]
    private WeaponData _weapon;

    #endregion


    #region Public Methods

    public void Fire()
    {
        var projectile = Instantiate(_weapon.Projectil, transform.position, Quaternion.identity);

        projectile.GetComponent<ProjectilBehaviour>().Move(GetMousePosition());
    }

    #endregion


    #region Private Methods

    private Vector3 GetMousePosition()
    {
        var mouseInput = Input.mousePosition;
        mouseInput.z = 10;

        var mousePosition = Camera.main.ScreenToWorldPoint(mouseInput);
        mousePosition.z = 0;

        return mousePosition;
    }

    #endregion
}
