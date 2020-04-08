using System.Collections;
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
    public static bool toggleAudio = true;

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
    public static string LANGUAGE
    {
        get
        {
            return language == Language.Portuguese ? "IDIOMA" : "LANGUAGE";
        }
    }
    public static string DEVELOPMENT
    {
        get
        {
            return language == Language.Portuguese ? "Programação" : "Development";
        }
    }
    public static string SOUNDDESIGN
    {
        get
        {
            return language == Language.Portuguese ? "Composição e Design de Som" : "Composition and sound design";
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
                "Manu cresceu numa família milionária, desde pequena sabe usar as redes sociais. Com grandes sonhos, a ruivinha pretende ascender no instagram com mais de 1 milhão de seguidores. Fã das Kardashians, a blogueira é viciada em compras e em partir corações." :
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
                "Advogada da Família de Manu Anna sempre foi ambiciosa e após um briga muito séria com Manu sobre exposição social, Anna foi demitida e agora busca vingança." :
                "Manu’s family lawyer, Anna was always ambitious and after a serious fight with Manu about social exposure, Anna was fired and now seeks revenge.";
        }
    }
    public static string MEETING_NICK
    {
        get
        {
            return language == Language.Portuguese ?
                "Nick Conhece Manu desde a infância e sempre foi apaixonado por ela. ele sempre demonstra seu amor com poesias e flores, mas Manu nunca deu bola. Mas a obsessão de Nick só fez crescer e crescer até chegar a um ponto perigoso." :
                "Nick has known Manu since childhood and has always been in love with her. he always shows his love with poetry and flowers, but Manu never paid attention. But Nick's obsession has only grow and grow until you reach a dangerous point.";
        }
    }
    public static string MEETING_SARA
    {
        get
        {
            return language == Language.Portuguese ?
                "Conheceu Manu nas aulas de yoga. Manu e Sara sempre foram opostas. Manu era a típica carnívora sanguinária e Sara uma uma vegana sentimental disposta a tudo para salvar os animais." :
                "Sara met Manu in yoga classes. Manu and Sara have always been opposed. Manu was the typical bloodthirsty carnivore and Sara was a sentimental vegan willing to do anything to save the animals.";
        }
    }
    public static string MEETING_TOM
    {
        get
        {
            return language == Language.Portuguese ?
                "Tom e Manu são amigos de academia. Tom ver Manu como sua Musa inspiradora, porém após Manu dar uma festa de 500K e não convidá - lo essa amizade foi abalada e graves consequências estão por vir." :
                "Tom and Manu are friends from the gym. Tom sees Manu as his inspiring Muse, but after Manu had a 500K party and didn't invite him, this friendship was shaken and serious consequences are to come.";
        }
    }
    public static string VICTORY
    {
        get
        {
            return language == Language.Portuguese ? "VITÓRIA" : "VICTORY";
        }
    }
    public static string VICTORYSUBTITLE
    {
        get
        {
            return language == Language.Portuguese ? "dos manulovers" : "of manulovers";
        }
    }
    public static string VICTORY_TEXT
    {
        get
        {
            return language == Language.Portuguese ? 
                "Graças ao seguidor XXX, o criminoso(a) foi pego. Agora temos mais 24 horas de stories garantidos!" :
                "Thanks to follower XXX, the criminal was caught. Now we have another 24 hours of guaranteed stories!";
        }
    }
    public static string DEFEAT
    {
        get
        {
            return language == Language.Portuguese ? "FIM DE JOGO" : "GAME OVER";
        }
    }
    public static string DEFEATSUBTITLE
    {
        get
        {
            return language == Language.Portuguese ? 
                "você decepcionou os manulovers" : 
                "you disappointed the manulovers";
        }
    }
    public static string DEFEAT_TEXT
    {
        get
        {
            return language == Language.Portuguese ?
                "Manu ainda está desaparecida. Continue tentando." :
                "Manu is still missing. Keep trying.";
        }
    }
    public static string ACCUSESUSPECT
    {
        get
        {
            return language == Language.Portuguese ? "Acusar suspeito" : "Accuse suspect";
        }
    }
    public static string ACCUSESUSPECT_TEXT
    {
        get
        {
            return language == Language.Portuguese ?
                "Chegou o grande momento, junte todas as suas pistas e acuse um suspeito." :
                "The big time has come, bring them all together your clues and accuse a suspect.";
        }
    }
    public static string ACCUSE
    {
        get
        {
            return language == Language.Portuguese ?
                "ACUSAR" :
                "ACCUSE";
        }
    }
    public static string TURNOF
    {
        get
        {
            return language == Language.Portuguese ?
                "Vez do XXX" :
                "Turn of XXX";
        }
    }
    public static string TURNOF_TEXT
    {
        get
        {
            return language == Language.Portuguese ?
                "Rápido, o bem-estar de manu depende da sua agilidade" :
                "Quick, Manu's well-being depends on your agility";
        }
    }

    public static string TIP
    {
        get
        {
            return language == Language.Portuguese ?
                "Dica 1 de 5" :
                "Tip 1 of 5";
        }
    }
    public static string TUTORIAL1
    {
        get
        {
            return language == Language.Portuguese ?
                "Para começar,  você vai adicionar os jogadores que irão fazer parte da investigação colocando o seus nomes." :
                "To start, you’ll add the players who will be part of the investigation puting their names";
        }
    }
    public static string TUTORIAL2
    {
        get
        {
            return language == Language.Portuguese ?
                "Para revelar a dica você precisa arrastar a carta" :
                "To reveal the tip you need to drag the card";
        }
    }
    public static string TUTORIAL3
    {
        get
        {
            return language == Language.Portuguese ?
                "Quando a dica for revelada você terá a opção de chutar ou passar sua vez" :
                "When the tip Will be revealed you will have the option to kick or pass your turn";
        }
    }
    public static string TUTORIAL4
    {
        get
        {
            return language == Language.Portuguese ?
                "Caso o jogador da vez já tenha alguém em mente, ele pode chutar um dos suspeitos" :
                "If the player of the turn already has someone in mind, he can kick one of the suspects";
        }
    }
}
