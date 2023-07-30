using OpenAI_API;
using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuRegistrarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registro das bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Banda banda = new(nomeDaBanda);

        var client = new OpenAIAPI("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");
        var chat = client.Chat.CreateConversation();
        chat.AppendSystemMessage($"Resuma a banda {nomeDaBanda} em 1 parágrafo. Adote um estilo informal.");
        var response = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
        banda.Resumo = response;

        bandasRegistradas.Add(nomeDaBanda, banda);
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
