using Abstraindo_um_Jogo_de_RPG.src.Entities;
using Abstraindo_um_Jogo_de_RPG.src.Mechanics;
using static System.Console;

class Program
    {
    static void Main(string[] args){
        GameMechanics game = new GameMechanics();
        var MainCharacter = new Character();

        Write("Insert your character name: ");
        MainCharacter.Name = ReadLine();

        game.Actions(MainCharacter);
    }
}