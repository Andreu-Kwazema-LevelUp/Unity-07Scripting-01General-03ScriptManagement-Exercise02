﻿using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    #region Private Fields

    [SerializeField]
    private CharacterData _character;

    #endregion


    #region Public Methods

    public void Translate(float horizontal, float vertical)
    {
        Vector3 direction = new Vector3(horizontal, vertical, 0);
        transform.Translate(direction * _character.Speed * Time.deltaTime);
    }

    #endregion
}
