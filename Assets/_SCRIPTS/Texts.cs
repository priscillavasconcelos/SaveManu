﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Texts
{
    public enum Language
    {
        English,
        Portuguese
    }
    public static Language language = Language.English;

    public static string PLAY
    { 
        get 
        {
            return language == Language.Portuguese ?  "INICIAR" : "PLAY";
        }
    }
    public static string CREDITS
    {
        get
        {
            return language == Language.Portuguese ? "CRÉDITOS" : "CREDITS";
        }
    }
    public static string EXIT
    {
        get
        {
            return language == Language.Portuguese ? "SAIR" : "EXIT";
        }
    }
    public static string NEXT
    {
        get
        {
            return language == Language.Portuguese ? "PRÓXIMO" : "NEXT";
        }
    }
    public static string ADDPLAYER
    {
        get
        {
            return language == Language.Portuguese ? "Adicionar Jogador" : "Add Player";
        }
    }
    public static string ADDPLAYER_TEXT
    {
        get
        {
            return language == Language.Portuguese ? 
                "Você está prestes a desvendar um grande mistério! Escolha seu adversário e embarque nessa aventura cheia de descobertas. Mas pense bem, teremos apenas um vencedor!" :
                "You are about to unravel a great mystery! Choose your opponent and embark on this adventure full of discoveries. But think about it, we will only have one winner!";
        }
    }
    public static string MEETMANU
    {
        get
        {
            return language == Language.Portuguese ? "Conheça Manu" : "MEET MANU";
        }
    }
    public static string MEETMANU_TEXT
    {
        get
        {
            return language == Language.Portuguese ?
                "Manu cresceu numa família milionária, desde de pequena sabe usar as redes sociais. Com grandes sonhos, a ruivinha pretende ascender no instagram com mais de 1 milhão de seguidores. Fã das Kardashians, a blogueira é viciada em compras e em partir corações." :
                "Manu grew up in a millionaire family, since she was a child she knows how to use social media. With big dreams, the little  redhead wants to ascend on Instagram with over 1 million followers. A Kardashian fan, the blogger is addicted to shopping and heartbreaking.";
        }
    }
    public static string MANUISGONE
    {
        get
        {
            return language == Language.Portuguese ? "MANU SUMIU!!!" : "MANU IS GONE!!!";
        }
    }
    public static string MANUISGONE_TEXT
    {
        get
        {
            return language == Language.Portuguese ? 
                "Após 24 horas sem Manu postar em suas redes sociais, você começa a ficar preocupado... Onde está Manu??" : 
                "After 24 hours without Manu posting on your social media, you start to get worried... Where is Manu ??";
        }
    }
    public static string SUSPECTS
    {
        get
        {
            return language == Language.Portuguese ? "Suspeitos" : "Suspects";
        }
    }
    public static string MEETING
    {
        get
        {
            return language == Language.Portuguese ? "Conhecendo " : "Meeting ";
        }
    }
    public static string MEETING_ANNA
    {
        get
        {
            return language == Language.Portuguese ?
                "Advogada da Família de Manu Anna sempre foi ambiciosa e após um briga muito séria com Manu sobre exposição social, Anna foi demitida e agora busca vingança por sua carreira ter sido destruída." :
                "Lawyer of the Family of Manu Anna has always been ambitious and after a very serious fight with Manu over social exposure, Anna was fired and now seeks revenge for her career having been destroyed";
        }
    }
    public static string MEETING_NICK
    {
        get
        {
            return language == Language.Portuguese ?
                "Conhece Manu desde a infância e sempre foi apaixonado por ela. ele sempre demonstra seu amor com poesias e flores, mas Manu nunca deu bola. Mas a obsessão de Nick só faz crescer e crescer." :
                "He has known Manu since childhood and has always been in love with her. he always shows his love with poetry and flowers, but Manu never paid attention. But Nick's obsession only makes it grow and grow.";
        }
    }
    public static string MEETING_SARA
    {
        get
        {
            return language == Language.Portuguese ?
                "Conheceu Manu nas aulas de yoga. Manu e Sara sempre foram opostas. Manu era a típica carnívora sanguinária e Sara uma uma vegana sentimental disposta a tudo para salvar os animais." :
                "Met Manu at yoga classes. Manu and Sara have always been opposed.Manu was the typical bloodthirsty carnivore and Sara was a sentimental vegan willing to do anything to save the animals.";
        }
    }
    public static string MEETING_TOM
    {
        get
        {
            return language == Language.Portuguese ?
                "Tom e Manu são amigos de academia. Tom ver Manu como sua Musa inspiradora, porém após Manu dar uma festa de 500K e não convidá - lo essa amizade foi abalada e graves consequências estão por vir." :
                "Tom and Manu are friends from the gym. Tom sees Manu as his inspiring Muse, but after Manu threw a 500K party and didn't invite him, this friendship was shaken and serious consequences are to come.";
        }
    }
}
