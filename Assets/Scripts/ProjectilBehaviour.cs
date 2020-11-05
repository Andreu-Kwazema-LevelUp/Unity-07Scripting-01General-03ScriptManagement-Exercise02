using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ProjectilBehaviour : MonoBehaviour
{
    #region Private Fields
     
    [SerializeField]
    private ProjectilData _projectilData;

    private Rigidbody _rb;

    #endregion


    #region Unity Lifecycle

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    #endregion


    #region Public Methods

    public void Translate(Vector3 mousePosition)
    {
        var projectileDelta = mousePosition - transform.position;
        _rb.AddForce(projectileDelta.normalized * _projectilData.Force);

        StartCoroutine(LifeTime(_projectilData.LifeTime));
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
