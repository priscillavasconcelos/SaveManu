using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HomeScreen : MonoBehaviour
{
    public GameObject CanvasConfig;
    public GameObject CanvasDicas;
    public GameObject CanvasTuto;
    public List<GameObject> tutorials = new List<GameObject>();
    int tutorialValue = 0;

    public Slider SliderSound;
    public Sprite audioOn, audioOff;
    public Image audioIcon;

    #region Variaveis de Texto
    public Text tutoDesc1, tutoDesc2, tutoDesc3, tutoDesc4;
    public Text prog, soundDesgin;
    public Text accuse, pass;
    public Text start, credits1, credits2, credits3, language, exit;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        //GameManager.manager.toggleAudio = true;
        //PlayerPrefs.GetInt("Volume", 0);
        if (PlayerPrefs.HasKey("Volume"))
        {
            Texts.toggleAudio = PlayerPrefs.GetInt("Volume", 0) == 0 ? false : true;
        }
        
        audioIcon.sprite = Texts.toggleAudio ? audioOn : audioOff;
        AudioSource[] audios = GameObject.FindObjectsOfType<AudioSource>();
        foreach (AudioSource audio in audios)
        {
            audio.gameObject.SetActive(Texts.toggleAudio);
        }

        Texts.language = (Texts.Language)PlayerPrefs.GetInt("Language", 0);
        SetLanguage();
        //SliderSound.value = PlayerPrefs.GetFloat("Volume");

    }
    public void SetLanguage()
    {
        tutoDesc1.text = Texts.TUTORIAL1;
        tutoDesc2.text = Texts.TUTORIAL2;
        tutoDesc3.text = Texts.TUTORIAL3;
        tutoDesc4.text = Texts.TUTORIAL4;
        prog.text = Texts.DEVELOPMENT;
        soundDesgin.text = Texts.SOUNDDESIGN;
        accuse.text = Texts.ACCUSE;
        pass.text = Texts.NEXT;
        start.text = Texts.PLAY;
        credits1.text = Texts.CREDITS;
        credits2.text = Texts.CREDITS;
        credits3.text = Texts.CREDITS;
        language.text = Texts.LANGUAGE;
        exit.text = Texts.EXIT;
    }
    public void Iniciar()
    {
        SceneManager.LoadScene("Game");
    }

    public void MostraConifg()
    {
        if (CanvasConfig.activeSelf)
        {
            //teste.text = "sumiu";
            CanvasConfig.SetActive(false);
            CanvasDicas.SetActive(false);
            CanvasTuto.SetActive(false);
        }
        else
        {
            //teste.text = "apareceu";
            CanvasConfig.SetActive(true);
            CanvasDicas.SetActive(false);
            CanvasTuto.SetActive(false);
        }

    }

    public void MostraDicas()
    {
        if (CanvasDicas.activeSelf)
        {
            //teste.text = "sumiu";
            CanvasDicas.SetActive(false);
            CanvasConfig.SetActive(false);
            CanvasTuto.SetActive(false);
        }
        else
        {
            //teste.text = "apareceu";
            CanvasDicas.SetActive(true);
            CanvasConfig.SetActive(false);
            CanvasTuto.SetActive(false);
        }

    }

    public void MostraTuto()
    {
        if (CanvasTuto.activeSelf)
        {
            //teste.text = "sumiu";
            CanvasTuto.SetActive(false);
            CanvasDicas.SetActive(false);
            CanvasConfig.SetActive(false);
        }
        else
        {
            tutorialValue = 0;
            //teste.text = "apareceu";
            CanvasTuto.SetActive(true);
            CanvasDicas.SetActive(false);
            CanvasConfig.SetActive(false);
        }

    }
    public void ChangeLanguage(int language)
    {
        PlayerPrefs.SetInt("Language", language);
        Texts.language = (Texts.Language)language;
        PlayerPrefs.Save();
        SetLanguage();
    }
    public void ToggleAudio()
    {
        Texts.toggleAudio = !Texts.toggleAudio;
        PlayerPrefs.SetInt("Volume", Texts.toggleAudio ? 1 : 0);
        audioIcon.sprite = Texts.toggleAudio ? audioOn : audioOff;
        AudioSource[] audios = GameObject.FindObjectsOfType<AudioSource>();
        foreach (AudioSource audio in audios)
        {
            audio.gameObject.SetActive(Texts.toggleAudio);
        }
        PlayerPrefs.Save();
    }
    public void MudaVolume()
    {
        PlayerPrefs.SetFloat("Volume", SliderSound.value);      
    }
    public void TutorialForward()
    {
        tutorialValue++;
        for (int i = 0; i < tutorials.Count; i++)
        {
            if (i == tutorialValue)
            {
                tutorials[i].SetActive(true);
            }
            else
            {
                tutorials[i].SetActive(false);
            }
        }
    }
    public void TutorialBackward()
    {
        tutorialValue--;
        for (int i = 0; i < tutorials.Count; i++)
        {
            if (i == tutorialValue)
            {
                tutorials[i].SetActive(true);
            }
            else
            {
                tutorials[i].SetActive(false);
            }
        }
    }
    public void Sair()
    {
        Application.Quit();
    }


}
