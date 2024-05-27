using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _Instance = null;
    public static GameManager Instance => _Instance;
    private string path;

    public string playerName;
    public int bestScore;

    private class SaveData
    {
        public int bestScore;
        public string playerName;
    }

    private void Awake()
    {
        path = Application.persistentDataPath + "/savefile.json";
        if (_Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            _Instance = this;
        }
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveHighScore()
    {
        SaveData data = new SaveData();
        data.bestScore = bestScore;
        data.playerName = playerName;
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(path, json);
    }

    public void LoadHighScore()
    {
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            bestScore = data.bestScore;
            playerName = data.playerName;
        }
        else
        {
            bestScore = 0;
        }
    }
}
