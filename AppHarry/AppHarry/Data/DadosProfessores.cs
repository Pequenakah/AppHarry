using AppHarry.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppHarry.Data
{
    class DadosProfessores
    {
        public static IList<Harry> Professores { get; set; }
        static DadosProfessores()
        {
            Professores = new List<Harry>();
            Professores.Add(new Harry
            {
                Nome = "Remo Lupin",
                ClassePertencente = "Grifinória",
                Detalhes = "O Professor Remo Lupin (10 de março de 1960 – 2 de maio de 1998), " +
                "também conhecido como Aluado, foi um bruxo Mestiço que teve licantropia durante sua infância. " +
                "Ele frequentou a Escola de Magia e Bruxaria de Hogwarts e foi selecionado para a Grifinória. " +
                "Durante seus anos de escola, ele foi um dos Marotos; e melhor amigo de Tiago Potter, Sirius Black, " +
                "e Pedro Pettigrew. Juntos eles criaram o Mapa do Maroto. Depois de saírem de Hogwarts, " +
                "Remo e seus amigos entraram na Ordem da Fênix e lutaram na Primeira Guerra Bruxa. " +
                "Contudo, Pettigrew traiu Tiago e Lílian Potter para Lorde Voldemort, por covardia. " +
                "Remo perdeu todos os seus amigos próximos em várias maneiras ao fim da Primeira Guerra Bruxa e da Segunda Guerra Bruxa.",
                ImagensURL = "https://veja.abril.com.br/wp-content/uploads/2016/05/o-ator-david-thewlis-na-pele-do-personagem-remo-lupin-original.jpeg"
            });
            Professores.Add(new Harry
            {
                Nome = "Severo Snape",
                ClassePertencente = "Sonserina",
                Detalhes = "O Professor Severo Snape (9 de janeiro de 1960 – 2 de maio de 1998) foi um bruxo mestiço," +
                " filho da bruxa Eileen Snape (nascida Prince) e o trouxa Tobias Snape. Durante sua vida, " +
                "Severo Snape foi Mestre de Poções (1981–1996), o professor de Defesa Contra as Artes das Trevas (ano letivo 1996-1997), " +
                "e Diretor (ano letivo 1997-1998) da Escola de Magia e Bruxaria de Hogwarts (que ele frequentou como aluno de 1971 a 1978). " +
                "Ele também foi um membro da Ordem da Fênix, e teve um papel muito importante em ambas as Guerras Bruxas contra Lord Voldemort.",
                ImagensURL = "https://oquartonerd.com.br/wp-content/uploads/2021/02/severo-snape-harry-potter.jpg"
            });
            Professores.Add(new Harry
            {
                Nome = "Minerva McGonagall",
                ClassePertencente = "Grifinória",
                Detalhes = "Professora Minerva McGonagall, O.M. (Primeira Classe), é uma bruxa escocesa mestiça, filha do trouxa Robert " +
                "McGonagall e da bruxa Isobel Ross, consequentemente, irmã mais velha de Malcolm e Robert Jr. Ela frequentou a Escola de Magia " +
                "e Bruxaria de Hogwarts e foi classificada para a Grifinória — entretanto, o Chapéu Seletor levou cerca de cinco minutos e meio" +
                " para se decidir entre Grifinória e Corvinal, tornando-a uma Hatstall —. Durante seu sétimo ano, ela foi nomeada monitora-chefe.",
                ImagensURL = "https://static.wikia.nocookie.net/newojesed/images/6/61/Minerva.jpg/revision/latest?cb=20110424214417&path-prefix=pt-br"
            });
            Professores.Add(new Harry
            {
                Nome = "Alvo Dumbledore",
                ClassePertencente = "Grifinória",
                Detalhes = "Dumbledore não é um dos maiores (se não o maior) bruxo de todos os tempos de graça. A fama que ele carrega vem de muito " +
                "tempo atrás, antes mesmo de ele assumir uma vaga de professor em Hogwarts como professor de Transfiguração. Ele também se tornou " +
                "Diretor da escola, onde sempre esteve por perto de Harry Potter, o que certamente ajudou a derrotar Voldemort.",
                ImagensURL = "https://2.bp.blogspot.com/-HeodtFb5URE/WTtOYzAUweI/AAAAAAAAur8/8oyvExVFKbs8JShhGllsgy5-NThZOgqNACLcB/s1600/alvus.jpg"
            });
            Professores.Add(new Harry
            {
                Nome = "Rubeus Hagrid",
                ClassePertencente = "Grifinória",
                Detalhes = "Hagrid sempre esteve entre os personagens mais populares e queridos da saga. Não apenas por assumir o papel de protetor " +
                "do Harry Potter, mas por sempre manter uma postura gentil com os demais alunos e professores de Hogwarts. Mas ele também tem um" +
                " passado como professor, e graças ao seu fascínio por criaturas fantásticas, foi o responsável por trazer várias delas à Escola" +
                " de Magia e Bruxaria.",
                ImagensURL = "https://wikiimg.tojsiabtv.com/wikipedia/en/1/10/RubeusHagrid.jpg"
            });
        }
    }
}
