using AppHarry.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppHarry.Data
{
    class DadosAlunos
    {
        public static IList<Harry> Alunos { get; set; }
        static DadosAlunos()
        {
           Alunos = new List<Harry>();
            Alunos.Add(new Harry
            {
                Nome = "Harry Potter",
                ClassePertencente = "Grifinória",
                Detalhes = "Harry Tiago Potter (31 de julho de 1980) é um bruxo inglês mestiço," +
                " e um dos mais famosos da atualidade. Ele é o único filho de Tiago e Lílian Potter, " +
                "ambos membros da Ordem da Fênix original. Seu nascimento foi ofuscado por uma profecia, " +
                "nomeando ele mesmo ou Neville Longbottom como aquele que possuía o poder de derrotar Lorde Voldemort. " +
                "Depois da metade da profecia ser relatada para o Lorde das Trevas, em cortesia de Severo Snape, " +
                "Harry foi escolhido como alvo devido às muitas semelhanças entre ele e Voldemort. Por sua vez, " +
                "isso fez com que a família Potter se escondesse. Voldemort fez sua primeira tentativa em vão de " +
                "contornar a profecia quando Harry tinha apenas um ano e três meses de idade. Durante a tentativa, " +
                "ele assassinou os pais de Harry que tentavam protegê-lo, mas a tentativa malsucedida de matar o bebê " +
                "levou à primeira queda de Voldemort. Esta queda marcou o fim da Primeira Guerra Bruxa, com Harry passando " +
                "a ser conhecido como o Menino que Sobreviveu, já que se tornou o único sobrevivente conhecido da Maldição da Morte.",
                ImagensURL = "https://wikiimg.tojsiabtv.com/wikipedia/en/d/d7/Harry_Potter_character_poster.jpg",

            });
            Alunos.Add(new Harry
            {
                Nome = "Hermione Granger",
                ClassePertencente = "Grifinória",
                Detalhes = "Hermione Jean Granger, nascida em 19 de setembro de 1979, foi uma bruxa nascida-trouxa é a filha " +
                "única dos trouxas Sr. e Sra. Granger, ambos dentistas em Londres, descritos calmos, inteligentes e pacíficos. " +
                "Ela descobriu, aos onze anos, que era uma bruxa e que fora aceita na Escola de Magia e Bruxaria de Hogwarts," +
                " Logo começou a frequentar a escola, em 1 de setembro de 1991, quando tinha onze anos, quase doze, " +
                "e foi colocada na Casa Grifinória.",
                ImagensURL = "https://super.abril.com.br/wp-content/uploads/2018/07/hermionehbphi-respromo3.jpg"
            });
            Alunos.Add(new Harry
            {
                Nome = "Ronald Weasley",
                ClassePertencente = "Grifinória",
                Detalhes = "Ronald Abílio Weasley, mais conhecido como Rony, é um bruxo inglês sangue puro nascido em 1 de março de 1980 e o sexto filho de Arthur e Molly Weasley. Ele também é o irmão mais novo de Gui, Carlinhos, Percy, Fred e Jorge e o irmão mais velho de Gina. " +
                "Rony cresceu junto de seus irmãos n'A Toca, pelos arredores de Ottery St. Catchpole em Devon.",
                ImagensURL = "https://static.wikia.nocookie.net/harrypotter/images/2/20/1480e49ef96ad1e935ae09bafc1fa152.jpg/revision/latest/scale-to-width-down/2000?cb=20210314195418&path-prefix=pt-br"
            });
            Alunos.Add(new Harry
            {
                Nome = "Draco Malfoy",
                ClassePertencente = "Sonserina",
                Detalhes = "Draco Lúcio Malfoy é um bruxo sangue puro britânico nascido em 5 de junho de 1980  e o único filho de Lúcio e Narcisa Malfoy. Sendo filho de um Comensal da Morte, o garoto foi criado para acreditar fortemente na importância da pureza de sangue. Ele frequentou a " +
                "Escola de Magia e Bruxaria de Hogwarts dentre 1991–1998 e foi classificado para a Casa Sonserina. Durante seus anos escolares, Draco se tornou amigo de Vicente Crabbe, Gregório Goyle, Pansy Parkinson e alguns outros Sonserinos — desenvolvendo assim, uma rápida rivalidade com Harry Potter.",
                ImagensURL = "https://static.wikia.nocookie.net/harrypotter/images/8/8a/Draco-malfoy-half-blood-prince-portrait-5-600x0-c-default.jpg/revision/latest?cb=20210527225304&path-prefix=pt-br"
            });
            Alunos.Add(new Harry
            {
                Nome = "Neville Longbottom",
                ClassePertencente = "Grifinória",
                Detalhes = "Professor Neville Longbottom (nascido em 30 de julho de 1980) é um bruxo sangue puro britânico e filho único de Franco e Alice Longbottom. Seus pais eram respeitados aurores e membros da Ordem da Fênix original até o momento que foram torturados à insanidade por Belatriz" +
                " Lestrange e outros três Comensais da Morte por meio da Maldição Cruciatus quando Neville tinha cerca de dezesseis meses de idade. Eles residem até hoje no Hospital St. Mungus para Doenças e Acidentes Mágicos, Amas especificamente na Enfermaria Jano Thickey. Neville após o ocorrido " +
                "foi criado por sua avó, Augusta Longbottom.",
                ImagensURL = "https://static.wikia.nocookie.net/harrypotter/images/0/04/Harry-potter-and-the-deathly-hallowspart-2.jpg/revision/latest?cb=20161120035218"
            });
        }

    }
}
