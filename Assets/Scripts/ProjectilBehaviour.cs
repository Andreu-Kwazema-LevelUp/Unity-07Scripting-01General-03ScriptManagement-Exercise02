using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ProjectilBehaviour : MonoBehaviour
{
    #region Private Fields
     
    [SerializeField]
    private ProjectilData _projectil;

    private Rigidbody _myRigibody;

    #endregion


    #region Unity Lifecycle

    private void Awake()
    {
        _myRigibody = GetComponent<Rigidbody>();
    }

    #endregion


    #region Public Methods

    public void Move(Vector3 mousePosition)
    {
        var projectileDelta = mousePosition - transform.position;
        _myRigibody.AddForce(projectileDelta.normalized * _projectil.Force);

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
