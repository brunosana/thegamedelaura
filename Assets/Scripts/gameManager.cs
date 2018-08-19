using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour {
    public static bool mapHaveKey = false;
    public static AudioSource[] sounds = new AudioSource[5];
    public static bool pickedPaper = false;
    public static bool talkedsana = false;
    public static bool hasInMansion = false;
    public static int count = 0;
    private void Awake()
    {
        sounds = GetComponents<AudioSource>();
    }

    public static string TextSanaOut() {
        if (!pickedPaper)
        {
            return "Oi Laura, precisamos te falar algo, mas antes precisa saber de algumas coisas que tenho que falar." +
" Eu anotei em algum papel, mas não consigo encontrar...";
        }
        else {
            talkedsana = true;
            return "Oi <3 Que bom que já leu o que tínhamos para te dizer. Meu nome é bruno! Você precisa saber de algo!" +
             ". Fale com o Em... quer dizer, Ícaro, ele está à noroeste daqui :)"; }
    }

    public static string TextIcaroOut()
    {
        if (talkedsana)
        {
            if (!mapHaveKey)
            {
                return "Oi Laura :3 vc me encontrou logo aqui no mini cemitério né, que coisa de emo.. enfim," +
     " precisamos te falar algo e é muito importante, o problema é que eu perdi a chave da casa e não consigo achar. " +
     "Tinha que ser eu né, o desligado... bom, eu vim do leste, acho que deve tá por lá (DICA DE OURO EM...).";
            }
            else
            {
                if (count == 0) { count++; return "Boa Garota! Nunca duvidei! Agora nos vemos lá dentro. Bjo do emo :3"; }
                else { return "Tá esperando oq caraio?? vai logo porra."; }
            }
        }
        else { return "Fale com bruno lá po. Quer atropelar a gameplay assim é?"; }


    } 



    public static void pickPaper() {
        pick();
        pickedPaper = true;
    }
    public static void pick() { sounds[0].Play(0); }
    public static void endQuest() { sounds[1].Play(0); }

}
