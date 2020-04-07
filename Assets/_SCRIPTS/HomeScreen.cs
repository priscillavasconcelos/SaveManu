using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HomeScreen : MonoBehaviour
{
    //public Text teste;
    public GameObject CanvasConfig;
    public GameObject CanvasDicas;
    public GameObject CanvasTuto;
    public GameObject CanvasPri;
    public GameObject CanvasSeg;
    public GameObject CanvasTer;
    public GameObject CanvasQua;
    public Slider SliderSound;
    // Start is called before the first frame update
    void Start()
    {

        if (!PlayerPrefs.HasKey("Volume"))
        {
            PlayerPrefs.SetFloat("Volume", 1.0f);
        }

        if (!PlayerPrefs.HasKey("Lang"))
        {
            PlayerPrefs.SetString("Lang", "Port");
        }

        //SliderSound.value = PlayerPrefs.GetFloat("Volume");

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
            //teste.text = "apareceu";
            CanvasTuto.SetActive(true);
            CanvasDicas.SetActive(false);
            CanvasConfig.SetActive(false);
        }

    }

    public void MudaIdiomaIng()
    {
        PlayerPrefs.SetString("Lang", "Eng");
    }

    public void MudaIdiomaPor()
    {
        PlayerPrefs.SetString("Lang", "Port");
    }

    public void MudaVolume()
    {
        PlayerPrefs.SetFloat("Volume", SliderSound.value);      
    }


    public void Tutorial( string tela)
    {
        if (tela == "pri")
        {
            CanvasPri.SetActive(true);
            CanvasSeg.SetActive(false);
            CanvasTer.SetActive(false);
            CanvasQua.SetActive(false);
        }
        if (tela == "seg")
        {
            CanvasPri.SetActive(false);
            CanvasSeg.SetActive(true);
            CanvasTer.SetActive(false);
            CanvasQua.SetActive(false);
        }
        if (tela == "ter")
        {
            CanvasPri.SetActive(false);
            CanvasSeg.SetActive(false);
            CanvasTer.SetActive(true);
            CanvasQua.SetActive(false);
        }
        if (tela == "qua")
        {
            CanvasPri.SetActive(false);
            CanvasSeg.SetActive(false);
            CanvasTer.SetActive(false);
            CanvasQua.SetActive(true);
        }
        

    }

}
