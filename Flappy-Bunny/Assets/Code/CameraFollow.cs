using UnityEngine;


namespace BunnyFlappy
{
    internal sealed class CameraFollow : MonoBehaviour
    {
        #region Fields

        [SerializeField] private Transform _targetObject;

        #endregion


        #region UnityMethods

        private void LateUpdate()
        {
            FollowTheTarget();
        }

        #endregion


        #region Methods

        private void FollowTheTarget()
        {
            if (_targetObject == null)
            {
                return;
            }
            else
            {
                transform.position = new Vector3(_targetObject.position.x,
                    transform.position.y, transform.position.z);
            }
        }

        #endregion
    }
}
