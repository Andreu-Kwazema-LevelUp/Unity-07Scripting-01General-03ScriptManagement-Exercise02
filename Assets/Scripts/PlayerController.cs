using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Private Fields

    [SerializeField]
    private PlayerBehaviour _playerBehaviour;

    #endregion


    #region Unity Lifecycle

    private void Awake()
    {
        if (_playerBehaviour == null)
            _playerBehaviour = GetComponent<PlayerBehaviour>();
    }

    private void Update()
    {
        InputTranslate();
    }

    #endregion


    #region Private Methods

    private void InputTranslate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //usar un evento?
        if (horizontal != 0 || vertical != 0)
            _playerBehaviour?.Translate(horizontal, vertical);
    }

    #endregion
}
