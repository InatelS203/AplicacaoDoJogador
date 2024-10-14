using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu_Manager : MonoBehaviour
{
    [SerializeField] private string nome;
    [SerializeField] private GameObject painel_menu;
    [SerializeField] private GameObject painel_historico;
    
    public void Historico(){
        painel_historico.SetActive(true);
        painel_menu.SetActive(false);
    }
    public void Jogar(){
        SceneManager.LoadScene(nome);
    }
    public void Rank(){
        painel_historico.SetActive(true);
        painel_menu.SetActive(false);
    }
    public void Sairhistorico(){
        painel_historico.SetActive(false);
        painel_menu.SetActive(true);
    }
    public void Sair(){
        Debug.Log("Sair do jogo");
        Application.Quit();

    }
}
