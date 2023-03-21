using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogo : MonoBehaviour
{
    public GameObject barreira;
    public GameObject personagemAtual;
    public GameObject personagemAtualNome;
    public GameObject somAtual;
    public GameObject proxPersonagem;
    public GameObject proxPersonagemNome;
    public GameObject proxSom;
    public GameObject proxDialogo;
    private GameObject caixaDialogo;
    private GameObject Extra1Sim;
    private GameObject Extra2Sim;
    private GameObject Extra1Nao;
    private GameObject Extra2Nao;
    public bool fimDialogo;

    // Start is called before the first frame update

    void Awake()
    {
        caixaDialogo = GameObject.Find("DialogoMain/CaixaDialogo");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)){
            if (fimDialogo)
            {
                caixaDialogo.SetActive(false);
                Object.Destroy(barreira);
            }
            else 
            {
                proxDialogo.SetActive(true);
                proxPersonagem.SetActive(true);
                proxPersonagemNome.SetActive(true);
                proxSom.SetActive(true);
                Extra1Sim.SetActive(true);
                Extra2Sim.SetActive(true);
                Extra1Nao.SetActive(false);
                Extra2Nao.SetActive(false);
            }
            personagemAtual.SetActive(false);
            personagemAtualNome.SetActive(false);
            somAtual.SetActive(false);
            Object.Destroy(this.gameObject);
        }
    }
}
