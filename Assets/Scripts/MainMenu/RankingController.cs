using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RankingController : MonoBehaviour{
    public TMP_Text Posicao;
    public TMP_Text Nome;
    public TMP_Text Pontuacao;

    private int posicao;
    private string nome;
    private int pontuacao;

    void Start()
    {
        posicao = 0; 
        nome = "Player"; 
        pontuacao = 0; 

        AtualizarRank();
    }

    public void AtualizarRank()
    {
        Posicao.text = posicao.ToString();
        Nome.text = nome;
        Pontuacao.text = pontuacao.ToString();
    }

    public void ConfigurarRank(int novaPosicao, string novoNome, int novaPontuacao)
    {
        posicao = novaPosicao;
        nome = novoNome;
        pontuacao = novaPontuacao;

        AtualizarRank();
    }
}
