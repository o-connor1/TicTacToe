//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//builder.Services.AddControllersWithViews();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

//app.UseHttpsRedirection();
//app.UseStaticFiles();

//app.UseRouting();

//app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.Run();

using System;
using TicTacToe.Models.ConcreteClass;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read Player 1 name
            Console.Write("Enter Player 1 Name: ");
            string player1 = Console.ReadLine();

            // Read Player 2 name
            Console.Write("Enter Player 2 Name: ");
            string player2 = Console.ReadLine();

            // Read size of the board
            Console.Write("Enter the size of the board (e.g., 3 for 3x3): ");
            int boardSize;
            while (!int.TryParse(Console.ReadLine(), out boardSize) || boardSize <= 0)
            {
                Console.WriteLine("Please enter a valid positive number.");
            }

            // Ask if ready to play
            Console.WriteLine("Ready to play? [y/n]");
            string response = Console.ReadLine()?.Trim().ToLower();

            // Handle response
            if (response == "y" || response == "yes")
            {
                Console.WriteLine($"Let's start the game! Player 1: {player1}, Player 2: {player2}, Board Size: {boardSize}x{boardSize}");
                // game logic here
                Game ticTacToe = new Game(player1, player2, boardSize);
                ticTacToe.Play(boardSize);
            }
            else if (response == "n" || response == "no")
            {
                Console.WriteLine("Alright! Exiting the game setup.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please restart and enter 'y' or 'n'.");
            }
        }
    }
}
