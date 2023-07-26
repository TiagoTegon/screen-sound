//Banda megadeth = new Banda("Megadeth");

//Album albumMegadeth = new Album("Hangar 18");

//Musica musica1 = new Musica(megadeth, "Tornado of Souls")
//{
//    Duracao = 50,
//    Disponivel = true,
//};

//Musica musica2 = new Musica(megadeth, "Hangar 18")
//{
//    Duracao = 100,
//    Disponivel = false,
//};

//albumMegadeth.AdicionarMusica(musica1);
//albumMegadeth.AdicionarMusica(musica2);
//megadeth.AdicionarAlbum(albumMegadeth);

//musica1.ExibirFichaTecnica();
//musica2.ExibirFichaTecnica();
//albumMegadeth.ExibirMusicas();
//megadeth.ExibirDiscografia();

Episodio ep1 = new Episodio(2, "Megadeth", 60);
ep1.AdicionarConvidado("Marty Friedman");
ep1.AdicionarConvidado("Kiko Loureiro");

Episodio ep2 = new Episodio(1, "Brazil Metal", 120);
ep2.AdicionarConvidado("Rafael Bitencourt");
ep2.AdicionarConvidado("Gustavo Andreoli");

Podcast podcast1 = new Podcast("Metal Bands", "O Cara do Metal");
podcast1.AdicionarEpisodio(ep1);
podcast1.AdicionarEpisodio(ep2);
podcast1.ExibirDetalhes();
