using UnityEngine;


namespace BunnyFlappy
{
    internal sealed class BackgroundScrolling : MonoBehaviour
    {
        #region Fields

        [SerializeField] private float _speedOfScroll;
        private readonly float _endPoint = 40.0f;
        private Vector3 _startPosition;

        #endregion


        #region UnityMethods

        private void Start()
        {
            _startPosition = transform.position;
        }

        private void Update()
        {
            BackgroundScroll();
        }

        #endregion


        #region Methods

        private void BackgroundScroll()
        {
            var scrollTheBackground = Mathf.Repeat(Time.time * _speedOfScroll, _endPoint);
            transform.position = _startPosition + new Vector3(-scrollTheBackground, 0.0f, 0.0f);
        }

        #endregion
    }

}
