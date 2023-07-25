Banda megadeth = new Banda("Megadeth");

Album albumMegadeth = new Album("Hangar 18");

Musica musica1 = new Musica(megadeth, "Tornado of Souls")
{
    Duracao = 50,
    Disponivel = true,
};

Musica musica2 = new Musica(megadeth, "Hangar 18")
{
    Duracao = 100,
    Disponivel = false,
};

albumMegadeth.AdicionarMusica(musica1);
albumMegadeth.AdicionarMusica(musica2);
megadeth.AdicionarAlbum(albumMegadeth);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumMegadeth.ExibirMusicas();
megadeth.ExibirDiscografia();