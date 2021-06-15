using UnityEngine;
using UnityEngine.SceneManagement;


namespace BunnyFlappy
{
    internal sealed class GoToTheBonusScene : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            SceneManager.LoadScene(Constants.NumberOfBonusScene);
        }
    }
}