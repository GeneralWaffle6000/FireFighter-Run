using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool instance;

    private List<GameObject> pooledRockObstacles = new List<GameObject>();
    //private List<GameObject> pooledEnemies = new List<GameObject>();
    private List<GameObject> pooledBananaObstacles = new List<GameObject>();
    private List<GameObject> pooledScoreCollectibles = new List<GameObject>();

    public int amountToPool = 20;
    public int collectibleAmountToPool = 50;

    [SerializeField] private GameObject obstaclePrefab;
    //[SerializeField] private GameObject enemyPrefab;
    [SerializeField] private GameObject bananaObstaclePrefab;
    [SerializeField] private GameObject scoreCollectiblePrefab;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
            return;
        }
        Destroy(this.gameObject);
    }
    void Start()
    {
        pooledRockObstacles = new List<GameObject>();
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject obj = Instantiate(obstaclePrefab);
            obstaclePrefab.SetActive(false);
            pooledRockObstacles.Add(obj);
        }

        //pooledEnemies = new List<GameObject>();
        //for (int i = 0; i < amountToPool; i++)
        //{
        //    GameObject obj = Instantiate(enemyPrefab);
        //    enemyPrefab.SetActive(false);
        //    pooledEnemies.Add(obj);
        //}

        pooledBananaObstacles = new List<GameObject>();
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject obj = Instantiate(bananaObstaclePrefab);
            bananaObstaclePrefab.SetActive(false);
            pooledBananaObstacles.Add(obj);
        }

        pooledScoreCollectibles = new List<GameObject>();
        for (int i = 0; i < collectibleAmountToPool; i++)
        {
            GameObject obj = Instantiate(scoreCollectiblePrefab);
            scoreCollectiblePrefab.SetActive(false);
            pooledScoreCollectibles.Add(obj);
        }
    }

    public GameObject GetPooledRockObstacle()
    {
        foreach (GameObject rockObstacle in pooledRockObstacles)
        {
            if(!rockObstacle.activeInHierarchy)
            {
                return rockObstacle;
            }
        }
        return null;
    }

    //public GameObject GetPooledEnemies()
    //{
    //    foreach (GameObject enemy in pooledEnemies)
    //    {
    //        if (!enemy.activeInHierarchy)
    //        {
    //            return enemy;
    //        }
    //    }
    //    return null;
    //}

    public GameObject GetPooledBananaObstacles()
    {
        foreach (GameObject bananaObstacle in pooledBananaObstacles)
        {
            if (!bananaObstacle.activeInHierarchy)
            {
                return bananaObstacle;
            }
        }
        return null;
    }

    public GameObject GetPooledScoreCollectibles()
    {
        foreach (GameObject scoreCollectible in pooledScoreCollectibles)
        {
            if (!scoreCollectible.activeInHierarchy)
            {
                return scoreCollectible;
            }
        }
        return null;
    }
    
}
