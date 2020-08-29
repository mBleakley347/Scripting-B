using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SCR_GameManager : MonoBehaviour
{
    public static SCR_GameManager instance;

    public delegate void levelUp();
    public static levelUp LevelUp;

    public delegate void intChange(int change);
    public static intChange ScoreChange;
    public static intChange HealthChange;
    public static intChange HealthMaxChange;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        AudioManager();
    }


    #region SceneManager
    public void ChangeScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void EndScene()
    {
        SceneManager.LoadScene("SCE_End");
    }

    public void Exit()
    {
        Application.Quit();
    }
    #endregion

    #region AudioManager

    public AudioSource audio;


    public int currentTrack;

    public void AudioManager()
    {
        if (!audio.isPlaying)
        {
            ChangeAudio(SCR_MusicTrackHolder.instance.music[currentTrack]);
            currentTrack++;
            if (currentTrack >= (SCR_MusicTrackHolder.instance.music.Length)){
                currentTrack = 0;
            }
        }
    }
    public void ChangeAudio(AudioClip clip)
    {
        audio.clip = clip;
        audio.Play();
    }
    #endregion
}
