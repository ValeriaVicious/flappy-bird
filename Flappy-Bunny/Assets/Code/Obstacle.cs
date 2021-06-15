using UnityEngine;


namespace BunnyFlappy
{
    public class Obstacle : MonoBehaviour
    {
        #region Fields

        [SerializeField] private float _speed;
        [SerializeField] private float _switchTime = 2.0f;
        private Rigidbody2D _rigidbody;

        #endregion


        #region UnityMethods

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
            _rigidbody.velocity = Vector2.up * _speed;
            InvokeRepeating(nameof(Switch), 0.0f, _switchTime);
        }

        #endregion


        #region Methods

        private void Switch()
        {
            _rigidbody.velocity *= -1.0f;
        }

        #endregion
    }
}