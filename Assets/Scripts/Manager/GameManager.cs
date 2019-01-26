using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Manager
{
    public class GameManager : MonoBehaviour
    {

        [Header("Manager")]
        public static GameManager Instance;
        public AssetsManager AssetsManager;

        [Header("Score")]
        public int Platforms;

        [Header("Game")]
        public float Duration;

        private void Awake()
        {
            if (Instance == null)
                Instance = this;

            else if (Instance != this)
                Destroy(gameObject);

            DontDestroyOnLoad(gameObject);
        }

        private void OnEnable()
        {
            AssetsManager = GetComponent<AssetsManager>();
        }

        private void Start()
        {
            //StartCoroutine(Test());
        }

        private void Update()
        {
        }

        private IEnumerator Test()
        {
            yield return new WaitForSeconds(1);
        }

    }
}
