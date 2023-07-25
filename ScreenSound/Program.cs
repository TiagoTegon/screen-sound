Album albumMegadeth = new Album();
albumMegadeth.Nome = "Hangar 18";

Musica musica1 = new Musica();
musica1.Nome = "Tornado of Souls";
musica1.Duracao = 50;

Musica musica2 = new Musica();
musica2.Nome = "Hangar 18";
musica2.Duracao = 100;

albumMegadeth.AdicionarMusica(musica1);
albumMegadeth.AdicionarMusica(musica2);

Banda megadeth = new Banda();
megadeth.AdicionarAlbum(albumMegadeth);

megadeth.ExibirDiscografia();