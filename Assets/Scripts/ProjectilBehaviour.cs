using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ProjectilBehaviour : MonoBehaviour
{
    #region Private Fields
     
    [SerializeField]
    private ProjectilData _projectil;

    #endregion


    #region Public Methods

    public void Move(Vector3 mousePosition)
    {
        var projectileDelta = mousePosition - transform.position;
        _projectil.Rb.AddForce(projectileDelta.normalized * _projectil.Force);

        StartCoroutine(LifeTime(_projectil.LifeTime));
    }

    #endregion

    
    #region IEnumerators

    private IEnumerator LifeTime(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }

    #endregion
}
